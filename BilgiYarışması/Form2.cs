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
    public partial class Form2 : Form
    {
        int sayac = 20;
        //public void cevaplar (RadioButton seciliolan)
        //{
        //    if (seciliolan.Checked == true)
        //    {
        //        seciliolan.BackColor = Color.Green;
                
        //    }
        //    else
        //    {
                
        //    }
        //}
        //public void cevaplar2(RadioButton seciliolmayan)
        //{
        //    if (seciliolmayan.Checked == false)
        //    {
        //        seciliolmayan.BackColor = Color.Red;

        //    }

        //}
            public Form2()
        {
            InitializeComponent();
            //timer1.Start();
            //if (radioButton1.Checked)
            //{
            //    timer1.Enabled = false;
            //}
           
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
                else if(radioButton2.Checked)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.BackColor = Color.Green;
                radioButton1.BackColor = Color.Red;
                radioButton3.BackColor = Color.Red;
                radioButton4.BackColor = Color.Red;
            }
            else
            {
                radioButton2.BackColor = Color.Green;
                radioButton1.BackColor = Color.Red;
                radioButton3.BackColor = Color.Red;
                radioButton4.BackColor = Color.Red;
            }
            timer1.Stop();
            //if (radioButton1.Checked)
            //{
            //    radioButton1.BackColor = Color.Green;
            //}
            //if (radioButton2.Checked)
            //{
            //    radioButton2.BackColor = Color.Red;

            //}
            //if (radioButton3.Checked)
            //{
            //    radioButton3.BackColor = Color.Red;

            //}
            //if (radioButton4.Checked)
            //{
            //    radioButton4.BackColor = Color.Red;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Hide();
            frm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
