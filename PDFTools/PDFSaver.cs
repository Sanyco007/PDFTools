using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDFTools
{
    public class PdfSaver
    {
        private readonly string _fileName;
        private PdfDocument _document;

        public PdfSaver(string fileName)
        {
            _fileName = fileName;
        }

        public void Save(string outFile, List<ImageProp> list)
        {
            _document = Open(_fileName);
            for (int i = 0; i < _document.PageCount; i++)
            {
                
                XGraphics gfx = XGraphics.FromPdfPage(_document.Pages[i]);

                int page = i + 1;
                foreach (var item in list.Where(item => item.Page == page))
                {

                    gfx.DrawImage(item.Bitmap, new Rectangle(
                        (int)Math.Round(item.Left * 0.75),
                        (int)Math.Round(item.Top * 0.75),
                        (int)Math.Round(item.Width * 0.75),
                        (int)Math.Round(item.Height * 0.75))
                    );
                }
            }
            _document.Save(outFile);
        }

        static public PdfDocument Open(string sFilename)
        {

            PdfDocument reader = new PdfDocument();

            try
            {
                reader = PdfReader.Open(sFilename, PdfDocumentOpenMode.Modify);
            }
            catch (PdfSharp.Pdf.IO.PdfReaderException)
            {
                //workaround if pdfsharp doesnt dupport this pdf
                string newName = WriteCompatiblePdf(sFilename);
                reader = PdfReader.Open(newName, PdfDocumentOpenMode.Modify);
            }

            return reader;
        }

        static private string WriteCompatiblePdf(string sFilename)
        {
            string sNewPdf = Guid.NewGuid().ToString() + ".pdf";

            iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(sFilename);

            // we retrieve the total number of pages
            int n = reader.NumberOfPages;
            // step 1: creation of a document-object
            iTextSharp.text.Document document = new iTextSharp.text.Document(reader.GetPageSizeWithRotation(1));
            // step 2: we create a writer that listens to the document
            iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, new FileStream(sNewPdf, FileMode.Create));
            //write pdf that pdfsharp can understand
            writer.SetPdfVersion(iTextSharp.text.pdf.PdfWriter.PDF_VERSION_1_4);
            // step 3: we open the document
            document.Open();
            iTextSharp.text.pdf.PdfContentByte cb = writer.DirectContent;
            iTextSharp.text.pdf.PdfImportedPage page;

            int rotation;

            int i = 0;
            while (i < n)
            {
                i++;
                document.SetPageSize(reader.GetPageSizeWithRotation(i));
                document.NewPage();
                page = writer.GetImportedPage(reader, i);
                rotation = reader.GetPageRotation(i);
                if (rotation == 90 || rotation == 270)
                {
                    cb.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(i).Height);
                }
                else
                {
                    cb.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                }
            }
            // step 5: we close the document
            document.Close();
            return sNewPdf;
        }

    }
}
