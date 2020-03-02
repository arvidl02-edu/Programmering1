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
            if (a == 1)
            {
                a = 1;
            }
            else
            {
                a = fakultet(a - 1)*a;
            }
            return a;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = fakultet(int.Parse(textBox1.Text)).ToString();
        }
    }
}
