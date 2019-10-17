using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] namn = { textBox1.Text, textBox2.Text, textBox3.Text };
            textBox1.Text = namn[1]; textBox2.Text = namn[2]; textBox3.Text = namn[0];

        }
    }
}
