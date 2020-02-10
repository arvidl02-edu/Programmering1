using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hjärtan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

            }
            string firstName = textBox1.Text;
            string secondName = textBox2.Text;
            string name1;
            string name2;
            string output = "";
            for (int i = 0; i < 12; i++)
            {
                switch (i)
                {
                    case 0:
                        output = "\t\t\t\t\t<3" + output;
                        break;
                    case 1:
                        output = "\t\t\t\t<3\t\t<3\r\n\r\n" + output;
                        break;

                    case 2:
                        output = "\t\t\t<3\t\t\t\t<3\r\n\r\n" + output;
                        break;

                    case 3:
                        output = "\t\t<3\t\t\t\t\t\t<3\r\n\r\n" + output;
                        break;

                    case 4:
                        if (firstName.Length >= 8)
                        {
                            name1 = firstName;
                        }
                        else
                        {
                            name1 = firstName + "\t";
                        }
                        if (secondName.Length >= 8)
                        {
                            name2 = secondName;
                        }
                        else
                        {
                            name2 = secondName + "\t";
                        }
                        output = name1 + "<3\t\t\t\t\t\t\t\t<3  " + name2 + "\r\n\r\n" + output;
                        break;
                    case 5:
                        output = "\t\t<3\t\t\t<3\t\t\t<3\r\n\r\n" + output;
                        break;
                    case 6:
                        output = "\t\t\t<3\t<3\t\t<3\t<3\r\n\r\n" + output;
                        break;

                    default:
                        break;
                }
            }
            richTextBox1.Text = output;
        }
    }
}
