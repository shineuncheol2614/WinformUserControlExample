using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_WINFORM_Csharp
{
    public partial class Form1 : Form
    {
        int pVal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void userControl1_ValueChangeEvent(object sender , EventArgs e)
        {
            textBox1.Text = userControl1.Value.ToString();
            pValueTextBox.Text = pVal.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl1.Value = 50;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

            textBox1.Text = userControl1.Value.ToString();
            pValueTextBox.Text = userControl1.pV.ToString();

        }

        private void userControl1_MouseDown(object sender, MouseEventArgs e)
        {
            pVal = userControl1.pV;

        }
    }
}
