using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testButton
{
    class roundButton : Button
    {

        public string ControlText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;



        int nRadius = 20;
            int BorderSize = 4;

            nRadius = Math.Min(nRadius, Height - BorderSize * 2);
            Rectangle rect = new Rectangle(BorderSize, BorderSize, Width - BorderSize * 2, Height - BorderSize * 2);
            using (System.Drawing.Drawing2D.GraphicsPath gp = CreatePath(rect, nRadius, false))
            {
                System.Drawing.Pen pen = new System.Drawing.Pen(Color.Gray, BorderSize);
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                e.Graphics.FillPath(new SolidBrush(Color.Gray), gp);
                e.Graphics.DrawPath(pen, gp);
            }

            System.Drawing.Size textSize = TextRenderer.MeasureText(this.ControlText, this.Font);
            var nWidth = ((this.Width - textSize.Width) / 2);
            var nHeight = ((this.Height - textSize.Height) / 2);
            System.Drawing.Point drawPoint = new System.Drawing.Point(nWidth, nHeight);
            Rectangle normalRect = new Rectangle(drawPoint, textSize);
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, normalRect, ForeColor);

        }

        public static System.Drawing.Drawing2D.GraphicsPath CreatePath(Rectangle rect, int nRadius, bool bOutline)
        {
            int nShift = bOutline ? 1 : 0;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X + nShift, rect.Y, nRadius, nRadius, 180f, 90f);
            path.AddArc((rect.Right - nRadius) - nShift, rect.Y, nRadius, nRadius, 270f, 90f);
            path.AddArc((rect.Right - nRadius) - nShift, (rect.Bottom - nRadius) - nShift, nRadius, nRadius, 0f, 90f);
            path.AddArc(rect.X + nShift, (rect.Bottom - nRadius) - nShift, nRadius, nRadius, 90f, 90f);
            path.CloseFigure();
            return path;
        }


        private void InitializeComponent()
        {

        }

    }
}
