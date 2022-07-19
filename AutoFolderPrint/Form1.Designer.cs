namespace AutoFolderPrint
{
    partial class AutoPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoPrint));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.removeAfterPrintingCheckbox = new System.Windows.Forms.CheckBox();
            this.askBeforePrintingCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // removeAfterPrintingCheckbox
            // 
            resources.ApplyResources(this.removeAfterPrintingCheckbox, "removeAfterPrintingCheckbox");
            this.removeAfterPrintingCheckbox.Checked = true;
            this.removeAfterPrintingCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeAfterPrintingCheckbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeAfterPrintingCheckbox.Name = "removeAfterPrintingCheckbox";
            this.removeAfterPrintingCheckbox.UseVisualStyleBackColor = true;
            this.removeAfterPrintingCheckbox.CheckedChanged += new System.EventHandler(this.removeAfterPrintingCheckbox_CheckedChanged);
            // 
            // askBeforePrintingCheckbox
            // 
            resources.ApplyResources(this.askBeforePrintingCheckbox, "askBeforePrintingCheckbox");
            this.askBeforePrintingCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.askBeforePrintingCheckbox.Checked = true;
            this.askBeforePrintingCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.askBeforePrintingCheckbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.askBeforePrintingCheckbox.Name = "askBeforePrintingCheckbox";
            this.askBeforePrintingCheckbox.UseVisualStyleBackColor = false;
            this.askBeforePrintingCheckbox.CheckedChanged += new System.EventHandler(this.askBeforePrintingCheckbox_CheckedChanged);
            // 
            // AutoPrint
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.askBeforePrintingCheckbox);
            this.Controls.Add(this.removeAfterPrintingCheckbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "AutoPrint";
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

