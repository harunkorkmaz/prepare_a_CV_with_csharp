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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        public int rastegele_sayi;

        private void Form13_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Random rastegele = new Random();       
            zaman = rastegele.Next(29,61);         // 30 60 arası sayı sallama

        }

        int zaman;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( zaman <= 60 && zaman >= 30 )
            {
                
                label1.Text = "Kalan Vakit : " + Convert.ToString(zaman);
                zaman--;
                if (zaman == 30)
                {
                    MessageBox.Show("HARUN KORKMAZ", "190206051 ",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);           // MESSAGE BOX ICINE overloadsları
                }
                
            }
            else
            {
                this.Close();
            }
        }
        
    }
}
