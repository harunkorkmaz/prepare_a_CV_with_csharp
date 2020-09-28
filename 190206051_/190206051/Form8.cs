using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190206051
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
        public static string[] form_8_degerler = new string[300];



        private void button2_Click(object sender, EventArgs e)
        {
            // '-' KARAKTER YAZILIRSA UYARI VERECEK ()
            string tum_stringler;
            Boolean karar = true;

            tum_stringler = textBox1.Text + textBox2.Text + textBox3.Text;

            char[] array = tum_stringler.ToCharArray();

            foreach (var item in array)
            {
                if (item == '-')
                {

                    karar = false; // karar verecek degerlerı almak ıcın
                    break;

                }


            }
            // burasıda '-' icin kosul kısmı
            if (karar == true)
            {
                listBox1.Items.Add(textBox1.Text);
                listBox1.Items.Add(textBox2.Text);
                listBox1.Items.Add(textBox3.Text);
                button1.Enabled = true;

            }
            else
            {
                // '-' gırer ıse
                MessageBox.Show("'-'Gibi karakterler girmeyin!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int say = 0;

            foreach (var gonderılecek_stringler in listBox1.Items)
            {
                form_8_degerler[say] = Convert.ToString(gonderılecek_stringler);
                say++;
            }
            this.Hide();     // formu saklayacak
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
      
        }
    }
}
