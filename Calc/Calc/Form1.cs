using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int oprtr = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            oprtr = 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            oprtr = 2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            oprtr = 3;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            oprtr = 4;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);
            if (oprtr == 1)
            {
                int sum = tal1 + tal2 ;
                string text = sum.ToString();
                label3.Text = text;
            }
            else if (oprtr == 2)
            {
                int sum = tal1 - tal2;
                string text = sum.ToString();
                label3.Text = text;
            }
            else if (oprtr == 3)
            {
                int sum = tal1 * tal2;
                string text = sum.ToString();
                label3.Text = text;
            }
            else if (oprtr == 4)
            {
                int sum = tal1 / tal2;
                string text = sum.ToString();
                label3.Text = text; //klart

            }
        }
    }
}
