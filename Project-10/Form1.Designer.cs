namespace Project_10
{
    partial class Proj10Form
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxCalculateOnlySubTotal = new System.Windows.Forms.CheckBox();
            this.lblTaxPercent = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxTipPercent = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxPersonCount = new System.Windows.Forms.GroupBox();
            this.comboBoxSplitCount = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBoxTipPercent.SuspendLayout();
            this.groupBoxPersonCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tip Calculator";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxPersonCount);
            this.panel1.Controls.Add(this.groupBoxTipPercent);
            this.panel1.Controls.Add(this.checkBoxCalculateOnlySubTotal);
            this.panel1.Controls.Add(this.lblTaxPercent);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(18, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 111);
            this.panel1.TabIndex = 1;
            // 
            // checkBoxCalculateOnlySubTotal
            // 
            this.checkBoxCalculateOnlySubTotal.AutoSize = true;
            this.checkBoxCalculateOnlySubTotal.Location = new System.Drawing.Point(137, 64);
            this.checkBoxCalculateOnlySubTotal.Name = "checkBoxCalculateOnlySubTotal";
            this.checkBoxCalculateOnlySubTotal.Size = new System.Drawing.Size(171, 17);
            this.checkBoxCalculateOnlySubTotal.TabIndex = 6;
            this.checkBoxCalculateOnlySubTotal.Text = "Ignore Tax (Only Use Subtotal)";
            this.checkBoxCalculateOnlySubTotal.UseVisualStyleBackColor = true;
            // 
            // lblTaxPercent
            // 
            this.lblTaxPercent.AutoSize = true;
            this.lblTaxPercent.Location = new System.Drawing.Point(19, 48);
            this.lblTaxPercent.Name = "lblTaxPercent";
            this.lblTaxPercent.Size = new System.Drawing.Size(42, 13);
            this.lblTaxPercent.TabIndex = 3;
            this.lblTaxPercent.Text = "Tax (%)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(19, 9);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(68, 13);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "Sub Total ($)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // groupBoxTipPercent
            // 
            this.groupBoxTipPercent.Controls.Add(this.comboBox1);
            this.groupBoxTipPercent.Location = new System.Drawing.Point(128, 9);
            this.groupBoxTipPercent.Name = "groupBoxTipPercent";
            this.groupBoxTipPercent.Size = new System.Drawing.Size(100, 45);
            this.groupBoxTipPercent.TabIndex = 2;
            this.groupBoxTipPercent.TabStop = false;
            this.groupBoxTipPercent.Text = "Tip (%)";
            this.groupBoxTipPercent.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBoxPersonCount
            // 
            this.groupBoxPersonCount.Controls.Add(this.comboBoxSplitCount);
            this.groupBoxPersonCount.Location = new System.Drawing.Point(234, 9);
            this.groupBoxPersonCount.Name = "groupBoxPersonCount";
            this.groupBoxPersonCount.Size = new System.Drawing.Size(100, 45);
            this.groupBoxPersonCount.TabIndex = 2;
            this.groupBoxPersonCount.TabStop = false;
            this.groupBoxPersonCount.Text = "Split";
            // 
            // comboBoxSplitCount
            // 
            this.comboBoxSplitCount.FormattingEnabled = true;
            this.comboBoxSplitCount.Location = new System.Drawing.Point(9, 15);
            this.comboBoxSplitCount.Name = "comboBoxSplitCount";
            this.comboBoxSplitCount.Size = new System.Drawing.Size(85, 21);
            this.comboBoxSplitCount.TabIndex = 7;
            // 
            // Proj10Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Proj10Form";
            this.Text = "CST242 Project 10";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxTipPercent.ResumeLayout(false);
            this.groupBoxPersonCount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxTipPercent;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxCalculateOnlySubTotal;
        private System.Windows.Forms.Label lblTaxPercent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxPersonCount;
        private System.Windows.Forms.ComboBox comboBoxSplitCount;
    }
}

