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
        double tal1 = 0;
        double tal2 = 0;
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
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label3.Text = "Skriv in tal";
            }
            else
            {
                tal1 = double.Parse(textBox1.Text);
                tal2 = double.Parse(textBox2.Text);
            }

            switch (oprtr)
            {
                case 0:
                    label3.Text = "Var god välj operation";
                    break;

                case 1:
                    double sum = tal1 + tal2;
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
                    MessageBox.Show("Fel","Fel",MessageBoxButtons.OK , MessageBoxIcon.Warning);
                    break;

            }
            
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        { label3.Text = "____"; }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        { label3.Text = "____"; }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
