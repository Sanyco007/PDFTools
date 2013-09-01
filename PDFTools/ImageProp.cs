using System;
using System.Drawing;

namespace PDFTools
{
    [Serializable]
    public class ImageProp
    {
        public Bitmap Bitmap;
        public int Left;
        public int Top;
        public int Width;
        public int Height;
        public int Page;
        public int Group;

        private bool _mouseDown;
        private int _mouseX;
        private int _mouseY;
        private bool _loadImage;

        public ImageProp()
        {
            Bitmap = new Bitmap(200, 200);
            _mouseDown = false;
            _loadImage = false;
            Width = 120;
            Height = 40;
            SetGroup(0);
        }

        public ImageProp(ImageProp item)
        {
            Bitmap = new Bitmap(200, 200);
            _mouseDown = false;
            _loadImage = false;
            Width = item.Width;
            Height = item.Height;
            Left = item.Left;
            Top = item.Top;
            Page = item.Page;
            SetGroup(item.Group);
        }

        public void SetBitmap(Bitmap image)
        {
            Bitmap = image;
            _loadImage = true;
        }

        public void SetGroup(int group)
        {
            Group = group;
            if (!_loadImage)
            using (var gr = Graphics.FromImage(Bitmap))
            {
                gr.Clear(Group == 0 ? Color.CornflowerBlue : Color.FromArgb((Group*5)%255, (Group*15)%255, (Group*25)%255));
            }
        }

        public void ResetBitmap()
        {
            Bitmap = new Bitmap(200, 200);
            using (var gr = Graphics.FromImage(Bitmap))
            {
                gr.Clear(Group == 0 ? Color.CornflowerBlue : Color.FromArgb((Group * 5) % 255, (Group * 15) % 255, (Group * 25) % 255));
            }
        }

        public bool LoadMouseDown(int x, int y, int page)
        {
            if (page != Page) return false;
            if (x >= Left && x <= Left + Width && y >= Top && y <= Top + Height)
            {
                return true;
            }
            return false;
        }

        public bool MouseDown(int x, int y, int page)
        {
            if (page != Page) return _mouseDown = false;
            if (x >= Left && x <= Left + Width && y >= Top && y <= Top + Height)
            {
                _mouseX = x;
                _mouseY = y;
                return _mouseDown = true;
            }
            return _mouseDown = false;
        }

        public void MouseMove(int x, int y)
        {
            if (_mouseDown)
            {
                int dx = x - _mouseX;
                int dy = y - _mouseY;
                Left += dx;
                if (Left < 0) Left = 0;
                Top += dy;
                if (Top < 0) Top = 0;
                _mouseX = x;
                _mouseY = y;
            }
        }

        public void MouseUp()
        {
            _mouseDown = false;
        }
    }
}
