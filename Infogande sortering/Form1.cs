using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infogande_sortering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] pool = new int[5];

        private void Button1_Click(object sender, EventArgs e)
        {
            taInData();
            sortering();
            utmatning();
        }

        void taInData()
        {
            pool[0] = int.Parse(textBox1.Text);
            pool[1] = int.Parse(textBox2.Text);
            pool[2] = int.Parse(textBox3.Text);
            pool[3] = int.Parse(textBox4.Text);
            pool[4] = int.Parse(textBox5.Text);
        }

        private void sortering()
        {
            int temp;
            int i;
            for (int n = 1; n < 5; n++)
            {
                temp = pool[n];
                i = (n - 1);

                while (i >= 0 && pool[i] > temp)
                {
                    pool[i + 1] = pool[i];
                    i--;
                }
                pool[i + 1] = temp;
            }
        }


        void utmatning()
        {

            textBox1.Text = pool[0].ToString();
            textBox2.Text = pool[1].ToString();
            textBox3.Text = pool[2].ToString();
            textBox4.Text = pool[3].ToString();
            textBox5.Text = pool[4].ToString();

        }
    }
}
