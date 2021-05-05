
namespace Office_Supplies
{
    partial class officeSupplies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(officeSupplies));
            this.changeAmountLabel = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.tenderedTextBox = new System.Windows.Forms.TextBox();
            this.tendered = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.taxAmountLabel = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.erasers = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.calculateTotalsButton = new System.Windows.Forms.Button();
            this.eraserTextBox = new System.Windows.Forms.TextBox();
            this.penTextBox = new System.Windows.Forms.TextBox();
            this.pens = new System.Windows.Forms.Label();
            this.pencilTextBox = new System.Windows.Forms.TextBox();
            this.pencils = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.Receipt = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.subtotalAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeAmountLabel
            // 
            this.changeAmountLabel.Location = new System.Drawing.Point(183, 303);
            this.changeAmountLabel.Name = "changeAmountLabel";
            this.changeAmountLabel.Size = new System.Drawing.Size(36, 13);
            this.changeAmountLabel.TabIndex = 43;
            this.changeAmountLabel.Text = "$0.00";
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Location = new System.Drawing.Point(9, 303);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(44, 13);
            this.change.TabIndex = 42;
            this.change.Text = "Change";
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.Location = new System.Drawing.Point(34, 265);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(155, 24);
            this.calculateChangeButton.TabIndex = 41;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // tenderedTextBox
            // 
            this.tenderedTextBox.Location = new System.Drawing.Point(105, 239);
            this.tenderedTextBox.Name = "tenderedTextBox";
            this.tenderedTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenderedTextBox.TabIndex = 40;
            // 
            // tendered
            // 
            this.tendered.AutoSize = true;
            this.tendered.Location = new System.Drawing.Point(31, 242);
            this.tendered.Name = "tendered";
            this.tendered.Size = new System.Drawing.Size(53, 13);
            this.tendered.TabIndex = 39;
            this.tendered.Text = "Tendered";
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.Location = new System.Drawing.Point(183, 206);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(36, 13);
            this.totalAmountLabel.TabIndex = 38;
            this.totalAmountLabel.Text = "$0.00";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(9, 206);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(31, 13);
            this.total.TabIndex = 37;
            this.total.Text = "Total";
            // 
            // taxAmountLabel
            // 
            this.taxAmountLabel.Location = new System.Drawing.Point(183, 182);
            this.taxAmountLabel.Name = "taxAmountLabel";
            this.taxAmountLabel.Size = new System.Drawing.Size(36, 13);
            this.taxAmountLabel.TabIndex = 36;
            this.taxAmountLabel.Text = "$0.00";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(9, 182);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(25, 13);
            this.Tax.TabIndex = 35;
            this.Tax.Text = "Tax";
            // 
            // erasers
            // 
            this.erasers.AutoSize = true;
            this.erasers.Location = new System.Drawing.Point(9, 102);
            this.erasers.Name = "erasers";
            this.erasers.Size = new System.Drawing.Size(96, 13);
            this.erasers.TabIndex = 33;
            this.erasers.Text = "Number Of Erasers";
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Location = new System.Drawing.Point(9, 158);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(53, 13);
            this.subTotal.TabIndex = 32;
            this.subTotal.Text = "Sub Total";
            // 
            // calculateTotalsButton
            // 
            this.calculateTotalsButton.Location = new System.Drawing.Point(34, 125);
            this.calculateTotalsButton.Name = "calculateTotalsButton";
            this.calculateTotalsButton.Size = new System.Drawing.Size(155, 24);
            this.calculateTotalsButton.TabIndex = 31;
            this.calculateTotalsButton.Text = "Calculate Totals";
            this.calculateTotalsButton.UseVisualStyleBackColor = true;
            this.calculateTotalsButton.Click += new System.EventHandler(this.calculateTotalsButton_Click);
            // 
            // eraserTextBox
            // 
            this.eraserTextBox.Location = new System.Drawing.Point(119, 99);
            this.eraserTextBox.Name = "eraserTextBox";
            this.eraserTextBox.Size = new System.Drawing.Size(100, 20);
            this.eraserTextBox.TabIndex = 30;
            // 
            // penTextBox
            // 
            this.penTextBox.Location = new System.Drawing.Point(119, 73);
            this.penTextBox.Name = "penTextBox";
            this.penTextBox.Size = new System.Drawing.Size(100, 20);
            this.penTextBox.TabIndex = 29;
            // 
            // pens
            // 
            this.pens.AutoSize = true;
            this.pens.Location = new System.Drawing.Point(9, 76);
            this.pens.Name = "pens";
            this.pens.Size = new System.Drawing.Size(79, 13);
            this.pens.TabIndex = 28;
            this.pens.Text = "Numer Of Pens";
            // 
            // pencilTextBox
            // 
            this.pencilTextBox.Location = new System.Drawing.Point(119, 45);
            this.pencilTextBox.Name = "pencilTextBox";
            this.pencilTextBox.Size = new System.Drawing.Size(100, 20);
            this.pencilTextBox.TabIndex = 27;
            // 
            // pencils
            // 
            this.pencils.AutoSize = true;
            this.pencils.Location = new System.Drawing.Point(9, 48);
            this.pencils.Name = "pencils";
            this.pencils.Size = new System.Drawing.Size(89, 13);
            this.pencils.TabIndex = 26;
            this.pencils.Text = "Numer Of Pencils";
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.Location = new System.Drawing.Point(34, 328);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(155, 24);
            this.printReceiptButton.TabIndex = 25;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(264, 328);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(155, 24);
            this.resetButton.TabIndex = 24;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Receipt
            // 
            this.Receipt.BackColor = System.Drawing.Color.White;
            this.Receipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Receipt.Location = new System.Drawing.Point(235, 45);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(212, 280);
            this.Receipt.TabIndex = 23;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.DarkKhaki;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(-2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(462, 31);
            this.Title.TabIndex = 44;
            this.Title.Text = "   Office Supplies";
            // 
            // subtotalAmountLabel
            // 
            this.subtotalAmountLabel.Location = new System.Drawing.Point(183, 158);
            this.subtotalAmountLabel.Name = "subtotalAmountLabel";
            this.subtotalAmountLabel.Size = new System.Drawing.Size(36, 13);
            this.subtotalAmountLabel.TabIndex = 45;
            this.subtotalAmountLabel.Text = "$0.00";
            // 
            // officeSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 361);
            this.Controls.Add(this.subtotalAmountLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.changeAmountLabel);
            this.Controls.Add(this.change);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.tenderedTextBox);
            this.Controls.Add(this.tendered);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.total);
            this.Controls.Add(this.taxAmountLabel);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.erasers);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.calculateTotalsButton);
            this.Controls.Add(this.eraserTextBox);
            this.Controls.Add(this.penTextBox);
            this.Controls.Add(this.pens);
            this.Controls.Add(this.pencilTextBox);
            this.Controls.Add(this.pencils);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.Receipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "officeSupplies";
            this.Text = "Office Supplies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label changeAmountLabel;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.TextBox tenderedTextBox;
        private System.Windows.Forms.Label tendered;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label taxAmountLabel;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label subTotalAmount;
        private System.Windows.Forms.Label erasers;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Button calculateTotalsButton;
        private System.Windows.Forms.TextBox eraserTextBox;
        private System.Windows.Forms.TextBox penTextBox;
        private System.Windows.Forms.Label pens;
        private System.Windows.Forms.TextBox pencilTextBox;
        private System.Windows.Forms.Label pencils;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label Receipt;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label subtotalAmountLabel;
    }
}

