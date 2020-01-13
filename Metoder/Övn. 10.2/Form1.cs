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

        void indata (out double radie, out double volym) 
        {
            radie = double.Parse(textBox1.Text);
            volym = double.Parse(textBox2.Text);
        }

        double volymCylinder(double radie, double höjd)
        {
            double volym = radie * radie * Math.PI * höjd;
            return volym;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            MessageBox.Show("Yeeeeaaah boyyy tryck på fittknappen är du imbecill ellör???", "HAHAHAHHAHA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            indata(out radieInput, out volymInput);
            textBox3.Text = volymCylinder(radieInput, volymInput)+"";
        }
    }
}
