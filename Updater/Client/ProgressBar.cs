using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ClientUpdater
{
    public class ProgressBar
    {

        Brush c;
        Brush b;
        Rectangle r;
        Bitmap btm;
        Graphics g;
        Rectangle StringRect;

        public int _Maximum, _Current = (0);
        public string _DrawString = string.Empty;

        Font Font = new Font("Microsoft Sans Serif", 6, FontStyle.Italic);
        SolidBrush Brush = new SolidBrush(Color.WhiteSmoke);

     


        public ProgressBar(Brush BarColor, Brush BorderColor, Rectangle Area, int MaxValue)
        {
            btm = new Bitmap(Area.Width+1, Area.Height+1);
            g = Graphics.FromImage(btm);
            _Maximum = MaxValue;
            b = BorderColor;
            c = BarColor;
            r = Area;
        }

        public void SetCurrent(int cr)
        {
            _Current = cr;
        }
        public void SetDrawString(string ds)
        {
            _DrawString = ds;
        }
        public Point GetCorner()
        {
            return new Point(r.X, r.Y);
        }

        public Bitmap DrawProgressBar()
        {
            float percent = (float)_Current / (float)_Maximum;
            int actual = (int)(percent * r.Width);
            StringRect = new Rectangle(120, 0, r.Width + 4, r.Height + 4);

            g.Clear(Color.FromArgb(0, 0, 0, 0));
            g.FillRectangle(Brushes.Black, StringRect);
            g.FillRectangle(c, new Rectangle(0, 0, actual, r.Height));

            g.DrawRectangle(new Pen(b), new Rectangle(0, 0, r.Width, r.Height));
            g.DrawString(_DrawString, Font, Brush, StringRect);
            return btm;
        }
    }
}
