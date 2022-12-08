using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class bmi : Form
    {
        float index;
        float r;
        float v;
        float pol;
        public bmi()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            r = float.Parse(textBox1.Text);
            v = float.Parse(textBox2.Text);
            r = r / 100;
            index = pol + v / (r * r);
            label6.Text = index.ToString("N");
            trackBar1.Value = (int)index;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pol = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pol = -1.2f;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            private void label6_Click(double _coff)
            {
                trackBar1.Value = Convert.ToInt32(_coff * 10);
                label1.Text = _coff.ToString("0.0");

                double percent = ((double)trackBar1.Value + 0.0) / ((double)trackBar1.Maximum + 10.0);
                label1.Left = Convert.ToInt32(trackBar1.Width * percent);
            }


        }
    }
}
