using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0716
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += int.Parse(textBox1.Text);
            label1.Top += int.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = ((0).ToString());
            textBox2.Text = ((-1).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = ((-1).ToString());
            textBox2.Text = ((0).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = ((0).ToString());
            textBox2.Text = ((1).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = ((1).ToString());
            textBox2.Text = ((0).ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((0).ToString());
            textBox2.Text = ((0).ToString());
        }
    }
}
