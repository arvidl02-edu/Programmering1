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
        int datornsTal = 0;
        int antalGissningar = 0;
        public Form1()
        {
            InitializeComponent();
            listBoxStörstaTal.Items.Add(10);
            listBoxStörstaTal.Items.Add(20);
            listBoxStörstaTal.Items.Add(100);
            listBoxStörstaTal.SelectedItem = listBoxStörstaTal.Items[0];
            
            

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            string störstaTal = listBoxStörstaTal.SelectedItem.ToString();
            int störst = int.Parse(störstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, störst + 1);

            buttonStart.Enabled = false;
            groupBoxSpeldata.Enabled = false;
            groupBoxSpel.Enabled = true;
            buttonSpelaIgen.Enabled = false;
            labelDatornsTalSiffra.Text = "??";
            antalGissningar = 0;
        }

        private void ButtonGissa_Click(object sender, EventArgs e)
        {
            antalGissningar++;
            string gissa = textBoxGissa.Text;
            int gissatTal = int.Parse(gissa);

            if (gissatTal == datornsTal)
            {
                labelResultat.Text = "Korrekt efter " + antalGissningar + " försök.";
                groupBoxSpel.Enabled = false;
                buttonSpelaIgen.Enabled = true;

                labelDatornsTalSiffra.Text = datornsTal.ToString();
                textBoxMinaResultat.AppendText(antalGissningar + " försök \r\n");
            }
            else if (gissatTal < datornsTal)
            {
                labelResultat.Text = "För lågt";
            }
            else
            {
                labelResultat.Text = "För högt";
            }
        }

        private void ButtonSpelaIgen_Click(object sender, EventArgs e)
        {
            groupBoxSpeldata.Enabled = true;
            buttonStart.Enabled = true;
            groupBoxSpel.Enabled = false;
            buttonSpelaIgen.Enabled = false;
            antalGissningar = 0;
            textBoxGissa.Text = "";
            labelResultat.Text = "";
            labelDatornsTalSiffra.Text = "??";


        }
    }
}
