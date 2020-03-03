using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekursvia_metoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        long fakultet(long a)
        {
            if (a < 1)
            {
                a = 0;
            }
            else
            {
                if (a == 1)
                {
                    a = 1;
                }
                else
                {
                    a = fakultet(a - 1) * a;
                }
            }
            return a;
        }

        long fibonacci(long f)
        {
            if (f == 1)
            {
                f = 1;
            }
            else if (f == 2)
            {
                f = 1;
            }
            else
            {
                f = fibonacci(f - 1) + fibonacci(f - 2);
            }
            return f;
        }

        double harmoni(double h)
        {
            if (h == 1)
            {
                h = 1;
            }
            else
            {
                h = 1 / (h) + (harmoni(h - 1));
            }

            return h;
        }


        double[] resultatUtifrån = { 1.65, 1.60, 1.55, 1.50, 1.45, 1.40 };


        string ingenVändning(double[] resultat, int placering)
        {
            string resultatLista = "";
            if (placering == resultat.Length)
            {
                resultatLista = resultat[resultat.Length-1].ToString();
            }
            else
            {
                resultatLista = resultat[placering] + ingenVändning(resultatUtifrån[], placering - 1);
            }
            return resultatLista;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            textBox1.Text = fakultet(int.Parse(textBox1.Text)).ToString();
            if(textBox2.Text != "")
            textBox2.Text = fibonacci(int.Parse(textBox2.Text)).ToString();
            if(textBox3.Text != "")
            textBox3.Text = harmoni(int.Parse(textBox3.Text)).ToString();
            textBox4.Text = ingenVändning(resultatUtifrån[], 5);
            
        }
    }
}
