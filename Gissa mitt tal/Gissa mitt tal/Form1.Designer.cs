namespace Gissa_mitt_tal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxSpeldata = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxStörstaTal = new System.Windows.Forms.ListBox();
            this.groupBoxSpel = new System.Windows.Forms.GroupBox();
            this.labelMinaResultat = new System.Windows.Forms.Label();
            this.textBoxMinaResultat = new System.Windows.Forms.TextBox();
            this.labelResultat = new System.Windows.Forms.Label();
            this.buttonGissa = new System.Windows.Forms.Button();
            this.textBoxGissa = new System.Windows.Forms.TextBox();
            this.labelDatornsTalSiffra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDatornsTalText = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSpelaIgen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxSpeldata.SuspendLayout();
            this.groupBoxSpel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxSpeldata
            // 
            this.groupBoxSpeldata.Controls.Add(this.label1);
            this.groupBoxSpeldata.Controls.Add(this.listBoxStörstaTal);
            this.groupBoxSpeldata.Location = new System.Drawing.Point(12, 65);
            this.groupBoxSpeldata.Name = "groupBoxSpeldata";
            this.groupBoxSpeldata.Size = new System.Drawing.Size(210, 70);
            this.groupBoxSpeldata.TabIndex = 1;
            this.groupBoxSpeldata.TabStop = false;
            this.groupBoxSpeldata.Text = "Speldata";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Största tal:";
            // 
            // listBoxStörstaTal
            // 
            this.listBoxStörstaTal.FormattingEnabled = true;
            this.listBoxStörstaTal.Location = new System.Drawing.Point(80, 20);
            this.listBoxStörstaTal.Name = "listBoxStörstaTal";
            this.listBoxStörstaTal.Size = new System.Drawing.Size(90, 30);
            this.listBoxStörstaTal.TabIndex = 0;
            // 
            // groupBoxSpel
            // 
            this.groupBoxSpel.Controls.Add(this.labelMinaResultat);
            this.groupBoxSpel.Controls.Add(this.textBoxMinaResultat);
            this.groupBoxSpel.Controls.Add(this.labelResultat);
            this.groupBoxSpel.Controls.Add(this.buttonGissa);
            this.groupBoxSpel.Controls.Add(this.textBoxGissa);
            this.groupBoxSpel.Controls.Add(this.labelDatornsTalSiffra);
            this.groupBoxSpel.Controls.Add(this.label3);
            this.groupBoxSpel.Controls.Add(this.labelDatornsTalText);
            this.groupBoxSpel.Enabled = false;
            this.groupBoxSpel.Location = new System.Drawing.Point(12, 140);
            this.groupBoxSpel.Name = "groupBoxSpel";
            this.groupBoxSpel.Size = new System.Drawing.Size(340, 110);
            this.groupBoxSpel.TabIndex = 1;
            this.groupBoxSpel.TabStop = false;
            this.groupBoxSpel.Text = "Spel";
            // 
            // labelMinaResultat
            // 
            this.labelMinaResultat.AutoSize = true;
            this.labelMinaResultat.Location = new System.Drawing.Point(216, 16);
            this.labelMinaResultat.Name = "labelMinaResultat";
            this.labelMinaResultat.Size = new System.Drawing.Size(67, 13);
            this.labelMinaResultat.TabIndex = 7;
            this.labelMinaResultat.Text = "Mina resultat";
            // 
            // textBoxMinaResultat
            // 
            this.textBoxMinaResultat.Location = new System.Drawing.Point(219, 43);
            this.textBoxMinaResultat.Multiline = true;
            this.textBoxMinaResultat.Name = "textBoxMinaResultat";
            this.textBoxMinaResultat.Size = new System.Drawing.Size(100, 50);
            this.textBoxMinaResultat.TabIndex = 6;
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Location = new System.Drawing.Point(6, 80);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(10, 13);
            this.labelResultat.TabIndex = 5;
            this.labelResultat.Text = " ";
            // 
            // buttonGissa
            // 
            this.buttonGissa.Location = new System.Drawing.Point(110, 41);
            this.buttonGissa.Name = "buttonGissa";
            this.buttonGissa.Size = new System.Drawing.Size(75, 23);
            this.buttonGissa.TabIndex = 4;
            this.buttonGissa.Text = "Gissa";
            this.buttonGissa.UseVisualStyleBackColor = true;
            this.buttonGissa.Click += new System.EventHandler(this.ButtonGissa_Click);
            // 
            // textBoxGissa
            // 
            this.textBoxGissa.Location = new System.Drawing.Point(74, 43);
            this.textBoxGissa.Name = "textBoxGissa";
            this.textBoxGissa.Size = new System.Drawing.Size(30, 20);
            this.textBoxGissa.TabIndex = 3;
            // 
            // labelDatornsTalSiffra
            // 
            this.labelDatornsTalSiffra.AutoSize = true;
            this.labelDatornsTalSiffra.Location = new System.Drawing.Point(47, 16);
            this.labelDatornsTalSiffra.Name = "labelDatornsTalSiffra";
            this.labelDatornsTalSiffra.Size = new System.Drawing.Size(0, 13);
            this.labelDatornsTalSiffra.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gissa ett tal";
            // 
            // labelDatornsTalText
            // 
            this.labelDatornsTalText.AutoSize = true;
            this.labelDatornsTalText.Location = new System.Drawing.Point(6, 16);
            this.labelDatornsTalText.Name = "labelDatornsTalText";
            this.labelDatornsTalText.Size = new System.Drawing.Size(61, 13);
            this.labelDatornsTalText.TabIndex = 0;
            this.labelDatornsTalText.Text = "Datorns tal:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(256, 74);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonSpelaIgen
            // 
            this.buttonSpelaIgen.Location = new System.Drawing.Point(256, 104);
            this.buttonSpelaIgen.Name = "buttonSpelaIgen";
            this.buttonSpelaIgen.Size = new System.Drawing.Size(75, 23);
            this.buttonSpelaIgen.TabIndex = 3;
            this.buttonSpelaIgen.Text = "Spela igen";
            this.buttonSpelaIgen.UseVisualStyleBackColor = true;
            this.buttonSpelaIgen.Click += new System.EventHandler(this.ButtonSpelaIgen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.buttonSpelaIgen);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxSpel);
            this.Controls.Add(this.groupBoxSpeldata);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Gissa mitt tal!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxSpeldata.ResumeLayout(false);
            this.groupBoxSpeldata.PerformLayout();
            this.groupBoxSpel.ResumeLayout(false);
            this.groupBoxSpel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxSpeldata;
        private System.Windows.Forms.ListBox listBoxStörstaTal;
        private System.Windows.Forms.GroupBox groupBoxSpel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMinaResultat;
        private System.Windows.Forms.TextBox textBoxMinaResultat;
        private System.Windows.Forms.Label labelResultat;
        private System.Windows.Forms.Button buttonGissa;
        private System.Windows.Forms.TextBox textBoxGissa;
        private System.Windows.Forms.Label labelDatornsTalSiffra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDatornsTalText;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSpelaIgen;
    }
}

