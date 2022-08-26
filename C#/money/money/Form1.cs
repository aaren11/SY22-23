using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace money
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

        private void button1_Click(object sender, EventArgs e)
        {
            double usd = 0;
            double.TryParse(textBox1.Text, out usd);
            textBox1.Text = (usd * 136.71).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double usd = 0;
            double.TryParse(textBox2.Text, out usd);
            textBox2.Text = (usd * 1.29).ToString();
                      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double usd = 0;
            double.TryParse(textBox3.Text, out usd);
            textBox3.Text = (usd * 413.25).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double usd = 0;
            double.TryParse(textBox4.Text, out usd);
            textBox4.Text = (usd * 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double usd = 0;
            double.TryParse(textBox5.Text, out usd);
            textBox5.Text = (usd * 24.77).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double usd = 0;
            double.TryParse(textBox6.Text, out usd);
            textBox6.Text = (usd * 79.93).ToString();
        }
    }
}
