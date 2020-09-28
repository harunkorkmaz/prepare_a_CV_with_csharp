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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        public static string[] form_3_degerler = new string[600]; // 


        private void button1_Click(object sender, EventArgs e)
        {
            Boolean karar = true;
            string kontrol_karakterler = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text;
            char[] array = kontrol_karakterler.ToCharArray();

            foreach (var item in array)
            {
                if (item == '-')
                {
                    karar = false; // karar verecek degerlerı almak ıcın
                    break;
                }
            }

            if (karar==true)
            {
                // list box ıcın sadece
                listBox1.Items.Add(textBox1.Text);
                listBox1.Items.Add(textBox2.Text);
                listBox1.Items.Add(textBox3.Text);
                listBox1.Items.Add(textBox4.Text);
                listBox1.Items.Add(textBox5.Text);
                listBox1.Items.Add(textBox6.Text);
                // listbox ıcın kayıt
                button2.Enabled = true;
            }
            else
            {
                // '-' gırer ıse
                MessageBox.Show("'-'Gibi karakterler girmeyin!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int say = 0;

            foreach (var gonderılecek_stringler in listBox1.Items)
            {
                form_3_degerler[say] = Convert.ToString(gonderılecek_stringler);
                say++;
            }


            this.Hide();
        }

        
    }
}
