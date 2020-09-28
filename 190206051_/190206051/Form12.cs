using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190206051
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        string[] girilmesi_zorunlu_kelimeler = new string[12];  // girilmesı gerekn yerlerıo hafızaya alıp konrol edılecek hep bırlıkte .

        public void Form12_Load(object sender, EventArgs e)
        {

            // el zoru ıle malesef null a esıtlemem gerktı formda , yoksa formda labeller gozukmuyor
            label13.Text = null;
            label14.Text = null;
            label15.Text = null;
            label16.Text = null;
            label20.Text = null; 
            label21.Text = null;
            label45.Text = null;
            label48.Text = null;
            label49.Text = null;
            label50.Text = null;
            label59.Text = null;
            label60.Text = null;



            label13.Text = Form2.form_2_degerler[0];                       // textbox takı degerlerı yazdırma (FROM ==>FORM2) (kısısel bılgı) 
            girilmesi_zorunlu_kelimeler[0] = Form2.form_2_degerler[0];
            label14.Text = Form2.form_2_degerler[1];
            girilmesi_zorunlu_kelimeler[1] = Form2.form_2_degerler[1];
            label15.Text = Form2.form_2_degerler[2];
            girilmesi_zorunlu_kelimeler[2] = Form2.form_2_degerler[2];
            label16.Text = Form2.form_2_degerler[3];
            girilmesi_zorunlu_kelimeler[3] = Form2.form_2_degerler[3];
            label17.Text = Form2.form_2_degerler[4];                       // radıo button dakı deger yazma 
            label18.Text = Form2.form_2_degerler[5];                       // chech box degerlerı yazma
            label19.Text = Form2.form_2_degerler[6];
            label20.Text = Form2.form_2_degerler[7];
            girilmesi_zorunlu_kelimeler[4] = Form2.form_2_degerler[7];
            label21.Text = Form2.form_2_degerler[8];
            girilmesi_zorunlu_kelimeler[5] = Form2.form_2_degerler[8];
            label22.Text = Form2.form_2_degerler[9];
            

            label24.Text = Form3.form_3_degerler[0];                       // form3 ten alınanlar (is tecrubelerı)
            label26.Text = Form3.form_3_degerler[1];
            label25.Text = Form3.form_3_degerler[2];
            label28.Text = Form3.form_3_degerler[3];
            label34.Text = Form3.form_3_degerler[4];
            label35.Text = Form3.form_3_degerler[5];


            label45.Text = Form4.form_4_degerler[0];
            girilmesi_zorunlu_kelimeler[6] = Form4.form_4_degerler[0];// form 4 ten degerler (egıtım)
            label46.Text = Form4.form_4_degerler[1];
            label47.Text = Form4.form_4_degerler[2];
            label48.Text = Form4.form_4_degerler[3];
            girilmesi_zorunlu_kelimeler[7] = Form4.form_4_degerler[3];
            label49.Text = Form4.form_4_degerler[4];
            girilmesi_zorunlu_kelimeler[8] = Form4.form_4_degerler[4];
            label50.Text = Form4.form_4_degerler[5];
            girilmesi_zorunlu_kelimeler[9] = Form4.form_4_degerler[5];
            label51.Text = Form4.form_4_degerler[6];
            label52.Text = Form4.form_4_degerler[7];


            label59.Text = Form5.form_5_degerler[0];                        // form 5 ten degerler  (yabancı dıl)
            girilmesi_zorunlu_kelimeler[10] = Form5.form_5_degerler[0];
            label60.Text = Form5.form_5_degerler[1];
            girilmesi_zorunlu_kelimeler[11] = Form5.form_5_degerler[1];
            label61.Text = Form5.form_5_degerler[2];
            label62.Text = Form5.form_5_degerler[3];
            label63.Text = Form5.form_5_degerler[4];


            textBox1.Text = Form6.form_6_degerler[0];                       // form 6        ()


            textBox2.Text = Form7.form_7_degerler[0];                       // form 7


            label68.Text = Form8.form_8_degerler[0];                        // form 8
            label69.Text = Form8.form_8_degerler[1];
            label70.Text = Form8.form_8_degerler[2];


            textBox3.Text = Form9.form_9_degerler[0];                        // form 9


            label78.Text = Form10.form_10_degerler[0];                       // form 10
            label79.Text = Form10.form_10_degerler[1]; 
            label80.Text = Form10.form_10_degerler[2];
            label81.Text = Form10.form_10_degerler[3];
            label82.Text = Form10.form_10_degerler[4];
            label83.Text = Form10.form_10_degerler[5];

            textBox4.Text = Form11.form_11_degerler[0];                       // form 11


            // gırılmesı zorunlu kısımlar ıcın 
            button2.Enabled = false ;
            int karar = 0;
            foreach (string items in girilmesi_zorunlu_kelimeler)
            {
                if (items != null) // herhangı bı degerın ıcı bpos ıse 'karar' degıskenı degısecek ve bu sayede durumu ogrenıcez

                {
                    karar++; // eger bır label dolu ıse 1 artıcak her label dolu ise button acılacak
                }
            }

            if (karar == girilmesi_zorunlu_kelimeler.Length) button2.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var zamanlayıcı_ac = new Form13();     // gerı sayım ıcın yenı form 
            zamanlayıcı_ac.ShowDialog();
        }
    }
}
