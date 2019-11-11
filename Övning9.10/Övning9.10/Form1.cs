using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning9._10
{
    public partial class Form1 : Form
    {
        Random generator = new Random();
        int[] rad1 = new int[6];
        int[] rad2 = new int[6];
        int[] rad3 = new int[6];

        public Form1()
        {
            InitializeComponent();
            listBoxMenu.Items.Add("Rad 1");
            listBoxMenu.Items.Add("Rad 2");
            listBoxMenu.Items.Add("Rad 3");
        }

       

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 6; j++)
                {
                rad1[j] = generator.Next(1, 21);
                rad2[j] = generator.Next(1, 21);
                rad3[j] = generator.Next(1, 21);
                }
            for (int i = 0; i < 6; i++)
            {
                textBox1.AppendText(rad1[i] + "\r\n\r\n");
                textBox2.AppendText(rad2[i] + "\r\n\r\n");
                textBox3.AppendText(rad3[i] + "\r\n\r\n");
            }
            
        }

        private void ButtonChoose_Click(object sender, EventArgs e)
        {
            switch (listBoxMenu.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < 6; i++)
                    {
                        textBox4.AppendText(rad1[i] + "\r\n\r\n");
                    }
                    break;

                case 1:
                    for (int i = 0; i < 6; i++)
                    {
                        textBox4.AppendText(rad1[i] + "\r\n\r\n");
                    }
                    break;

                case 2:
                    for (int i = 0; i < 6; i++)
                    {
                        textBox4.AppendText(rad1[i] + "\r\n\r\n");
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
