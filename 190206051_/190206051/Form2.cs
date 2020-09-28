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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

          
        }
        
        public static string[] form_2_degerler = new string[1000];
         
        public void button1_Click(object sender, EventArgs e)
        {


            // DOLDURULMASI GEREKN YERLER ICIN KOSUL

            if (textBox1.Text== "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "")

            {
                MessageBox.Show("'*' İsaretlileri lutfen doldurun!(ZORUNLUDUR)");
            }

            else

            {

                
                // '-' KARAKTER YAZILIRSA UYARI VERECEK ()
                string tum_stringler;
                Boolean karar = true;

                tum_stringler = textBox1.Text + textBox2.Text+ textBox3.Text+ textBox4.Text+ textBox6.Text+ textBox7.Text;

                char[] array = tum_stringler.ToCharArray();

                foreach (var item in array)
                {
                    if (item == '-')

                    {
                       
                        karar = false;   // karar verecek degerlerı almak ıcın     
                        break;

                    }
                    
                    
                }
                // burasıda '-' icin kosul kısmı

                if (karar == true)
                {
                    listBox1.Items.Add(textBox1.Text);   
                    listBox1.Items.Add(textBox2.Text);   // BILGILER LİSTBOX TAN DIZIYE ORDAN DA FORM 12 YE SON YERINE ULASACAK
                    listBox1.Items.Add(textBox3.Text);
                    listBox1.Items.Add(textBox4.Text);
                   
                    // radıo buıttın kontrol

                    if (radioButton1.Checked == false && radioButton2.Checked == false)
                    {
                        listBox1.Items.Add("");
                    }
                    else if (radioButton1.Checked == true)
                    {
                        listBox1.Items.Add("Evli");
                    }
                    else
                    {
                        listBox1.Items.Add("Bekar");
                    }

                    // checkbox kontrol

                    if (checkBox1.Checked == false && checkBox2.Checked == false)
                    {
                        listBox1.Items.Add("");
                    }
                    else if (checkBox1.Checked == true)
                    {
                        listBox1.Items.Add("Yaptı");
                    }
                    else
                    {
                        listBox1.Items.Add("Yapmadı");
                    }

                    listBox1.Items.Add(textBox5.Text);   // listeye eklemeye devam 
                    listBox1.Items.Add(textBox6.Text);
                    listBox1.Items.Add(textBox7.Text);
                    listBox1.Items.Add(textBox8.Text);

                    button2.Enabled = true;              // eger buraya kadar hersey dogru olsa bıle assagıda bır tane daha kosul cumlesı var

                    char[] tc_no_uzunluk = Convert.ToString(textBox2.Text).ToCharArray();  // tc numarası uzunlugu kontrol

                    if (tc_no_uzunluk.Length != 11)
                    {
                        MessageBox.Show("TC numaranızı doğru giriniz");
                        button2.Enabled = false;         //  tc nbumarası sıkıntılı ıse button aktıf olmayacak :(
                    }

                }

                else
                {  
                    // '-' gırer ıse
                    MessageBox.Show("'-'Gibi karakterler girmeyin!");                            
                }
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            int say = 0;

            foreach (var gonderılecek_stringler in listBox1.Items)
            {
                form_2_degerler[say] =Convert.ToString(gonderılecek_stringler);
                say++;
            }
           this.Hide();     // formu saklayacak
        }

           

    }
}

