using System;
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
    public partial class Form4 : Form
    {
        int sayac = 20;
        public Form4()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton3.BackColor = Color.Green;
                radioButton2.BackColor = Color.Red;
                radioButton1.BackColor = Color.Red;
                radioButton4.BackColor = Color.Red;
            }
            else
            {
                radioButton3.BackColor = Color.Green;
                radioButton2.BackColor = Color.Red;
                radioButton1.BackColor = Color.Red;
                radioButton4.BackColor = Color.Red;
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            this.Hide();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            labelsayac.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer1.Enabled = false;

                MessageBox.Show("Süreniz dolmuştur");
                if (radioButton1.Checked)
                {
                    radioButton1.BackColor = Color.Green;
                }
                else if (radioButton2.Checked)
                {
                    radioButton2.BackColor = Color.Red;

                }
                else if (radioButton3.Checked)
                {
                    radioButton3.BackColor = Color.Red;

                }
                else if (radioButton4.Checked)
                {
                    radioButton4.BackColor = Color.Red;
                }
            }

        }
    }
}
