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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Siyah";
            comboBox2.Text = "Siyah";
            comboBox3.Text = "Yok";
            comboBox4.Text = "Siyah";
            comboBox5.Text = "Yok";
            comboBox6.Text = "Yok";

            comboBox1.SelectedIndexChanged += new EventHandler(comboBox4_SelectedIndexChanged);
            comboBox2.SelectedIndexChanged += new EventHandler(comboBox4_SelectedIndexChanged);
            comboBox3.SelectedIndexChanged += new EventHandler(comboBox4_SelectedIndexChanged);
            comboBox5.SelectedIndexChanged += new EventHandler(comboBox4_SelectedIndexChanged);
            comboBox6.SelectedIndexChanged += new EventHandler(comboBox4_SelectedIndexChanged);
            radioButton1.CheckedChanged += new EventHandler(comboBox4_SelectedIndexChanged);
            radioButton2.CheckedChanged += new EventHandler(comboBox4_SelectedIndexChanged);
            radioButton3.CheckedChanged += new EventHandler(comboBox4_SelectedIndexChanged);
            radioButton1.Checked = true;
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string carpan_1 = "", carpan_2 = "", carpan_3 = "0", sck="Yok", tol="Yok";
            double toplam = 0, direnc_degeri = 0, carpan = 0;

            if (comboBox1.Text == "Siyah") {carpan_1 = "0"; label1.ForeColor=Color.Black;}
            else if (comboBox1.Text == "Kahverengi") { carpan_1 = "1"; label1.ForeColor = Color.Brown; }
            else if (comboBox1.Text == "Kırmızı") { carpan_1 = "2"; label1.ForeColor = Color.Red; }
            else if (comboBox1.Text == "Turuncu") {carpan_1 = "3"; label1.ForeColor = Color.Orange;}
            else if (comboBox1.Text == "Sarı") {carpan_1 = "4"; label1.ForeColor = Color.Yellow;}
            else if (comboBox1.Text == "Yeşil") {carpan_1 = "5"; label1.ForeColor = Color.Green;}
            else if (comboBox1.Text == "Mavi") {carpan_1 = "6"; label1.ForeColor = Color.Blue;}
            else if (comboBox1.Text == "Mor") {carpan_1 = "7"; label1.ForeColor = Color.Purple;}
            else if (comboBox1.Text == "Gri") {carpan_1 = "8"; label1.ForeColor = Color.Gray;}
            else if (comboBox1.Text == "Beyaz") { carpan_1 = "9"; label1.ForeColor = Color.White; }

            if (comboBox2.Text == "Siyah") { carpan_2 = "0"; label2.ForeColor = Color.Black; }
            else if (comboBox2.Text == "Kahverengi") {carpan_2 = "1"; label2.ForeColor = Color.Brown; }
            else if (comboBox2.Text == "Kırmızı") {carpan_2 = "2"; label2.ForeColor = Color.Red; }
            else if (comboBox2.Text == "Turuncu") {carpan_2 = "3"; label2.ForeColor = Color.Orange;}
            else if (comboBox2.Text == "Sarı") {carpan_2 = "4"; label2.ForeColor = Color.Yellow;}
            else if (comboBox2.Text == "Yeşil") {carpan_2 = "5"; label2.ForeColor = Color.Green;}
            else if (comboBox2.Text == "Mavi") {carpan_2 = "6"; label2.ForeColor = Color.Blue;}
            else if (comboBox2.Text == "Mor") {carpan_2 = "7"; label2.ForeColor = Color.Purple;}
            else if (comboBox2.Text == "Gri") {carpan_2 = "8"; label2.ForeColor = Color.Gray;}
            else if (comboBox2.Text == "Beyaz") {carpan_2 = "9"; label2.ForeColor = Color.White; }

            if (comboBox3.Text == "Siyah") { carpan_3 = "0"; label3.ForeColor = Color.Black; }
            else if (comboBox3.Text == "Kahverengi") {carpan_3 = "1"; label3.ForeColor = Color.Brown; }
            else if (comboBox3.Text == "Kırmızı") {carpan_3 = "2"; label3.ForeColor = Color.Red; }
            else if (comboBox3.Text == "Turuncu") {carpan_3 = "3"; label3.ForeColor = Color.Orange;}
            else if (comboBox3.Text == "Sarı") {carpan_3 = "4"; label3.ForeColor = Color.Yellow;}
            else if (comboBox3.Text == "Yeşil") {carpan_3 = "5"; label3.ForeColor = Color.Green;}
            else if (comboBox3.Text == "Mavi") {carpan_3 = "6"; label3.ForeColor = Color.Blue;}
            else if (comboBox3.Text == "Mor") {carpan_3 = "7"; label3.ForeColor = Color.Purple;}
            else if (comboBox3.Text == "Gri") {carpan_3 = "8"; label3.ForeColor = Color.Gray;}
            else if (comboBox3.Text == "Beyaz") {carpan_3 = "9"; label3.ForeColor = Color.White; }
            
            if (comboBox4.Text == "Siyah") carpan = (int)Math.Pow(10, 0);
            else if (comboBox4.Text == "Kahverengi") carpan = (int)Math.Pow(10, 1);
            else if (comboBox4.Text == "Kırmızı") carpan = (int)Math.Pow(10, 2);
            else if (comboBox4.Text == "Turuncu") carpan = (int)Math.Pow(10, 3);
            else if (comboBox4.Text == "Sarı") carpan = (int)Math.Pow(10, 4);
            else if (comboBox4.Text == "Yeşil") carpan = (int)Math.Pow(10, 5);
            else if (comboBox4.Text == "Mavi") carpan = (int)Math.Pow(10, 6);
            else if (comboBox4.Text == "Mor") carpan = (int)Math.Pow(10, 7);
            else if (comboBox4.Text == "Altın") carpan = (int)Math.Pow(10, 8);
            else if (comboBox4.Text == "Gümüş") carpan = (int)Math.Pow(10, 9);
           
            if(comboBox3.Text=="Yok")
                toplam = int.Parse((carpan_1 + carpan_2));
            else 
                toplam = int.Parse((carpan_1 + carpan_2+ carpan_3));

            direnc_degeri = toplam * carpan;


            if (comboBox5.Text == "Yok") tol = "Yok";  
            else if (comboBox5.Text == "Kahverengi") tol = "%1";  
            else if (comboBox5.Text == "Kırmızı") tol = "%2"; 
            else if (comboBox5.Text == "Yeşil") tol = "%0.5"; 
            else if (comboBox5.Text == "Mavi") tol = "%0.25"; 
            else if (comboBox5.Text == "Mor") tol = "%0.10";  
            else if (comboBox5.Text == "Gri") tol = "%0.05";  
            else if (comboBox5.Text == "Altın") tol = "%5";  
            else if (comboBox5.Text == "Gümüş") tol = "%10";  

            if (comboBox6.Text == "Yok") sck = "Yok";  
            else if (comboBox6.Text == "Kahverengi") sck = "100 ppm"; 
            else if (comboBox6.Text == "Kırmızı") sck = "50 ppm"; 
            else if (comboBox6.Text == "Turuncu") sck = "15 ppm"; 
            else if (comboBox6.Text == "Sarı") sck = "25 ppm";


            if (radioButton1.Checked == true)
                textBox1.Text = direnc_degeri.ToString() + " Ω";
            else if (radioButton2.Checked == true)
            {
                direnc_degeri = direnc_degeri / 1000.0;
                textBox1.Text = direnc_degeri.ToString() + " kΩ";
            }
            else
            {
                direnc_degeri /= 100000.0;
                textBox1.Text = direnc_degeri.ToString() + " MΩ";
            }
            
            textBox1.Text +=  "," + tol + "," + sck;
           
        }

    }
}
