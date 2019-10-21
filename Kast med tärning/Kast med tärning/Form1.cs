using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kast_med_tärning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random slump = new Random();
            int prickar = slump.Next(1, int.Parse(textBox1.Text)+1);
            label1.Text = prickar.ToString();
            if (prickar == int.Parse(textBox1.Text)){
                MessageBox.Show("Grattis, du har vunnit en chans att vinna 13370000 kr\r\nbara skriv in dina kreditkortsuppgifter", "Gratulerar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            } 
        }
    }
}
