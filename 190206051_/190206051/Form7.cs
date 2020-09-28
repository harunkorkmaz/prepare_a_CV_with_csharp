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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public static string[] form_7_degerler = new string[1];

        private void button1_Click(object sender, EventArgs e)
        {
            form_7_degerler[0] = textBox1.Text;
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           
        }
    }
}
