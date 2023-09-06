using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Satis_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bilet, su, çay, misir, toplam;

            bilet = Convert.ToInt16(textBox1.Text);
            misir = Convert.ToInt16(textBox2.Text);
            su = Convert.ToInt16(textBox3.Text);
            çay = Convert.ToInt16(textBox4.Text);



            toplam = bilet * 60 + misir * 30 + su * 5 + çay * 9;




            label11.Text = toplam.ToString();

            if (radioButton1.Checked)
            {
                MessageBox.Show("A Filmine Başarıyla Bilet Aldınız");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("B Filmine Başarıyla Bilet Aldınız");
            }

            else if (radioButton3.Checked)
            {
                MessageBox.Show("C Filmine Başarıyla Bilet Aldınız");

            }
            else if (radioButton4.Checked)
            {
                MessageBox.Show("D Filmine Başarıyla Bilet Aldınız");

            }
            else
            {
                MessageBox.Show("Bilet almak istediğiniz Filmi seçin");
            }









        }
    }
}
