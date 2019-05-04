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
            this.tipPanel = new System.Windows.Forms.Panel();
            this.groupBoxPersonCount = new System.Windows.Forms.GroupBox();
            this.comboBoxSplitCount = new System.Windows.Forms.ComboBox();
            this.groupBoxTipPercent = new System.Windows.Forms.GroupBox();
            this.comboBoxTipPercent = new System.Windows.Forms.ComboBox();
            this.checkBoxCalculateOnlySubTotal = new System.Windows.Forms.CheckBox();
            this.lblTaxPercent = new System.Windows.Forms.Label();
            this.textBoxSubTotalInput = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.textBoxSalesTaxInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.lblTipTotal = new System.Windows.Forms.Label();
            this.lblSalesTaxTotal = new System.Windows.Forms.Label();
            this.textBoxTipOutput = new System.Windows.Forms.TextBox();
            this.textBoxSalesTaxOutput = new System.Windows.Forms.TextBox();
            this.dollarLabel = new System.Windows.Forms.Label();
            this.dollarLabelTax = new System.Windows.Forms.Label();
            this.tipPanel.SuspendLayout();
            this.groupBoxPersonCount.SuspendLayout();
            this.groupBoxTipPercent.SuspendLayout();
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
            // tipPanel
            // 
            this.tipPanel.Controls.Add(this.groupBoxPersonCount);
            this.tipPanel.Controls.Add(this.groupBoxTipPercent);
            this.tipPanel.Controls.Add(this.checkBoxCalculateOnlySubTotal);
            this.tipPanel.Controls.Add(this.lblTaxPercent);
            this.tipPanel.Controls.Add(this.textBoxSubTotalInput);
            this.tipPanel.Controls.Add(this.lblSubTotal);
            this.tipPanel.Controls.Add(this.textBoxSalesTaxInput);
            this.tipPanel.Location = new System.Drawing.Point(18, 43);
            this.tipPanel.Name = "tipPanel";
            this.tipPanel.Size = new System.Drawing.Size(354, 111);
            this.tipPanel.TabIndex = 1;
            // 
            // groupBoxPersonCount
            // 
            this.groupBoxPersonCount.Controls.Add(this.comboBoxSplitCount);
            this.groupBoxPersonCount.Location = new System.Drawing.Point(234, 9);
            this.groupBoxPersonCount.Name = "groupBoxPersonCount";
            this.groupBoxPersonCount.Size = new System.Drawing.Size(100, 45);
            this.groupBoxPersonCount.TabIndex = 2;
            this.groupBoxPersonCount.TabStop = false;
            this.groupBoxPersonCount.Text = "Tip Split";
            // 
            // comboBoxSplitCount
            // 
            this.comboBoxSplitCount.FormattingEnabled = true;
            this.comboBoxSplitCount.Items.AddRange(new object[] {
            "1.0",
            "2.0",
            "3.0",
            "4.0",
            "5.0"});
            this.comboBoxSplitCount.Location = new System.Drawing.Point(9, 15);
            this.comboBoxSplitCount.Name = "comboBoxSplitCount";
            this.comboBoxSplitCount.Size = new System.Drawing.Size(85, 21);
            this.comboBoxSplitCount.TabIndex = 7;
            // 
            // groupBoxTipPercent
            // 
            this.groupBoxTipPercent.Controls.Add(this.comboBoxTipPercent);
            this.groupBoxTipPercent.Location = new System.Drawing.Point(128, 9);
            this.groupBoxTipPercent.Name = "groupBoxTipPercent";
            this.groupBoxTipPercent.Size = new System.Drawing.Size(100, 45);
            this.groupBoxTipPercent.TabIndex = 2;
            this.groupBoxTipPercent.TabStop = false;
            this.groupBoxTipPercent.Text = "Tip (%)";
            this.groupBoxTipPercent.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxTipPercent
            // 
            this.comboBoxTipPercent.FormattingEnabled = true;
            this.comboBoxTipPercent.Items.AddRange(new object[] {
            "10.0",
            "15.0",
            "20.0",
            "25.0",
            "30.0"});
            this.comboBoxTipPercent.Location = new System.Drawing.Point(9, 16);
            this.comboBoxTipPercent.Name = "comboBoxTipPercent";
            this.comboBoxTipPercent.Size = new System.Drawing.Size(85, 21);
            this.comboBoxTipPercent.TabIndex = 0;
            // 
            // checkBoxCalculateOnlySubTotal
            // 
            this.checkBoxCalculateOnlySubTotal.AutoSize = true;
            this.checkBoxCalculateOnlySubTotal.Location = new System.Drawing.Point(137, 64);
            this.checkBoxCalculateOnlySubTotal.Name = "checkBoxCalculateOnlySubTotal";
            this.checkBoxCalculateOnlySubTotal.Size = new System.Drawing.Size(216, 17);
            this.checkBoxCalculateOnlySubTotal.TabIndex = 6;
            this.checkBoxCalculateOnlySubTotal.Text = "Ignore Tax (Tip only accounts SubTotal)";
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
            // textBoxSubTotalInput
            // 
            this.textBoxSubTotalInput.Location = new System.Drawing.Point(22, 25);
            this.textBoxSubTotalInput.Name = "textBoxSubTotalInput";
            this.textBoxSubTotalInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubTotalInput.TabIndex = 4;
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
            // textBoxSalesTaxInput
            // 
            this.textBoxSalesTaxInput.Location = new System.Drawing.Point(22, 64);
            this.textBoxSalesTaxInput.Name = "textBoxSalesTaxInput";
            this.textBoxSalesTaxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalesTaxInput.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(133, 160);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(122, 42);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // lblTipTotal
            // 
            this.lblTipTotal.AutoSize = true;
            this.lblTipTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipTotal.Location = new System.Drawing.Point(12, 221);
            this.lblTipTotal.Name = "lblTipTotal";
            this.lblTipTotal.Size = new System.Drawing.Size(237, 31);
            this.lblTipTotal.TabIndex = 3;
            this.lblTipTotal.Text = "Tip (Per Person):";
            // 
            // lblSalesTaxTotal
            // 
            this.lblSalesTaxTotal.AutoSize = true;
            this.lblSalesTaxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTaxTotal.Location = new System.Drawing.Point(97, 279);
            this.lblSalesTaxTotal.Name = "lblSalesTaxTotal";
            this.lblSalesTaxTotal.Size = new System.Drawing.Size(152, 31);
            this.lblSalesTaxTotal.TabIndex = 4;
            this.lblSalesTaxTotal.Text = "Sales Tax:";
            // 
            // textBoxTipOutput
            // 
            this.textBoxTipOutput.Location = new System.Drawing.Point(255, 233);
            this.textBoxTipOutput.Name = "textBoxTipOutput";
            this.textBoxTipOutput.ReadOnly = true;
            this.textBoxTipOutput.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipOutput.TabIndex = 6;
            // 
            // textBoxSalesTaxOutput
            // 
            this.textBoxSalesTaxOutput.Location = new System.Drawing.Point(255, 291);
            this.textBoxSalesTaxOutput.Name = "textBoxSalesTaxOutput";
            this.textBoxSalesTaxOutput.ReadOnly = true;
            this.textBoxSalesTaxOutput.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalesTaxOutput.TabIndex = 7;
            // 
            // dollarLabel
            // 
            this.dollarLabel.AutoSize = true;
            this.dollarLabel.Location = new System.Drawing.Point(242, 236);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(13, 13);
            this.dollarLabel.TabIndex = 8;
            this.dollarLabel.Text = "$";
            // 
            // dollarLabelTax
            // 
            this.dollarLabelTax.AutoSize = true;
            this.dollarLabelTax.Location = new System.Drawing.Point(242, 294);
            this.dollarLabelTax.Name = "dollarLabelTax";
            this.dollarLabelTax.Size = new System.Drawing.Size(13, 13);
            this.dollarLabelTax.TabIndex = 9;
            this.dollarLabelTax.Text = "$";
            // 
            // Proj10Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.dollarLabelTax);
            this.Controls.Add(this.dollarLabel);
            this.Controls.Add(this.textBoxSalesTaxOutput);
            this.Controls.Add(this.textBoxTipOutput);
            this.Controls.Add(this.lblSalesTaxTotal);
            this.Controls.Add(this.lblTipTotal);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.tipPanel);
            this.Controls.Add(this.lblTitle);
            this.Name = "Proj10Form";
            this.Text = "CST242 Project 10";
            this.tipPanel.ResumeLayout(false);
            this.tipPanel.PerformLayout();
            this.groupBoxPersonCount.ResumeLayout(false);
            this.groupBoxTipPercent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel tipPanel;
        private System.Windows.Forms.GroupBox groupBoxTipPercent;
        private System.Windows.Forms.ComboBox comboBoxTipPercent;
        private System.Windows.Forms.CheckBox checkBoxCalculateOnlySubTotal;
        private System.Windows.Forms.Label lblTaxPercent;
        private System.Windows.Forms.TextBox textBoxSubTotalInput;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox textBoxSalesTaxInput;
        private System.Windows.Forms.GroupBox groupBoxPersonCount;
        private System.Windows.Forms.ComboBox comboBoxSplitCount;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label lblTipTotal;
        private System.Windows.Forms.Label lblSalesTaxTotal;
        private System.Windows.Forms.TextBox textBoxTipOutput;
        private System.Windows.Forms.TextBox textBoxSalesTaxOutput;
        private System.Windows.Forms.Label dollarLabel;
        private System.Windows.Forms.Label dollarLabelTax;
    }
}

