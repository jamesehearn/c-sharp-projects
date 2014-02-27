/*
 * Project: Christopher's Car Center
 * Programmer: James E. Hearn
 * Description: This program accepts the salesperson's name, 
 *              sales price for a vehicle, the original 
 *              cost of the vehicle, and returns the 
 *              amount of comission from the sale of the
 *              vehicle.
 *              
 *              Uses constants, variables, calculations, 
 *              and exception catching.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristophersCarCenterCh3
{
    public partial class commissionRateForm : Form
    {
        //Declare class-level variable an dmake private
        private const decimal COMMISSION_RATE_Decimal = 0.20m;

        public commissionRateForm()
        {
            //Needed for designer controls
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Calculate the commission based upon selling price & original cost
            
            //Declare local variables
            //Sale price of automobile
            decimal sellingPriceDecimal;
            //Cost of automobile
            decimal costValueDecimal;
            //Amouint of profit from sale of automobile
            decimal profitDecimal;
            //Amount of commission due to salesperson
            decimal commissionDecimal;

            try
            {
                //Convert selling price to numerals and assign to variable
                sellingPriceDecimal = decimal.Parse(priceTextBox.Text);

                try
                {
                    //Convert cost to numerals for calculation and assign to variable
                    costValueDecimal = decimal.Parse(valueTextBox.Text);

                    //Calculate values
                    profitDecimal = sellingPriceDecimal - costValueDecimal;

                    commissionDecimal = Decimal.Round(profitDecimal * COMMISSION_RATE_Decimal);

                    //Format & display values
                    commissionTextBox.Text = commissionDecimal.ToString("C");
                }
                catch
                {
                    //Invalid selling price
                    MessageBox.Show("Invalid cost. Please enter a numeric value.", "Non-Numeric Value!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valueTextBox.Focus();
                    valueTextBox.SelectAll();
                }
            }
            catch
            {
                //Invalid cost value
                MessageBox.Show("Invalid selling price. Please enter a numeric value.", "Non-Numeric Value!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                priceTextBox.Focus();
                priceTextBox.SelectAll();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears the form for another calculation
            nameTextBox.Clear();
            priceTextBox.Clear();
            valueTextBox.Clear();
            commissionTextBox.Clear();
            nameTextBox.Focus();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //Prints the form in preview
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }
    }
}
