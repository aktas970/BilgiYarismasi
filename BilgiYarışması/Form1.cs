﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.ControlBox = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if (panel2.Width>=201)
            {
                timer1.Stop();
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }

        }
    }
}
