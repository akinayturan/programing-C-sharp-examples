using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class karmasiksayi
        {
            public int gercel, sanal;
            public karmasiksayi()
            {
                gercel = 1;
                sanal = 3;
            }
            public karmasiksayi(int _gercel, int _sanal)
            {
                gercel = _gercel;
                sanal = _sanal;
            }
            public void goster()
            {
                string gercelstr = gercel.ToString();
                string sanalstr = sanal.ToString() + "i";
                MessageBox.Show("Z = " + gercelstr + " + " + sanalstr);
            }

            public static karmasiksayi operator +(karmasiksayi k1, karmasiksayi k2)
            {

                k1.gercel += k2.gercel;
                k1.sanal += k2.sanal;
                return k1;

            }
            public static karmasiksayi operator -(karmasiksayi k1, karmasiksayi k2)
            {
                k1.gercel -= k2.gercel;
                k1.sanal -= k2.sanal;
                return k1;
            }
            public static karmasiksayi operator *(karmasiksayi k1, karmasiksayi k2)
            {
                k1.gercel *= k2.gercel;
                k1.sanal *= k2.sanal * -1;
                return k1;

            }
        }

        
        karmasiksayi x, y;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            x = new karmasiksayi(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            y = new karmasiksayi(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            karmasiksayi sonuc = x + y;
            string gosterilecek = sonuc.gercel.ToString() + " + " + sonuc.sanal.ToString() + "i";
            textBox5.Text = gosterilecek;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            x = new karmasiksayi(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            y = new karmasiksayi(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            karmasiksayi sonuc = x - y;
            string gosterilecek = sonuc.gercel.ToString() + " + " + sonuc.sanal.ToString() + "i";
            textBox5.Text = gosterilecek;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            x = new karmasiksayi(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            y = new karmasiksayi(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            karmasiksayi sonuc = x * y;
            string gosterilecek = (sonuc.gercel + sonuc.sanal).ToString();
            textBox5.Text = gosterilecek;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    

    }
}
