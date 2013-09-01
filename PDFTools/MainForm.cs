using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using PDFTools.Properties;
using Cyotek.GhostScript;
using Cyotek.GhostScript.PdfConversion;


namespace PDFTools
{
    public partial class MainForm : Form
    {

        //Имя открытого файла (нужно при сохранении)
        private string _pdfFileName;

        //Настройки преобразования pdf в png
        private readonly Pdf2ImageSettings _settings;

        //Количество страниц в документе
        private int _pageCount;

        //Текущая страница
        private int _currentPage;

        //Текущая страница в виде картинки
        private Bitmap _currentImage;

        //Список добавленных изоражений
        private List<ImageProp> _list;
        
        //Необходимость перерисовки
        private bool _canRender;

        //Нажатие мышки
        private bool _mouseDown;

        //Обьект для сохранения документа
        private PdfSaver _saver;

        //Переключатель масштабирования/перемещение
        private bool _resize;

        //Масштаб
        private float _zoom;

        //Исходный размер страницы
        private Point _size;

        //Конструктор формы
        public MainForm()
        {
            InitializeComponent();
            //Настройки рендеринга pdf
            _settings = new Pdf2ImageSettings
            {
                AntiAliasMode = AntiAliasMode.High,
                Dpi = 96,
                GridFitMode = GridFitMode.Topological,
                ImageFormat = ImageFormat.Png24
            };
            //Инициализация
            _zoom = 1f;
            _canRender = true;
            _mouseDown = false;
            _resize = false;
            _currentPage = 0;
            tscbZoom.SelectedIndex = 1;
            _list = new List<ImageProp>();
        }

        /**************Обработчики событий******************/

        //Открытие pdf
        private void tsmiOpenPdf_Click(object sender, EventArgs e)
        {
            if (openPdfDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openPdfDialog.FileName;
                _list.Clear();
                lbImageList.Items.Clear();
                _saver = new PdfSaver(fileName);
                _pdfFileName = fileName;
                _pageCount = new Pdf2Image(fileName).PageCount;
                _currentPage = 1;
                SetPage(_currentPage);
                _size = new Point(_currentImage.Width, _currentImage.Height);
                _zoom = 1f;
                tscbZoom.SelectedIndex = 1;
            }
        }

        //Предыдущая страница
        private void tsbPrevPage_Click(object sender, EventArgs e)
        {
            _currentPage--;
            if (_currentPage < 1) _currentPage = 1;
            else SetPage(_currentPage);
        }

        //Следующая страница
        private void tsbNextPage_Click(object sender, EventArgs e)
        {
            _currentPage++;
            if (_currentPage > _pageCount) _currentPage = _pageCount;
            else SetPage(_currentPage);
        }

        //Добавление изображения
        private void tsbAddImage_Click(object sender, EventArgs e)
        {
            if (_currentPage < 1) return;

            var item = new ImageProp { Page = _currentPage };
            _list.Add(item);
            lbImageList.Items.Add("Image" + _list.Count);
            lbImageList.SelectedIndex = _list.Count - 1;
            _canRender = false;
            ShowData(item);
            _canRender = true;
            RenderPage();
        }

        //Изменение значения положения X
        private void nudX_ValueChanged(object sender, EventArgs e)
        {
            int index = lbImageList.SelectedIndex;
            if (index < 0) return;
            _list[index].Left = (int)nudX.Value;
            RenderPage();
        }

        //Изменение значения положения Y
        private void nudY_ValueChanged(object sender, EventArgs e)
        {
            int index = lbImageList.SelectedIndex;
            if (index < 0) return;
            _list[index].Top = (int)nudY.Value;
            RenderPage();
        }

        //Изменение ширины изображения
        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            int index = lbImageList.SelectedIndex;
            if (index < 0) return;
            _list[index].Width = (int)nudWidth.Value;
            RenderPage();
        }

        //Изменение высоты изображения
        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            int index = lbImageList.SelectedIndex;
            if (index < 0) return;
            _list[index].Height = (int)nudHeight.Value;
            RenderPage();
        }

        //Выход с программы
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Изменение группы изображения
        private void nudGroup_ValueChanged(object sender, EventArgs e)
        {
            int index = lbImageList.SelectedIndex;
            if (index < 0) return;
            _list[index].SetGroup((int)nudGroup.Value);
            RenderPage();
        }

        //Нажатие мышкой на канве
        private void PbPdfMouseDown(object sender, MouseEventArgs e)
        {
            var x = (int)(e.X / _zoom);
            var y = (int)(e.Y / _zoom);
            if (e.Button == MouseButtons.Left)
            {
                foreach (var item in _list)
                {
                    if (item.MouseDown(x, y, _currentPage))
                    {
                        lbImageList.SelectedIndex = _list.IndexOf(item);
                        _canRender = false;
                        ShowData(item);
                        _canRender = true;
                        _mouseDown = true;
                        lbImageList.Focus();
                        break;
                    }
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                foreach (var item in _list)
                {
                    if (item.LoadMouseDown(x, y, _currentPage))
                    {
                        int group = item.Group;
                        var openImage = new OpenFileDialog { Filter = "" };
                        if (openImage.ShowDialog() == DialogResult.OK)
                        {
                            var image = PrepareBitmap((Bitmap)Image.FromFile(openImage.FileName));

                            if (group != 0)
                            {
                                foreach (var gItem in _list)
                                {
                                    if (gItem.Group == group)
                                    {
                                        gItem.SetBitmap(image);
                                    }
                                }
                            }
                            else item.SetBitmap(image);
                        }
                        RenderPage();
                        break;
                    }
                }
            }
        }

        //Перемещение мышки по канве
        private void PbPdfMouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                var x = (int)(e.X / _zoom);
                var y = (int)(e.Y / _zoom);
                foreach (var item in _list)
                {
                    item.MouseMove(x, y);
                }
                int index = lbImageList.SelectedIndex;
                _canRender = false;
                ShowData(_list[index]);
                _canRender = true;
                RenderPage();
            }
        }

        //Отпускание мышки
        private void PbPdfMouseUp(object sender, MouseEventArgs e)
        {
            foreach (var item in _list)
            {
                item.MouseUp();
            }
            _mouseDown = false;
        }

        //Сохранение pdf
        private void TsbSavePdfClick(object sender, EventArgs e)
        {
            if (_saver == null) return;
            if (savePdfDialog.ShowDialog() == DialogResult.OK)
            {
                string outFile = savePdfDialog.FileName;
                _saver.Save(outFile, _list);
                MessageBox.Show(Resources.Ready, Resources.Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Управление с клавиатуры
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.R)
            {
                tslInfo_Click(null, null);
            }

            int index = lbImageList.SelectedIndex;
            if (index < 0) return;
            var item = _list[index];

            const int inc = 1;

            if (!_resize)
            {

                if (e.KeyData == Keys.A)
                {
                    item.Left -= inc;
                    if (item.Left < 0) item.Left = 0;
                    nudX.Value = item.Left;
                }
                else if (e.KeyData == Keys.D)
                {
                    item.Left += inc;
                    nudX.Value = item.Left;
                }
                else if (e.KeyData == Keys.W)
                {
                    item.Top -= inc;
                    if (item.Top < 0) item.Top = 0;
                    nudY.Value = item.Top;
                }
                else if (e.KeyData == Keys.S)
                {
                    item.Top += inc;
                    nudY.Value = item.Top;
                }
            }
            else
            {

                if (e.KeyData == Keys.A)
                {
                    item.Width -= inc;
                    if (item.Width < 1) item.Width = 1;
                    nudWidth.Value = item.Width;
                }
                else if (e.KeyData == Keys.D)
                {
                    item.Width += inc;
                    nudWidth.Value = item.Width;
                }
                else if (e.KeyData == Keys.S)
                {
                    item.Height += inc;
                    nudHeight.Value = item.Height;
                }
                else if (e.KeyData == Keys.W)
                {
                    item.Height -= inc;
                    if (item.Height < 1) item.Height = 1;
                    nudHeight.Value = item.Height;
                }
            }
        }

        //Изменение режима перемещение/масштабирование
        private void tslInfo_Click(object sender, EventArgs e)
        {
            _resize = !_resize;
            if (_resize)
            {
                tslInfo.Text = Resources.SizeOn;
                tslInfo.ForeColor = Color.Orange;
            }
            else
            {
                tslInfo.Text = Resources.Movement;
                tslInfo.ForeColor = Color.Blue;
            }
        }

        //Удаление изображения
        private void tsbDeleteImage_Click(object sender, EventArgs e)
        {
            int index = lbImageList.SelectedIndex;
            if (index < 0) return;
            _list.RemoveAt(index);
            lbImageList.Items.RemoveAt(index);
            RenderPage();
        }

        //Изменение масштаба
        private void tscbZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tscbZoom.SelectedIndex;
            if (_saver == null || index < 0) return;
            string data = tscbZoom.Items[index].ToString();
            data = data.Split('%')[0].Trim();
            _zoom = float.Parse(data) / 100f;
            pbPDF.Width = (int)(_size.X * _zoom);
            pbPDF.Height = (int)(_size.Y * _zoom);
        }

        //Запрет ввода масштаба вручную
        private void tscbZoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Сохранение шаблона
        private void tsbSaveTemplate_Click(object sender, EventArgs e)
        {
            if (_currentPage < 1 || _list.Count < 1) return;
            var tmpList = _list.Select(item => new ImageProp(item)).ToList();
            var saveTemplate = new SaveFileDialog
            {
                Filter = Resources.TemplateFile,
                AddExtension = true
            };
            if (saveTemplate.ShowDialog() == DialogResult.OK)
            {
                var fs = new FileStream(saveTemplate.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                var bf = new BinaryFormatter();
                bf.Serialize(fs, tmpList);
                fs.Close();
            }
        }

        //Открытие шаблона
        private void tsbOpenTemplate_Click(object sender, EventArgs e)
        {
            if (_currentPage < 1) return;
            var openTemplate = new OpenFileDialog
            {
                Filter = Resources.TemplateFile
            };
            if (openTemplate.ShowDialog() == DialogResult.OK)
            {
                _list.Clear();
                var fs = new FileStream(openTemplate.FileName,
                    FileMode.Open, FileAccess.Read, FileShare.Read);
                var bf = new BinaryFormatter();
                _list = (List<ImageProp>)bf.Deserialize(fs);
                fs.Close();
                for (int i = 0; i < _list.Count; i++)
                {
                    lbImageList.Items.Add("Image" + (i + 1));
                }
                lbImageList.SelectedIndex = 0;
                ShowData(_list[0]);
                RenderPage();
            }
        }

        /****************Служебные методы**********************/

        //Возвращает параметры преобразования в картинку
        protected virtual IDictionary<GhostScriptCommand, object> GetConversionArguments(
            string pdfFileName, string outputImageFileName, int pageNumber, string password, 
            Pdf2ImageSettings settings)
        {
            IDictionary<GhostScriptCommand, object> arguments = 
                new Dictionary<GhostScriptCommand, object>();

            // basic GhostScript setup
            arguments.Add(GhostScriptCommand.Silent, null);
            arguments.Add(GhostScriptCommand.Safer, null);
            arguments.Add(GhostScriptCommand.Batch, null);
            arguments.Add(GhostScriptCommand.NoPause, null);

            // specify the output
            arguments.Add(GhostScriptCommand.Device, GhostScriptAPI.GetDeviceName(
                settings.ImageFormat));
            arguments.Add(GhostScriptCommand.OutputFile, outputImageFileName);

            // page numbers
            arguments.Add(GhostScriptCommand.FirstPage, pageNumber);
            arguments.Add(GhostScriptCommand.LastPage, pageNumber);

            // graphics options
            arguments.Add(GhostScriptCommand.UseCIEColor, null);

            if (settings.AntiAliasMode != AntiAliasMode.None)
            {
                arguments.Add(GhostScriptCommand.TextAlphaBits, settings.AntiAliasMode);
                arguments.Add(GhostScriptCommand.GraphicsAlphaBits, settings.AntiAliasMode);
            }

            arguments.Add(GhostScriptCommand.GridToFitTT, settings.GridFitMode);

            // image size
            if (settings.TrimMode != PdfTrimMode.PaperSize)
                arguments.Add(GhostScriptCommand.Resolution, settings.Dpi.ToString(
                    CultureInfo.InvariantCulture));
            
            switch (settings.TrimMode)
            {
                case PdfTrimMode.PaperSize:
                    if (settings.PaperSize != PaperSize.Default)
                    {
                        arguments.Add(GhostScriptCommand.FixedMedia, true);
                        arguments.Add(GhostScriptCommand.PaperSize, settings.PaperSize);
                    }
                    break;
                case PdfTrimMode.TrimBox:
                    arguments.Add(GhostScriptCommand.UseTrimBox, true);
                    break;
                case PdfTrimMode.CropBox:
                    arguments.Add(GhostScriptCommand.UseCropBox, true);
                    break;
            }

            // pdf password
            if (!string.IsNullOrEmpty(password))
                arguments.Add(GhostScriptCommand.PDFPassword, password);

            // pdf filename
            arguments.Add(GhostScriptCommand.InputFile, pdfFileName);

            return arguments;
        }

        //Преобразование pdf в картинку
        private void ConvertPdfPageToImage(string outputFileName, int pageNumber)
        {
            if (pageNumber < 1 || pageNumber > _pageCount)
            {
                throw new ArgumentException(Resources.ReadPageError, "pageNumber");
            }

            using (var api = new GhostScriptAPI())
            {
                api.Execute(GetConversionArguments(_pdfFileName, outputFileName, pageNumber, 
                    null, _settings));
            }
        }

        //Возвращает картинку в виде Bitmap
        public Bitmap GetImage(int pageNumber)
        {
            Bitmap result;

            if (pageNumber < 1 || pageNumber > _pageCount)
            {
                throw new ArgumentException(Resources.ReadPageError, "pageNumber");
            }

            string workFile = Path.GetTempFileName();

            try
            {
                ConvertPdfPageToImage(workFile, pageNumber);
                using (var stream = new FileStream(workFile, FileMode.Open, FileAccess.Read))
                {
                    result = new Bitmap(stream);
                }
            }
            finally
            {
                File.Delete(workFile);
            }

            return result;
        }

        //Установка текущей странички
        private void SetPage(int index)
        {
            _currentImage = GetImage(index);
            pbPDF.Image = new Bitmap(_currentImage);
            pbPDF.Width = _currentImage.Width;
            pbPDF.Height = _currentImage.Height;
            statusLabel.Text = String.Format("Страница {0} из {1}", index, _pageCount);
            RenderPage();
        }

        //Отображение данных текущего изображения
        private void ShowData(ImageProp item)
        {
            nudGroup.Value = item.Group;
            nudX.Value = item.Left;
            nudY.Value = item.Top;
            nudWidth.Value = item.Width;
            nudHeight.Value = item.Height;
        }

        //Отрисовка текущей странички с изображениями
        private void RenderPage()
        {
            if (!_canRender) return;
            //dispose current image
            if (pbPDF.Image != null) pbPDF.Image.Dispose();
            //prepare new temp image
            var tmp = new Bitmap(_currentImage);
            using (var gr = Graphics.FromImage(tmp))
            {
                //draw all items on current page
                foreach (var item in _list.Where(item => item.Page == _currentPage))
                {
                    gr.DrawImage(item.Bitmap, new Rectangle(item.Left, item.Top, item.Width, item.Height));
                }
            }
            //show result
            pbPDF.Image = tmp;
            pbPDF.Refresh();
        }

        //Обрезка изображения
        private Bitmap PrepareBitmap(Bitmap bitmap)
        {
            int h = 0;
            for (int i = 0; i < bitmap.Height; i++)
            {
                float pixel = bitmap.GetPixel(0, i).GetBrightness();
                if (pixel > 0.5f)
                {
                    h = i;
                    break;
                }
            }
            var res = new Bitmap(bitmap.Width, h);
            using (Graphics gr = Graphics.FromImage(res))
            {
                gr.DrawImage(bitmap, new Rectangle(0, 0, res.Width, res.Height), 0, 0, bitmap.Width, h, GraphicsUnit.Pixel);
            }
            bitmap.Dispose();
            return res;
        }

    }
}
