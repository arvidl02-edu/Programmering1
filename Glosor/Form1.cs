using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glosor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<string> swedishWords = new Queue<string>();
        Queue<string> englishWords = new Queue<string>();

        int rightAnswers = 0;
        int totalAnswers = 0;
        List<string> wrongAnswers = new List<string>();
        string wrongAnswersInString = "";

        private void ButtonAddGlosa_Click(object sender, EventArgs e)
        {
            if(textBoxSwedishInput.Text != "" && textBoxEnglishInput.Text != "")
            {
                swedishWords.Enqueue(textBoxSwedishInput.Text);
                englishWords.Enqueue(textBoxEnglishInput.Text);
                if (swedishWords.Count > 0)
                {
                    buttonStartTest.Enabled = true;
                }
                totalAnswers++;
                textBoxSwedishInput.Text = "";
                textBoxEnglishInput.Text = "";
            }
        }

        private void ButtonStartTest_Click(object sender, EventArgs e)
        {
            groupBoxInput.Enabled = false;
            groupBoxTest.Enabled = true;
            buttonStartTest.Enabled = false;
            textBoxTestSwedish.Text = swedishWords.Dequeue();
        }

        private void ButtonTestAnswer_Click(object sender, EventArgs e)
        {
            if (textBoxTestEnglish.Text == englishWords.Peek())
            {
                rightAnswers++;
                englishWords.Dequeue();
            }
            else
            {
                wrongAnswers.Add(englishWords.Dequeue());
            }

            textBoxTestEnglish.Text = "";

            if(swedishWords.Count > 0)
            {
                textBoxTestSwedish.Text = swedishWords.Dequeue();  
            }
            else
            {
                for (int i = 0; i < wrongAnswers.Count; i++)
                {
                    wrongAnswersInString += wrongAnswers.ElementAt(i) + "\r\n";
                }
                labelResults.Text = rightAnswers + " av " + totalAnswers + " korrekt svarade glosor." + "\r\nFelaktiga svar: \r\n" + wrongAnswersInString;
            }
        }
    }
}
