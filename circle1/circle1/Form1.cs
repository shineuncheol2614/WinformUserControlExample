using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circle1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int value = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            value = 0;
            circularProgressBar1.ProgressColor = Color.FromArgb(255, 128, 0);

            if (radioButton1.Checked)
                timer1.Start();

            if (radioButton2.Checked)
                timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
  
            int RanNum = random.Next(1, 10);
            value += RanNum;
            if (value >= 100)
            {
                value = 100;
                timer1.Stop();
            }
            listBox1.Items.Add("Random : " + RanNum + "   Value : " + value);

            circularProgressBar1.Value = value;
            circularProgressBar1.ProgressColor = Color.FromArgb(255, 128 - value, 0);
            circularProgressBar1.Text = value.ToString();
            circularProgressBar1.Update();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            double sin = 0f;
            sin += Math.Abs(Math.Sin(value));
            value += ((int)sin+1);


            if (value >= 100)
            {
                value = 100;
                timer2.Stop();
            }

            listBox1.Items.Add("SINE : " + sin + "   Value : " + value);

            circularProgressBar1.Value = value;
            circularProgressBar1.ProgressColor = Color.FromArgb(255, 128 - value, 0);
            circularProgressBar1.Text = value.ToString();
            circularProgressBar1.Update();
        }
    }
}