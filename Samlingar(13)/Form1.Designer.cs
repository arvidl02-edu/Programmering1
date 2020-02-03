namespace Samlingar_13_
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxMiasKiosk = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMiasInput = new System.Windows.Forms.TextBox();
            this.buttonEnqueue = new System.Windows.Forms.Button();
            this.textBoxMiasOutput = new System.Windows.Forms.TextBox();
            this.buttonDequeue = new System.Windows.Forms.Button();
            this.groupBoxMiasKiosk.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Palindrom - Stack",
            "Namn - Kö"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ord:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(12, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(45, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kolla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBoxMiasKiosk
            // 
            this.groupBoxMiasKiosk.Controls.Add(this.buttonDequeue);
            this.groupBoxMiasKiosk.Controls.Add(this.textBoxMiasOutput);
            this.groupBoxMiasKiosk.Controls.Add(this.buttonEnqueue);
            this.groupBoxMiasKiosk.Controls.Add(this.textBoxMiasInput);
            this.groupBoxMiasKiosk.Controls.Add(this.label2);
            this.groupBoxMiasKiosk.Location = new System.Drawing.Point(206, 12);
            this.groupBoxMiasKiosk.Name = "groupBoxMiasKiosk";
            this.groupBoxMiasKiosk.Size = new System.Drawing.Size(265, 178);
            this.groupBoxMiasKiosk.TabIndex = 5;
            this.groupBoxMiasKiosk.TabStop = false;
            this.groupBoxMiasKiosk.Text = "Mias kiosk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Namn:";
            // 
            // textBoxMiasInput
            // 
            this.textBoxMiasInput.Location = new System.Drawing.Point(69, 38);
            this.textBoxMiasInput.Name = "textBoxMiasInput";
            this.textBoxMiasInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiasInput.TabIndex = 1;
            // 
            // buttonEnqueue
            // 
            this.buttonEnqueue.Location = new System.Drawing.Point(175, 36);
            this.buttonEnqueue.Name = "buttonEnqueue";
            this.buttonEnqueue.Size = new System.Drawing.Size(57, 23);
            this.buttonEnqueue.TabIndex = 6;
            this.buttonEnqueue.Text = "Ställ i kö";
            this.buttonEnqueue.UseVisualStyleBackColor = true;
            this.buttonEnqueue.Click += new System.EventHandler(this.ButtonEnqueue_Click);
            // 
            // textBoxMiasOutput
            // 
            this.textBoxMiasOutput.Location = new System.Drawing.Point(28, 64);
            this.textBoxMiasOutput.Name = "textBoxMiasOutput";
            this.textBoxMiasOutput.ReadOnly = true;
            this.textBoxMiasOutput.Size = new System.Drawing.Size(204, 20);
            this.textBoxMiasOutput.TabIndex = 6;
            // 
            // buttonDequeue
            // 
            this.buttonDequeue.Location = new System.Drawing.Point(114, 90);
            this.buttonDequeue.Name = "buttonDequeue";
            this.buttonDequeue.Size = new System.Drawing.Size(118, 23);
            this.buttonDequeue.TabIndex = 6;
            this.buttonDequeue.Text = "Expediera nästa kund";
            this.buttonDequeue.UseVisualStyleBackColor = true;
            this.buttonDequeue.Click += new System.EventHandler(this.ButtonDequeue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxMiasKiosk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Playground";
            this.groupBoxMiasKiosk.ResumeLayout(false);
            this.groupBoxMiasKiosk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxMiasKiosk;
        private System.Windows.Forms.Button buttonDequeue;
        private System.Windows.Forms.TextBox textBoxMiasOutput;
        private System.Windows.Forms.Button buttonEnqueue;
        private System.Windows.Forms.TextBox textBoxMiasInput;
        private System.Windows.Forms.Label label2;
    }
}

