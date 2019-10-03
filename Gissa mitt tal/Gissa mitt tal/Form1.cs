using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gissa_mitt_tal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxStörstaTal.Items.Add(10);
            listBoxStörstaTal.Items.Add(20);
            listBoxStörstaTal.SelectedItem = listBoxStörstaTal.Items[0];
        }
    }
}
