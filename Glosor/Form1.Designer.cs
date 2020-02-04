namespace Glosor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEnglishInput = new System.Windows.Forms.TextBox();
            this.textBoxSwedishInput = new System.Windows.Forms.TextBox();
            this.buttonAddGlosa = new System.Windows.Forms.Button();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.buttonTestAnswer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTestEnglish = new System.Windows.Forms.TextBox();
            this.textBoxTestSwedish = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.buttonNewGlossary = new System.Windows.Forms.Button();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxTest.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Controls.Add(this.textBoxEnglishInput);
            this.groupBoxInput.Controls.Add(this.textBoxSwedishInput);
            this.groupBoxInput.Controls.Add(this.buttonAddGlosa);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(200, 100);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Lägg till glosor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Engelskt ord:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Svenskt ord:";
            // 
            // textBoxEnglishInput
            // 
            this.textBoxEnglishInput.Location = new System.Drawing.Point(87, 46);
            this.textBoxEnglishInput.Name = "textBoxEnglishInput";
            this.textBoxEnglishInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnglishInput.TabIndex = 2;
            // 
            // textBoxSwedishInput
            // 
            this.textBoxSwedishInput.Location = new System.Drawing.Point(87, 20);
            this.textBoxSwedishInput.Name = "textBoxSwedishInput";
            this.textBoxSwedishInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxSwedishInput.TabIndex = 1;
            // 
            // buttonAddGlosa
            // 
            this.buttonAddGlosa.Location = new System.Drawing.Point(10, 71);
            this.buttonAddGlosa.Name = "buttonAddGlosa";
            this.buttonAddGlosa.Size = new System.Drawing.Size(177, 23);
            this.buttonAddGlosa.TabIndex = 0;
            this.buttonAddGlosa.Text = "Lägg till glosa";
            this.buttonAddGlosa.UseVisualStyleBackColor = true;
            this.buttonAddGlosa.Click += new System.EventHandler(this.ButtonAddGlosa_Click);
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Controls.Add(this.buttonTestAnswer);
            this.groupBoxTest.Controls.Add(this.label4);
            this.groupBoxTest.Controls.Add(this.label3);
            this.groupBoxTest.Controls.Add(this.textBoxTestEnglish);
            this.groupBoxTest.Controls.Add(this.textBoxTestSwedish);
            this.groupBoxTest.Enabled = false;
            this.groupBoxTest.Location = new System.Drawing.Point(12, 131);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTest.TabIndex = 1;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Glostest";
            // 
            // buttonTestAnswer
            // 
            this.buttonTestAnswer.Location = new System.Drawing.Point(10, 71);
            this.buttonTestAnswer.Name = "buttonTestAnswer";
            this.buttonTestAnswer.Size = new System.Drawing.Size(173, 23);
            this.buttonTestAnswer.TabIndex = 4;
            this.buttonTestAnswer.Text = "Svara";
            this.buttonTestAnswer.UseVisualStyleBackColor = true;
            this.buttonTestAnswer.Click += new System.EventHandler(this.ButtonTestAnswer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Engelskt ord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Svenskt ord:";
            // 
            // textBoxTestEnglish
            // 
            this.textBoxTestEnglish.Location = new System.Drawing.Point(83, 46);
            this.textBoxTestEnglish.Name = "textBoxTestEnglish";
            this.textBoxTestEnglish.Size = new System.Drawing.Size(100, 20);
            this.textBoxTestEnglish.TabIndex = 1;
            // 
            // textBoxTestSwedish
            // 
            this.textBoxTestSwedish.Location = new System.Drawing.Point(83, 19);
            this.textBoxTestSwedish.Name = "textBoxTestSwedish";
            this.textBoxTestSwedish.Size = new System.Drawing.Size(100, 20);
            this.textBoxTestSwedish.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelResults);
            this.groupBoxResult.Location = new System.Drawing.Point(218, 12);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(176, 219);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Resultat";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(6, 16);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(0, 13);
            this.labelResults.TabIndex = 0;
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Enabled = false;
            this.buttonStartTest.Location = new System.Drawing.Point(11, 237);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(201, 23);
            this.buttonStartTest.TabIndex = 3;
            this.buttonStartTest.Text = "Starta glostest";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.ButtonStartTest_Click);
            // 
            // buttonNewGlossary
            // 
            this.buttonNewGlossary.Location = new System.Drawing.Point(218, 237);
            this.buttonNewGlossary.Name = "buttonNewGlossary";
            this.buttonNewGlossary.Size = new System.Drawing.Size(176, 23);
            this.buttonNewGlossary.TabIndex = 4;
            this.buttonNewGlossary.Text = "Nya glosor";
            this.buttonNewGlossary.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 269);
            this.Controls.Add(this.buttonNewGlossary);
            this.Controls.Add(this.buttonStartTest);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxTest);
            this.Controls.Add(this.groupBoxInput);
            this.Name = "Form1";
            this.Text = "Glosprogram";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnglishInput;
        private System.Windows.Forms.TextBox textBoxSwedishInput;
        private System.Windows.Forms.Button buttonAddGlosa;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.Button buttonTestAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTestEnglish;
        private System.Windows.Forms.TextBox textBoxTestSwedish;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.Button buttonNewGlossary;
        private System.Windows.Forms.Label labelResults;
    }
}

