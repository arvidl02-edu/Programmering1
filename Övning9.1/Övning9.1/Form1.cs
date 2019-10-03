using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int räknare = -1;
        int slut = 0;
        double nämnare = 1.2;
        private void Button1_Click(object sender, EventArgs e)
        {
            slut = int.Parse(textBox2.Text);
            while (räknare < slut)
            {
                räknare++;
                textBox1.AppendText(räknare + "\t");
                //textBox1.Text = textBox1.Text + Math.Sqrt(räknare)+ " ";
            }
        }
    }
}
