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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            
        }


        public static string[] form_4_degerler = new string[800];     // statıc ,baska sınıf ıcın

       

        private void button2_Click(object sender, EventArgs e)
        {
              // kontrol ==> ilk 

            if (textBox1.Text== "" ||textBox4.Text=="" || textBox5.Text == "" || textBox6.Text == "" )
            {
                MessageBox.Show("'*' İsaretlileri lutfen doldurun!");
            }
            else
            {
                // '-' KARAKTER YAZILIRSA UYARI VERECEK ()
                string tum_stringler;
                Boolean karar = true;

                tum_stringler = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text + textBox7.Text+ textBox8.Text;

                char[] array = tum_stringler.ToCharArray();

                foreach (var item in array)
                {
                    if (item == '-')
                    {
                        karar = false; // karar verecek degerlerı almak ıcın
                        break;         // tek sefer yeterlı kara ıcın
                    }
                }

                // 2.kontrol  burasıda '-' icin kosul kısmı

                if (karar == true)
                {
                    listBox1.Items.Add(textBox1.Text);         // form 4 ten alınacak degerler
                    listBox1.Items.Add(textBox2.Text);
                    listBox1.Items.Add(textBox3.Text);
                    listBox1.Items.Add(textBox4.Text);
                    listBox1.Items.Add(textBox5.Text);
                    listBox1.Items.Add(textBox6.Text);
                    listBox1.Items.Add(textBox7.Text);
                    listBox1.Items.Add(textBox8.Text);
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

            foreach (var gonderılecek_stringler in listBox1.Items)          // kayıt ıslemı 
            {
                form_4_degerler[say] = Convert.ToString(gonderılecek_stringler);  // diziye alınıor degerler
                say++;
            }
            this.Hide();     // formu saklayacak

        }

        
    }
}
