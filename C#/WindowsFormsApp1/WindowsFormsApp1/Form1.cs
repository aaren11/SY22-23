using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clear()
        {

            nametextbox.Clear();
            cctextbox.Clear();
            exptextbox.Clear();
            ziptextbox.Clear();
            amountextbox.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double atm = 0;
            double.TryParse(amountextbox.Text,out atm);
            if (atm > 500)
                this.BackColor = Color.Red;
            else
                this.BackColor = SystemColors.Control;
            clear();
            Feetextbox.Text = (atm * .03).ToString();

        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CanecelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
