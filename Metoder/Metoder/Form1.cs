using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double area(double radie)
        {
            double area = radie * radie * Math.PI;
            return area;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ra = double.Parse(textBox1.Text);
            double ar = area(ra);
            textBox2.Text = "" + ar;


        }
    }
}
