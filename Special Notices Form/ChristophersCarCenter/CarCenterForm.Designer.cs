namespace ChristophersCarCenter
{
    partial class carCenterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carCenterForm));
            this.messageLabel = new System.Windows.Forms.Label();
            this.programmerLabel = new System.Windows.Forms.Label();
            this.autoSalesPictureBox = new System.Windows.Forms.PictureBox();
            this.serviceCenterPictureBox = new System.Windows.Forms.PictureBox();
            this.detailShopPictureBox = new System.Windows.Forms.PictureBox();
            this.employmentPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.clearPictureBox = new System.Windows.Forms.PictureBox();
            this.printPictureBox = new System.Windows.Forms.PictureBox();
            this.specialNoticeLabel = new System.Windows.Forms.Label();
            this.hoursCheckBox = new System.Windows.Forms.CheckBox();
            this.colorPickerGroupBox = new System.Windows.Forms.GroupBox();
            this.yellowRedRadioButton = new System.Windows.Forms.RadioButton();
            this.redPinkRadioButton = new System.Windows.Forms.RadioButton();
            this.blueWhiteRadioButton = new System.Windows.Forms.RadioButton();
            this.blackGrayRadioButton = new System.Windows.Forms.RadioButton();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.autoSalesLabel = new System.Windows.Forms.Label();
            this.serviceCenterLabel = new System.Windows.Forms.Label();
            this.detailShopLabel = new System.Windows.Forms.Label();
            this.employmentOpportunitiesLabel = new System.Windows.Forms.Label();
            this.clearNoticesLabel = new System.Windows.Forms.Label();
            this.printPreviewLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.autoSalesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailShopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employmentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPictureBox)).BeginInit();
            this.colorPickerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(34, 50);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(400, 65);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.messageLabel, "Here\'s what\'s so special!");
            // 
            // programmerLabel
            // 
            this.programmerLabel.AutoSize = true;
            this.programmerLabel.Location = new System.Drawing.Point(146, 550);
            this.programmerLabel.Name = "programmerLabel";
            this.programmerLabel.Size = new System.Drawing.Size(161, 13);
            this.programmerLabel.TabIndex = 12;
            this.programmerLabel.Text = "Programmed by: James E. Hearn";
            // 
            // autoSalesPictureBox
            // 
            this.autoSalesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("autoSalesPictureBox.Image")));
            this.autoSalesPictureBox.Location = new System.Drawing.Point(110, 192);
            this.autoSalesPictureBox.Name = "autoSalesPictureBox";
            this.autoSalesPictureBox.Size = new System.Drawing.Size(50, 50);
            this.autoSalesPictureBox.TabIndex = 7;
            this.autoSalesPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.autoSalesPictureBox, "Click for current sales prices!");
            this.autoSalesPictureBox.Click += new System.EventHandler(this.autoSalesPictureBox_Click);
            // 
            // serviceCenterPictureBox
            // 
            this.serviceCenterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("serviceCenterPictureBox.Image")));
            this.serviceCenterPictureBox.Location = new System.Drawing.Point(294, 192);
            this.serviceCenterPictureBox.Name = "serviceCenterPictureBox";
            this.serviceCenterPictureBox.Size = new System.Drawing.Size(50, 50);
            this.serviceCenterPictureBox.TabIndex = 8;
            this.serviceCenterPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.serviceCenterPictureBox, "Click to learn about service specials!");
            this.serviceCenterPictureBox.Click += new System.EventHandler(this.serviceCenterPictureBox_Click);
            // 
            // detailShopPictureBox
            // 
            this.detailShopPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("detailShopPictureBox.Image")));
            this.detailShopPictureBox.Location = new System.Drawing.Point(110, 278);
            this.detailShopPictureBox.Name = "detailShopPictureBox";
            this.detailShopPictureBox.Size = new System.Drawing.Size(50, 50);
            this.detailShopPictureBox.TabIndex = 9;
            this.detailShopPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.detailShopPictureBox, "Click to learn about detailing specials!");
            this.detailShopPictureBox.Click += new System.EventHandler(this.detailShopPictureBox_Click);
            // 
            // employmentPictureBox
            // 
            this.employmentPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("employmentPictureBox.Image")));
            this.employmentPictureBox.Location = new System.Drawing.Point(294, 278);
            this.employmentPictureBox.Name = "employmentPictureBox";
            this.employmentPictureBox.Size = new System.Drawing.Size(50, 50);
            this.employmentPictureBox.TabIndex = 10;
            this.employmentPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.employmentPictureBox, "Interested in joining the Christopher\'s Car Center team?");
            this.employmentPictureBox.Click += new System.EventHandler(this.employmentPictureBox_Click);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.Location = new System.Drawing.Point(346, 493);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(50, 50);
            this.exitPictureBox.TabIndex = 11;
            this.exitPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.exitPictureBox, "Click here to exit.");
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // clearPictureBox
            // 
            this.clearPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("clearPictureBox.Image")));
            this.clearPictureBox.Location = new System.Drawing.Point(68, 493);
            this.clearPictureBox.Name = "clearPictureBox";
            this.clearPictureBox.Size = new System.Drawing.Size(50, 50);
            this.clearPictureBox.TabIndex = 12;
            this.clearPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.clearPictureBox, "Click to clear the notices above.");
            this.clearPictureBox.Click += new System.EventHandler(this.clearPictureBox_Click);
            // 
            // printPictureBox
            // 
            this.printPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("printPictureBox.Image")));
            this.printPictureBox.Location = new System.Drawing.Point(204, 493);
            this.printPictureBox.Name = "printPictureBox";
            this.printPictureBox.Size = new System.Drawing.Size(50, 50);
            this.printPictureBox.TabIndex = 13;
            this.printPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.printPictureBox, "CLick here to open print preview.");
            this.printPictureBox.Click += new System.EventHandler(this.printPictureBox_Click);
            // 
            // specialNoticeLabel
            // 
            this.specialNoticeLabel.AutoSize = true;
            this.specialNoticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialNoticeLabel.Location = new System.Drawing.Point(118, 9);
            this.specialNoticeLabel.Name = "specialNoticeLabel";
            this.specialNoticeLabel.Size = new System.Drawing.Size(226, 31);
            this.specialNoticeLabel.TabIndex = 0;
            this.specialNoticeLabel.Text = "Special Notices:";
            // 
            // hoursCheckBox
            // 
            this.hoursCheckBox.AutoSize = true;
            this.hoursCheckBox.Location = new System.Drawing.Point(68, 137);
            this.hoursCheckBox.Name = "hoursCheckBox";
            this.hoursCheckBox.Size = new System.Drawing.Size(95, 17);
            this.hoursCheckBox.TabIndex = 2;
            this.hoursCheckBox.Text = "Click for &Hours";
            this.toolTip1.SetToolTip(this.hoursCheckBox, "Check this box to view Christopher\'s Cer Center hours of operation.");
            this.hoursCheckBox.UseVisualStyleBackColor = true;
            this.hoursCheckBox.CheckedChanged += new System.EventHandler(this.hoursCheckBox_CheckedChanged);
            // 
            // colorPickerGroupBox
            // 
            this.colorPickerGroupBox.Controls.Add(this.yellowRedRadioButton);
            this.colorPickerGroupBox.Controls.Add(this.redPinkRadioButton);
            this.colorPickerGroupBox.Controls.Add(this.blueWhiteRadioButton);
            this.colorPickerGroupBox.Controls.Add(this.blackGrayRadioButton);
            this.colorPickerGroupBox.Location = new System.Drawing.Point(103, 347);
            this.colorPickerGroupBox.Name = "colorPickerGroupBox";
            this.colorPickerGroupBox.Size = new System.Drawing.Size(260, 120);
            this.colorPickerGroupBox.TabIndex = 8;
            this.colorPickerGroupBox.TabStop = false;
            this.colorPickerGroupBox.Text = "Feel free to choose a color for the above notices!";
            this.toolTip1.SetToolTip(this.colorPickerGroupBox, "Choose a color scheme for the notices above.");
            // 
            // yellowRedRadioButton
            // 
            this.yellowRedRadioButton.AutoSize = true;
            this.yellowRedRadioButton.Location = new System.Drawing.Point(7, 92);
            this.yellowRedRadioButton.Name = "yellowRedRadioButton";
            this.yellowRedRadioButton.Size = new System.Drawing.Size(81, 17);
            this.yellowRedRadioButton.TabIndex = 3;
            this.yellowRedRadioButton.TabStop = true;
            this.yellowRedRadioButton.Text = "Yellow/Red";
            this.yellowRedRadioButton.UseVisualStyleBackColor = true;
            this.yellowRedRadioButton.CheckedChanged += new System.EventHandler(this.yellowRedRadioButton_CheckedChanged);
            // 
            // redPinkRadioButton
            // 
            this.redPinkRadioButton.AutoSize = true;
            this.redPinkRadioButton.Location = new System.Drawing.Point(7, 68);
            this.redPinkRadioButton.Name = "redPinkRadioButton";
            this.redPinkRadioButton.Size = new System.Drawing.Size(71, 17);
            this.redPinkRadioButton.TabIndex = 2;
            this.redPinkRadioButton.TabStop = true;
            this.redPinkRadioButton.Text = "Red/Pink";
            this.redPinkRadioButton.UseVisualStyleBackColor = true;
            this.redPinkRadioButton.CheckedChanged += new System.EventHandler(this.redPinkRadioButton_CheckedChanged);
            // 
            // blueWhiteRadioButton
            // 
            this.blueWhiteRadioButton.AutoSize = true;
            this.blueWhiteRadioButton.Location = new System.Drawing.Point(7, 44);
            this.blueWhiteRadioButton.Name = "blueWhiteRadioButton";
            this.blueWhiteRadioButton.Size = new System.Drawing.Size(79, 17);
            this.blueWhiteRadioButton.TabIndex = 1;
            this.blueWhiteRadioButton.TabStop = true;
            this.blueWhiteRadioButton.Text = "Blue/White";
            this.blueWhiteRadioButton.UseVisualStyleBackColor = true;
            this.blueWhiteRadioButton.CheckedChanged += new System.EventHandler(this.blueWhiteRadioButton_CheckedChanged);
            // 
            // blackGrayRadioButton
            // 
            this.blackGrayRadioButton.AutoSize = true;
            this.blackGrayRadioButton.Location = new System.Drawing.Point(7, 20);
            this.blackGrayRadioButton.Name = "blackGrayRadioButton";
            this.blackGrayRadioButton.Size = new System.Drawing.Size(79, 17);
            this.blackGrayRadioButton.TabIndex = 0;
            this.blackGrayRadioButton.TabStop = true;
            this.blackGrayRadioButton.Text = "Black/Gray";
            this.blackGrayRadioButton.UseVisualStyleBackColor = true;
            this.blackGrayRadioButton.CheckedChanged += new System.EventHandler(this.blackGrayRadioButton_CheckedChanged);
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(169, 136);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(287, 18);
            this.hoursLabel.TabIndex = 3;
            this.hoursLabel.Text = "Open 24 Hours a Day, 7 Days a Week";
            this.toolTip1.SetToolTip(this.hoursLabel, "We\'re open 24/7 here!");
            this.hoursLabel.Visible = false;
            // 
            // autoSalesLabel
            // 
            this.autoSalesLabel.AutoSize = true;
            this.autoSalesLabel.Location = new System.Drawing.Point(105, 176);
            this.autoSalesLabel.Name = "autoSalesLabel";
            this.autoSalesLabel.Size = new System.Drawing.Size(58, 13);
            this.autoSalesLabel.TabIndex = 4;
            this.autoSalesLabel.Text = "Auto Sales";
            // 
            // serviceCenterLabel
            // 
            this.serviceCenterLabel.AutoSize = true;
            this.serviceCenterLabel.Location = new System.Drawing.Point(281, 176);
            this.serviceCenterLabel.Name = "serviceCenterLabel";
            this.serviceCenterLabel.Size = new System.Drawing.Size(77, 13);
            this.serviceCenterLabel.TabIndex = 5;
            this.serviceCenterLabel.Text = "Service Center";
            // 
            // detailShopLabel
            // 
            this.detailShopLabel.AutoSize = true;
            this.detailShopLabel.Location = new System.Drawing.Point(105, 262);
            this.detailShopLabel.Name = "detailShopLabel";
            this.detailShopLabel.Size = new System.Drawing.Size(62, 13);
            this.detailShopLabel.TabIndex = 6;
            this.detailShopLabel.Text = "Detail Shop";
            // 
            // employmentOpportunitiesLabel
            // 
            this.employmentOpportunitiesLabel.AutoSize = true;
            this.employmentOpportunitiesLabel.Location = new System.Drawing.Point(255, 262);
            this.employmentOpportunitiesLabel.Name = "employmentOpportunitiesLabel";
            this.employmentOpportunitiesLabel.Size = new System.Drawing.Size(129, 13);
            this.employmentOpportunitiesLabel.TabIndex = 7;
            this.employmentOpportunitiesLabel.Text = "Employment Opportunities";
            // 
            // clearNoticesLabel
            // 
            this.clearNoticesLabel.AutoSize = true;
            this.clearNoticesLabel.Location = new System.Drawing.Point(40, 477);
            this.clearNoticesLabel.Name = "clearNoticesLabel";
            this.clearNoticesLabel.Size = new System.Drawing.Size(108, 13);
            this.clearNoticesLabel.TabIndex = 9;
            this.clearNoticesLabel.Text = "Clear Special Notices";
            // 
            // printPreviewLabel
            // 
            this.printPreviewLabel.AutoSize = true;
            this.printPreviewLabel.Location = new System.Drawing.Point(201, 477);
            this.printPreviewLabel.Name = "printPreviewLabel";
            this.printPreviewLabel.Size = new System.Drawing.Size(54, 13);
            this.printPreviewLabel.TabIndex = 10;
            this.printPreviewLabel.Text = "Print Form";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Location = new System.Drawing.Point(360, 477);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(24, 13);
            this.exitLabel.TabIndex = 11;
            this.exitLabel.Text = "Exit";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(484, 572);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 39;
            this.lineShape2.X2 = 429;
            this.lineShape2.Y1 = 339;
            this.lineShape2.Y2 = 339;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 43;
            this.lineShape1.X2 = 433;
            this.lineShape1.Y1 = 168;
            this.lineShape1.Y2 = 168;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // carCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 572);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.printPreviewLabel);
            this.Controls.Add(this.clearNoticesLabel);
            this.Controls.Add(this.employmentOpportunitiesLabel);
            this.Controls.Add(this.detailShopLabel);
            this.Controls.Add(this.serviceCenterLabel);
            this.Controls.Add(this.autoSalesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.colorPickerGroupBox);
            this.Controls.Add(this.hoursCheckBox);
            this.Controls.Add(this.specialNoticeLabel);
            this.Controls.Add(this.printPictureBox);
            this.Controls.Add(this.clearPictureBox);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.employmentPictureBox);
            this.Controls.Add(this.detailShopPictureBox);
            this.Controls.Add(this.serviceCenterPictureBox);
            this.Controls.Add(this.autoSalesPictureBox);
            this.Controls.Add(this.programmerLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "carCenterForm";
            this.Text = "Christopher\'s Car Center";
            this.Load += new System.EventHandler(this.carCenterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoSalesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailShopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employmentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPictureBox)).EndInit();
            this.colorPickerGroupBox.ResumeLayout(false);
            this.colorPickerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label programmerLabel;
        private System.Windows.Forms.PictureBox autoSalesPictureBox;
        private System.Windows.Forms.PictureBox serviceCenterPictureBox;
        private System.Windows.Forms.PictureBox detailShopPictureBox;
        private System.Windows.Forms.PictureBox employmentPictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox clearPictureBox;
        private System.Windows.Forms.PictureBox printPictureBox;
        private System.Windows.Forms.Label specialNoticeLabel;
        private System.Windows.Forms.CheckBox hoursCheckBox;
        private System.Windows.Forms.GroupBox colorPickerGroupBox;
        private System.Windows.Forms.RadioButton yellowRedRadioButton;
        private System.Windows.Forms.RadioButton redPinkRadioButton;
        private System.Windows.Forms.RadioButton blueWhiteRadioButton;
        private System.Windows.Forms.RadioButton blackGrayRadioButton;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label autoSalesLabel;
        private System.Windows.Forms.Label serviceCenterLabel;
        private System.Windows.Forms.Label detailShopLabel;
        private System.Windows.Forms.Label employmentOpportunitiesLabel;
        private System.Windows.Forms.Label clearNoticesLabel;
        private System.Windows.Forms.Label printPreviewLabel;
        private System.Windows.Forms.Label exitLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

