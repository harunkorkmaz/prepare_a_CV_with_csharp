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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        public static string[] form_10_degerler = new string[600];  //

        private void button2_Click(object sender, EventArgs e)
        {
            string tum_stringler;
            Boolean karar = true;

            tum_stringler = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text;

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
                listBox1.Items.Add(textBox1.Text);      //
                listBox1.Items.Add(textBox2.Text);
                listBox1.Items.Add(textBox3.Text);
                listBox1.Items.Add(textBox4.Text);
                listBox1.Items.Add(textBox5.Text);
                listBox1.Items.Add(textBox6.Text);
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
                form_10_degerler[say] = Convert.ToString(gonderılecek_stringler);
                say++;
            }
            this.Hide();     // formu saklayacak
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            form_10_degerler[0] = textBox1.Text;
            form_10_degerler[1] = textBox2.Text;
            form_10_degerler[2] = textBox3.Text;
            form_10_degerler[3] = textBox4.Text;
            form_10_degerler[4] = textBox5.Text;
            form_10_degerler[5] = textBox6.Text;
        }
    }
}
