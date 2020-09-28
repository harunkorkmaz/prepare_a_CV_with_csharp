using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190206051   // student id
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var baslangıc_forum = new ÖDEV_HAKKINDA_BİLGİLER();
          //baslangıc_forum.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m_1 = new Form2();
            m_1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m_1 = new Form3();
            m_1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var m_1 = new Form4();
            m_1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var m_1 = new Form5();
            m_1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var m_1 = new Form6();
            m_1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var m_1 = new Form7();
            m_1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var m_1 = new Form8();
            m_1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var m_1 = new Form9();
            m_1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var m_1 = new Form10();
            m_1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var m_1 = new Form11();
            m_1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var m_1 = new Form12();
            m_1.ShowDialog();
        }

        
    }
}
