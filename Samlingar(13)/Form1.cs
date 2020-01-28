using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samlingar_13_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool palindromTrue;
        private void Button1_Click(object sender, EventArgs e)
        {
            Stack<char> bokstäver = new Stack<char>();
            string palindrom = textBox2.Text;

            for (int i = 0; i < palindrom.Length; i++)
            {
                bokstäver.Push(palindrom[i]);
            }


            palindromTrue = true;

            for (int j = 0; j < palindrom.Length; j++)
            {
                if (bokstäver.Pop() != palindrom[j])
                {
                    palindromTrue = false;
                }
            }

            if (palindromTrue)
            {
                textBox1.Text = palindrom + " är ett palindrom";
            }
            else
            {
                textBox1.Text = palindrom + " är inte ett palindrom";
            }
        }

        
    }
}
