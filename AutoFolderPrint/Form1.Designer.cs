namespace AutoFolderPrint
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.removeAfterPrintingCheckbox = new System.Windows.Forms.CheckBox();
            this.askBeforePrintingCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(697, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder to monitor:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // removeAfterPrintingCheckbox
            // 
            this.removeAfterPrintingCheckbox.AutoSize = true;
            this.removeAfterPrintingCheckbox.Checked = true;
            this.removeAfterPrintingCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeAfterPrintingCheckbox.Location = new System.Drawing.Point(12, 83);
            this.removeAfterPrintingCheckbox.Name = "removeAfterPrintingCheckbox";
            this.removeAfterPrintingCheckbox.Size = new System.Drawing.Size(148, 17);
            this.removeAfterPrintingCheckbox.TabIndex = 4;
            this.removeAfterPrintingCheckbox.Text = "Remove files after printing";
            this.removeAfterPrintingCheckbox.UseVisualStyleBackColor = true;
            this.removeAfterPrintingCheckbox.CheckedChanged += new System.EventHandler(this.removeAfterPrintingCheckbox_CheckedChanged);
            // 
            // askBeforePrintingCheckbox
            // 
            this.askBeforePrintingCheckbox.AutoSize = true;
            this.askBeforePrintingCheckbox.Checked = true;
            this.askBeforePrintingCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.askBeforePrintingCheckbox.Location = new System.Drawing.Point(12, 60);
            this.askBeforePrintingCheckbox.Name = "askBeforePrintingCheckbox";
            this.askBeforePrintingCheckbox.Size = new System.Drawing.Size(114, 17);
            this.askBeforePrintingCheckbox.TabIndex = 5;
            this.askBeforePrintingCheckbox.Text = "Ask before printing";
            this.askBeforePrintingCheckbox.UseVisualStyleBackColor = true;
            this.askBeforePrintingCheckbox.CheckedChanged += new System.EventHandler(this.askBeforePrintingCheckbox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.askBeforePrintingCheckbox);
            this.Controls.Add(this.removeAfterPrintingCheckbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox removeAfterPrintingCheckbox;
        private System.Windows.Forms.CheckBox askBeforePrintingCheckbox;
    }
}

