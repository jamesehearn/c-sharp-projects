/*
 * Program Name: Special Notices Form
 * Author: James E. Hearn 
 * Purpose: This program demonstrates use of image boxes, 
 *              radio buttons, check boxes, PrintForm, 
 *              and label colors.
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

namespace ChristophersCarCenter
{
    public partial class carCenterForm : Form
    {
        public carCenterForm()
        {
            //Required for Designer support
            InitializeComponent();

            //Defaults to the black text and gray backgorund messageLabel
            blackGrayRadioButton.Checked = true;
        }

        private void carCenterForm_Load(object sender, EventArgs e)
        {

        }

        private void hoursCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the hoursCheckBox is checked, then display hoursLabel
            hoursLabel.Visible = hoursCheckBox.Checked;
        }

        private void autoSalesPictureBox_Click(object sender, EventArgs e)
        {
            //Displays current sales information
            messageLabel.Text = "Family wagon, immaculate \r\ncondition, $12,995";
        }

        private void serviceCenterPictureBox_Click(object sender, EventArgs e)
        {
            //Displays current service specials
            messageLabel.Text = "Lube, oil, filter $25.99";
        }

        private void detailShopPictureBox_Click(object sender, EventArgs e)
        {
            //Dsiplays current detail specials
            messageLabel.Text = "Complete detail \r\n$79.95 most cars";
        }

        private void employmentPictureBox_Click(object sender, EventArgs e)
        {
            //Displays current employment opportunities
            messageLabel.Text = "Sales position, contact \r\nMr. Mann 551-2134 X475";
        }

        private void blackGrayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Changes the text color of the messageLabel to black, background to gray
            messageLabel.ForeColor = Color.Black;
            messageLabel.BackColor = Color.Gray;
        }

        private void blueWhiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Changes the text color of the messageLabel to blue, background to white
            messageLabel.ForeColor = Color.Blue;
            messageLabel.BackColor = Color.White;
        }

        private void redPinkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Changes the text color of the messageLabel to red, background to pink
            messageLabel.ForeColor = Color.Red;
            messageLabel.BackColor = Color.Pink;
        }

        private void yellowRedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Changes the text color of the messageLabel to yellow, background to red
            messageLabel.ForeColor = Color.Yellow;
            messageLabel.BackColor = Color.Red;
        }

        private void clearPictureBox_Click(object sender, EventArgs e)
        {
            //Clear contents of messageLabel
            messageLabel.Text = "";
            hoursCheckBox.Checked = false;
        }

        private void printPictureBox_Click(object sender, EventArgs e)
        {
            //Sends form to Print Preview
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }
    }
}
