/*
 * Project: Final Total Due Calculator
 * Programmer: James E. Hearn
 * Description: Calculates final total cost payable by customer for automobile, 
 *              after acessories, finishing options, taxes, and trade-in
 *              allowance.
 *              
 *              Uses radio boxes, check boxes, if statements, and
 *              try/catch statements.
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
using System.Globalization;

namespace ChristophersCarCenterCh4
{
    public partial class TotalAmountDueForm : Form
    {
        //Declare class-level constants and initalize
        //Tax Rate Decimal
        public const decimal TAX_RATE_Decimal = 0.08m;
        //Stereo System cost
        public const decimal STEREO_COST_Decimal = 425.76m;
        //Leather Interior cost
        public const decimal LEATHER_COST_Decimal = 987.41m;
        //Computer Nav cost
        public const decimal COMPUTER_NAV_COST_Decimal = 1741.23m;
        //Pearlized option cost
        public const decimal PEARLIZED_COST_Decimal = 345.72m;
        //Customized Detailing option cost
        public const decimal CUSTOMIZED_COST_Decimal = 599.99m;
        
        public TotalAmountDueForm()
        {
            //Needed for designer support
            InitializeComponent();

            //Default standard finish to being checked
            standardRadioButton.Checked = true;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Calculates total owed from customer

            //Declare local variables
            //Base Price Decimal
            decimal basePriceDecimal;
            //Total amount of accessories added and initalize to 0.0
            decimal accessoriesTotalDecimal = 0.0m;
            //Total amount of all accessories + finishing options and initalize to 0.0
            decimal accessoriesAndFinishDecimal = 0.0m;
            //Total amountof base price + accessories + finishing options
            decimal subtotalDecimal;
            //Total amount of sales tax owed
            decimal salesTaxDecimal;
            //Pre-trade-in total
            decimal preTradeInDecimal;
            //Trade-in allowance
            decimal tradeinDecimal;
            //Total amount due from customer
            decimal amountDueDecimal;

            try
            {
                //Convert base price input value to numeric and assign to variable
                basePriceDecimal = decimal.Parse(basePriceTextBox.Text, NumberStyles.Currency);
                Console.WriteLine("Base price: " + basePriceDecimal);

                try
                {
                    //If no trade in value is entered, make the 0.00 defualt value
                    if (tradeInAllowanceTextBox.Text == "")
                    {
                        tradeinDecimal = 0.00m;
                    }
                    else
                    {
                        //Convert trade-in input value to numeric and assign to variable
                        tradeinDecimal = decimal.Parse(tradeInAllowanceTextBox.Text, NumberStyles.Currency);
                        Console.WriteLine("Trade-in amount: " + tradeinDecimal);
                    }

                    //Calculate total of accessories added 
                    if (stereoCheckBox.Checked) //If stereo accessory is checked
                    {
                        accessoriesTotalDecimal += STEREO_COST_Decimal;
                    }
                    if (interiorCheckBox.Checked) //If leather interior is selected
                    {
                        accessoriesTotalDecimal += LEATHER_COST_Decimal;
                    }
                    if (navigationCheckBox.Checked) //If computer navigaiton is selected
                    {
                        accessoriesTotalDecimal += COMPUTER_NAV_COST_Decimal;
                    }

                    Console.WriteLine("Total of accessories: " + accessoriesTotalDecimal);

                    //Calculate total amount of accessories and finish
                    if (pearlizedRadioButton.Checked) //If pearlized option is selected
                    {
                        accessoriesAndFinishDecimal = accessoriesTotalDecimal + PEARLIZED_COST_Decimal;
                    }
                    else if (customizedRadioButton.Checked) //If custom detailing option is selected
                    {
                        accessoriesAndFinishDecimal = accessoriesTotalDecimal + CUSTOMIZED_COST_Decimal;
                    }
                    else //If standard finish is selected, accessories and finish total = just accessories
                    {
                        accessoriesAndFinishDecimal = accessoriesTotalDecimal;
                    }

                    Console.WriteLine("Total accessories and finishing: " + accessoriesAndFinishDecimal);

                    //Display base price as currency
                    basePriceTextBox.Text = basePriceDecimal.ToString("C");

                    //Display total of accessories plus finish options
                    accessoriesTextBox.Text = accessoriesAndFinishDecimal.ToString("C");

                    //Subtotal equals base price plus total of accessories and finish options
                    subtotalDecimal = basePriceDecimal + accessoriesAndFinishDecimal;

                    //Display subtotal in subtotal text box
                    subtotalTextBox.Text = subtotalDecimal.ToString("C");

                    //Calculate sales tax
                    salesTaxDecimal = TAX_RATE_Decimal * subtotalDecimal;

                    //Display sales tax amount
                    salesTaxTextBox.Text = salesTaxDecimal.ToString("C");

                    //Calulate total of base price + accessories + finishing + tax
                    preTradeInDecimal = subtotalDecimal + salesTaxDecimal;

                    //Display pre-trade-in total (base + accessories + finishing + tax
                    preTradeTotalTextBox.Text = preTradeInDecimal.ToString("C");

                    //Display trade-in value as currency
                    tradeInAllowanceTextBox.Text = tradeinDecimal.ToString("C");

                    //Calculate amount due (pre-trade-in total minus trade-in value
                    amountDueDecimal = preTradeInDecimal - tradeinDecimal;

                    //Display total due (pre-trade total minus trade-in)
                    amountDueTextBox.Text = amountDueDecimal.ToString("C");
                }

                catch
                {
                    //Invalid trade-in allowance
                    MessageBox.Show("Invalid trade-in allowance. \nPlease enter numbers only (no dollar sign).", "Invalid data!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    tradeInAllowanceTextBox.Focus(); //Resets focus to trade-in text box
                    tradeInAllowanceTextBox.SelectAll(); //Select entire content of text box
                }
            }
            catch
            {
                //Invalid base price
                MessageBox.Show("Invalid base price. \nPlease enter numbers only  (no dollar sign).", "Invalid data!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                basePriceTextBox.Focus(); //Resets focus to base price text box
                basePriceTextBox.SelectAll();  //Select entire content of text box
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears form, resets focus to inital text box, and resets
            //checkboxes and radio buttons to inital configuration.
            basePriceTextBox.Focus();
            basePriceTextBox.Clear();
            accessoriesTextBox.Clear();
            subtotalTextBox.Clear();
            salesTaxTextBox.Clear();
            preTradeTotalTextBox.Clear();
            tradeInAllowanceTextBox.Clear();
            amountDueTextBox.Clear();
            stereoCheckBox.Checked = false;
            interiorCheckBox.Checked = false;
            navigationCheckBox.Checked = false;
            standardRadioButton.Checked = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the entire form
            this.Close();
        }
    }
}
