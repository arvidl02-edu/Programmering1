using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veckodag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int day = int.Parse(textBox1.Text);
            switch (day)
            {
                case 1:
                    label1.Text = "Måndag";
                    break;
                case 2:
                    label1.Text = "Tisdag";
                    break;
                case 3:
                    label1.Text = "Onsdag";
                    break;
                case 4:
                    label1.Text = "Torsdag";
                    break;
                case 5:
                    label1.Text = "Fredag";
                    break;
                case 6:
                    label1.Text = "Lördag";
                    break;
                case 7:
                    label1.Text = "Söndag";
                    break;
                case 1337:
                    label1.Text = "XxX1337ELITE PUSSYDETSROYER69XxX \r\n fucking T-pose\r\n\t asserting the DOMINANCE YEAAAH";
                    break;
            }
        }
    }
}
