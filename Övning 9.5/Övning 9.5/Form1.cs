using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int startvärde = 0;
            int slutvärde = int.Parse(textBox2.Text);
            int steglängd = int.Parse(textBox3.Text);
            textBox4.Text = "";
            for (startvärde = int.Parse(textBox1.Text); startvärde < slutvärde+1; startvärde = startvärde + steglängd)
            {
                textBox4.AppendText(startvärde + "\r\n");
            }
        }
    }
}
