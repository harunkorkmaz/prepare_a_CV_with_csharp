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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        
        }

        public static string[] form_5_degerler = new string[500]; // nesneler ıcın

        private void button2_Click(object sender, EventArgs e)
        {
            
            // textboxlar bosmu kontrol

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("'*' İsaretlileri lutfen doldurun!");
            }

            else // dolu ıse assagıda bır kontrol daha var
            {
                // '-' KARAKTER YAZILIRSA UYARI VERECEK ()
                string tum_stringler;
                Boolean karar = true;

                tum_stringler = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text;

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
                    listBox1.Items.Add(textBox1.Text);        // form 5 ten degerler list box a
                    listBox1.Items.Add(textBox2.Text);
                    listBox1.Items.Add(textBox3.Text);
                    listBox1.Items.Add(textBox4.Text);
                    listBox1.Items.Add(textBox5.Text);
                    button1.Enabled = true;
                }
                else
                {
                    // '-' gırer ıse
                    MessageBox.Show("'-'Gibi karakterler girmeyin!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say = 0;

            foreach (var gonderılecek_stringler in listBox1.Items)
            {
                form_5_degerler[say] = Convert.ToString(gonderılecek_stringler);
                say++;
            }
            this.Hide();     // formu saklayacak
        }

        
    }
}
