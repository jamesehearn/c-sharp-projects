/*
 * Project: Car Rental Charges
 * Programmer: James E. Hearn
 * Description: This program accepts the renter's name, 
 *              address, city, state, zip code, as well 
 *              as the odometer start reading, odometer
 *              ending reading, and total days rented.
 *              Displayes total miles driven and total 
 *              rental charges.
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

namespace RentalCarCharges
{
    public partial class rentalCarChargesForm : Form
    {
        //Declare class-level variable and make private
        private const decimal MILEAGE_RATE_Decimal = 0.12m;
        private const int DAY_RATE_Integer = 15;

        public rentalCarChargesForm()
        {
            //Needed for designer controls
            InitializeComponent();
        }

        private void rentalCarChargesForm_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Calculate the charges based upon total miles driven and days rented

            //Declare local variables
            int startOdometerInt, endingOdometerInt, totalMilesInt, daysUseInt;
            decimal totalMilageChargeDecimal, totalDayChargeDecimal, totalChargeDecimal;

            try
            {
                //Convert begining and ending odometer readings to numerals and assign to variable
                startOdometerInt = int.Parse(odometerStartTextBox.Text);
                endingOdometerInt = int.Parse(odometerEndTextBox.Text);

                //Calculate total miles and display in total miles text box
                totalMilesInt = endingOdometerInt - startOdometerInt;
                
                totalMilesTextBox.Text = totalMilesInt.ToString();
                try
                {
                    //Convert daysUse to numerals for calculation and assign to variable
                    daysUseInt = int.Parse(daysUseTextBox.Text);

                    //Calculate total amount of rental charges, assign to variable
                    totalDayChargeDecimal = daysUseInt * DAY_RATE_Integer;

                    totalMilageChargeDecimal = totalMilesInt * MILEAGE_RATE_Decimal;

                    totalChargeDecimal = totalMilageChargeDecimal + totalDayChargeDecimal;

                    //Format & display total charges
                    totalChargeTextBox.Text = totalChargeDecimal.ToString("C");
                
                }
                catch
                 {
                    //Invalid number of days used
                    MessageBox.Show("Invalid number of days used. Please enter a numeric value.", "Non-Numeric Value!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    daysUseTextBox.Focus();
                    daysUseTextBox.SelectAll();
            
                }
            }
            catch
            {
                //Invalid odometer value(s)
                MessageBox.Show("Invalid odometer value(s). Please enter a numeric value.", "Non-Numeric Value for both odometer readings!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                odometerStartTextBox.Focus();
                odometerStartTextBox.SelectAll();

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            customerNameTextBox.Clear();
            addressTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipCodeTextBox.Clear();
            odometerStartTextBox.Clear();
            odometerEndTextBox.Clear();
            daysUseTextBox.Clear();
            totalMilesTextBox.Clear();
            totalChargeTextBox.Clear();
            customerNameTextBox.Focus();

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
