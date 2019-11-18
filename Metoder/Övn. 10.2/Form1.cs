using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övn._10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double radieInput = 0;
        double volymInput = 0;

        double volymCylinder(double radie, double höjd)
        {
            double volym = radie * radie * Math.PI * höjd;
            return volym;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            MessageBox.Show("Yeeeeaaah boyyy", "HAHAHAHHAHA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            radieInput = double.Parse(textBox1.Text);
            volymInput = double.Parse(textBox2.Text);
            textBox3.Text = volymCylinder(radieInput, volymInput)+"";
        }
    }
}
