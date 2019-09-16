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
            switch (oprtr)
            {
                case 0:
                    label3.Text = "Var god välj operation";
                    break;

                case 1:
                    int sum = tal1 + tal2;
                    string text = sum.ToString();
                    label3.Text = text;
                    break;

                case 2:
                    sum = tal1 - tal2;
                    text = sum.ToString();
                    label3.Text = text;
                    break;

                case 3:
                    sum = tal1 * tal2;
                    text = sum.ToString();
                    label3.Text = text;
                    break;

                case 4:
                    sum = tal1 / tal2;
                    text = sum.ToString();
                    label3.Text = text;
                    break;

                default:
                    break;

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
