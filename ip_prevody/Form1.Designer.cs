namespace ip_prevody
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inHex = new System.Windows.Forms.RadioButton();
            this.inBin = new System.Windows.Forms.RadioButton();
            this.inDec = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outHex = new System.Windows.Forms.RadioButton();
            this.outBin = new System.Windows.Forms.RadioButton();
            this.outDec = new System.Windows.Forms.RadioButton();
            this.labVysNadpis = new System.Windows.Forms.Label();
            this.labVys = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Culture = new System.Globalization.CultureInfo("");
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 13);
            this.maskedTextBox1.Mask = "000.000.000.000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(318, 27);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inHex);
            this.groupBox1.Controls.Add(this.inBin);
            this.groupBox1.Controls.Add(this.inDec);
            this.groupBox1.Location = new System.Drawing.Point(14, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 178);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // inHex
            // 
            this.inHex.AutoSize = true;
            this.inHex.Location = new System.Drawing.Point(8, 89);
            this.inHex.Name = "inHex";
            this.inHex.Size = new System.Drawing.Size(117, 24);
            this.inHex.TabIndex = 2;
            this.inHex.Text = "Hexadecimal";
            this.inHex.UseVisualStyleBackColor = true;
            this.inHex.CheckedChanged += new System.EventHandler(this.inHex_CheckedChanged);
            // 
            // inBin
            // 
            this.inBin.AutoSize = true;
            this.inBin.Location = new System.Drawing.Point(8, 59);
            this.inBin.Name = "inBin";
            this.inBin.Size = new System.Drawing.Size(71, 24);
            this.inBin.TabIndex = 1;
            this.inBin.Text = "Binary";
            this.inBin.UseVisualStyleBackColor = true;
            this.inBin.CheckedChanged += new System.EventHandler(this.inBin_CheckedChanged);
            // 
            // inDec
            // 
            this.inDec.AutoSize = true;
            this.inDec.Checked = true;
            this.inDec.Location = new System.Drawing.Point(8, 29);
            this.inDec.Name = "inDec";
            this.inDec.Size = new System.Drawing.Size(85, 24);
            this.inDec.TabIndex = 0;
            this.inDec.TabStop = true;
            this.inDec.Text = "Decimal";
            this.inDec.UseVisualStyleBackColor = true;
            this.inDec.CheckedChanged += new System.EventHandler(this.inDec_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outHex);
            this.groupBox2.Controls.Add(this.outBin);
            this.groupBox2.Controls.Add(this.outDec);
            this.groupBox2.Location = new System.Drawing.Point(175, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 178);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // outHex
            // 
            this.outHex.AutoSize = true;
            this.outHex.Location = new System.Drawing.Point(8, 89);
            this.outHex.Name = "outHex";
            this.outHex.Size = new System.Drawing.Size(117, 24);
            this.outHex.TabIndex = 2;
            this.outHex.Text = "Hexadecimal";
            this.outHex.UseVisualStyleBackColor = true;
            // 
            // outBin
            // 
            this.outBin.AutoSize = true;
            this.outBin.Checked = true;
            this.outBin.Location = new System.Drawing.Point(8, 59);
            this.outBin.Name = "outBin";
            this.outBin.Size = new System.Drawing.Size(71, 24);
            this.outBin.TabIndex = 1;
            this.outBin.TabStop = true;
            this.outBin.Text = "Binary";
            this.outBin.UseVisualStyleBackColor = true;
            // 
            // outDec
            // 
            this.outDec.AutoSize = true;
            this.outDec.Location = new System.Drawing.Point(8, 29);
            this.outDec.Name = "outDec";
            this.outDec.Size = new System.Drawing.Size(85, 24);
            this.outDec.TabIndex = 0;
            this.outDec.Text = "Decimal";
            this.outDec.UseVisualStyleBackColor = true;
            // 
            // labVysNadpis
            // 
            this.labVysNadpis.AutoSize = true;
            this.labVysNadpis.Location = new System.Drawing.Point(336, 60);
            this.labVysNadpis.Name = "labVysNadpis";
            this.labVysNadpis.Size = new System.Drawing.Size(67, 20);
            this.labVysNadpis.TabIndex = 5;
            this.labVysNadpis.Text = "Výsledek";
            // 
            // labVys
            // 
            this.labVys.AutoSize = true;
            this.labVys.Location = new System.Drawing.Point(336, 83);
            this.labVys.Name = "labVys";
            this.labVys.Size = new System.Drawing.Size(27, 20);
            this.labVys.TabIndex = 6;
            this.labVys.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labVys);
            this.Controls.Add(this.labVysNadpis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "t";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox1;
        private RadioButton inHex;
        private RadioButton inBin;
        private RadioButton inDec;
        private GroupBox groupBox2;
        private RadioButton outHex;
        private RadioButton outBin;
        private RadioButton outDec;
        private Label labVysNadpis;
        private Label labVys;
    }
}