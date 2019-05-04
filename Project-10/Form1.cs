using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// The Namespace for the Project 10 Form.
/// 
/// By Andy Osorio, Thomas Lawless, Justin Moran CST242 Spring 2019 SCCC
/// </summary>
namespace Project_10
{
    public partial class Proj10Form : Form
    {
        /// <summary>
        /// Declaring the variables to be worked on;
        /// </summary>
        private double SubTotal;
        private double TaxPercent;
        private double TipSplit;
        private double TipPercent;
        private double TipTotal;
        private double TotalTax;
        public Proj10Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// A but method for groupbox 1, removing this breaks the program for some reason
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// The event handler for the calculate button. This button takes the input from the above group of controls
        /// and then initializes the declared variables. It then calculates the Tip based on the input and outputs it 
        /// to the bottom panel.
        /// </summary>
        /// <param name="sender">The Calculate Button</param>
        /// <param name="e">The Click Event</param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            SubTotal = Double.Parse(textBoxSubTotalInput.Text);
            TaxPercent = Double.Parse(textBoxSalesTaxInput.Text);
            TipSplit = Double.Parse(comboBoxSplitCount.Text);
            TipPercent = Double.Parse(comboBoxTipPercent.Text);

            if (checkBoxCalculateOnlySubTotal.Checked == true)
            {
                TotalTax = SubTotal * (TaxPercent / 100);
                textBoxSalesTaxOutput.Text = TotalTax.ToString();
                TipTotal = SubTotal * (TipPercent / 100);
                textBoxTipOutput.Text = (TipTotal / TipSplit).ToString();
            }
            else
            {
                TotalTax = SubTotal * (TaxPercent / 100);
                textBoxSalesTaxOutput.Text = TotalTax.ToString();
                SubTotal += TotalTax;
                TipTotal = SubTotal * (TipPercent / 100);
                textBoxTipOutput.Text = TipTotal.ToString();
            }
        }
    }
}
