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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            
        }


        public static string[] form_11_degerler = new string[1];

        private void button1_Click(object sender, EventArgs e)
        {
            form_11_degerler[0] = textBox1.Text;
            this.Close();
        }



    }
}
