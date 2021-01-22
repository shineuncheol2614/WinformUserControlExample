using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_WINFORM_Csharp
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler ValueChangeEvent;

        int max = 100; int val = 50;
        int pValue;
        Boolean cancel = false;

        public int MaxValue
        {
            get { return max; }
            set
            {
                if (max == 0)
                    max = 1;
                max = value;
                DrawControl();
            }
        }

        public int Value
        {
            get { return val; }
            set
            {
                if (val == 0)
                    val = 1;
                val = value; 
                DrawControl();
            }
        }

        public int pV
        {
            get { return val; }
            set
            {
                if (val == 0)
                    val = 1;
                val = value;
                DrawControl();
            }
        }

        public UserControl1()
        {
            InitializeComponent();
            Value = 50;
            DrawControl();
        }

        public void DrawControl()
        {

                    DrawControl(wtf(val, max, this.Width));
            

        }

        private void DrawControl(int ccircle)
        {
            try
            {

                using (var grp = this.CreateGraphics())
                {
                    grp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    this.Refresh();
                    Pen pen = new Pen(Color.Black, 2);
                    grp.DrawLine(pen, 0, 12, 400, 12);
                    grp.DrawEllipse(new Pen(Color.White, 2), ccircle, 5, 15, 15);
                    grp.FillEllipse(new SolidBrush(Color.White), ccircle, 5, 15, 15);

                    pen.Dispose();
                }
                this.Update();

            }
            catch
            {
            }
        }

        int circle = 1;
        bool isDown = false;

        private void PProgressBar_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            pValue = e.X;
        }

        private void PProgressBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown == true)
            {
                MoveProgress(e.X, e.Y);
            }
        }

        private void PProgressBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (cancel)
            {
                pV = wtf(pValue, this.Width, MaxValue);
                cancel = false;
            }
            isDown = false;
            
        }

        private void cancelFunc()
        {
            pV = wtf(pValue, this.Width, MaxValue);

        }

        private void MoveProgress(int X,int Y)
        {
            try
            {
                if (Y < 30 && Y > 10)
                {
                    if (X <= 0)
                        X = 1;
                    if (X >= this.Width)
                        X = this.Width - 1;

                    Value = wtf(X, this.Width, MaxValue);
                    ValueChangeEvent(Value, new EventArgs());
                }
                else
                {
                    cancel = true;
                }

                
            }
            catch
            {
                //...
            }
        }

        public int wtf(int value, int max, int width)
        {
            return value * width / max;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Value = 50;
            timer1.Stop();
        }
    }
}
