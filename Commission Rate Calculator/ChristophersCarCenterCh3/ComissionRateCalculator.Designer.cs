namespace ChristophersCarCenterCh3
{
    partial class commissionRateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(commissionRateForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.commissionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.commissionTextBox = new System.Windows.Forms.TextBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(27, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(106, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Salesperson\'s &Name:";
            this.toolTip1.SetToolTip(this.nameLabel, "Enter salesperson\'s name");
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(139, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(214, 20);
            this.nameTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.nameTextBox, "Enter salesperson\'s name");
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(139, 77);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.priceTextBox, "Enter selling price");
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(65, 82);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(68, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Selling P&rice:";
            this.toolTip1.SetToolTip(this.priceLabel, "Enter selling price");
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(139, 128);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.valueTextBox, "Enter cost value");
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(72, 131);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(61, 13);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost &Value:";
            this.toolTip1.SetToolTip(this.costLabel, "Enter cost value");
            // 
            // commissionLabel
            // 
            this.commissionLabel.AutoSize = true;
            this.commissionLabel.Location = new System.Drawing.Point(29, 209);
            this.commissionLabel.Name = "commissionLabel";
            this.commissionLabel.Size = new System.Drawing.Size(104, 13);
            this.commissionLabel.TabIndex = 6;
            this.commissionLabel.Text = "Commission &Amount:";
            this.toolTip1.SetToolTip(this.commissionLabel, "Displays commission amount");
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(35, 264);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Ca&lculate";
            this.toolTip1.SetToolTip(this.calculateButton, "Click to calculate commission");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(116, 264);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.clearButton, "Click to clear form");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(197, 264);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 5;
            this.printButton.Text = "&Print";
            this.toolTip1.SetToolTip(this.printButton, "Click to print form");
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(278, 264);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton, "Click to exit form");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // commissionTextBox
            // 
            this.commissionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.commissionTextBox.Location = new System.Drawing.Point(139, 206);
            this.commissionTextBox.Name = "commissionTextBox";
            this.commissionTextBox.ReadOnly = true;
            this.commissionTextBox.Size = new System.Drawing.Size(100, 20);
            this.commissionTextBox.TabIndex = 20;
            this.commissionTextBox.TabStop = false;
            this.toolTip1.SetToolTip(this.commissionTextBox, "Displays commission amount");
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(384, 312);
            this.shapeContainer1.TabIndex = 21;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 12;
            this.lineShape1.X2 = 367;
            this.lineShape1.Y1 = 164;
            this.lineShape1.Y2 = 164;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 13;
            this.lineShape2.X2 = 368;
            this.lineShape2.Y1 = 192;
            this.lineShape2.Y2 = 192;
            // 
            // commissionRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 312);
            this.Controls.Add(this.commissionTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.commissionLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "commissionRateForm";
            this.Text = "Commission Rate Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label commissionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox commissionTextBox;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}

