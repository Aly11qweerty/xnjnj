﻿using System;
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
    public partial class carta : Form
    {
        public carta()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            button8.Visible = true;
            label3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            button7.Visible = true;
            label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
            button9.Visible = true;
            label4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Visible = false;
            button8.Visible = true;
            label3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Visible = false;
            button8.Visible = true;
            label3.Visible = true;
        }
    }
}
