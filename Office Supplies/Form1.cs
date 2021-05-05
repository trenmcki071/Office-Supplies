using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Office_Supplies
{
    public partial class officeSupplies : Form
    {
        public officeSupplies()
        {
            InitializeComponent();
        }

        double pencilPrice = 0.15;
        double penPrice = 0.50;
        double eraserPrice = 0.25;
        double pencilNumber;
        double penNumber;
        double eraserNumber;
        double subtotalAmount;
        double taxAmount;
        double totalAmount;
        double tenderedAmount;
        double changeAmount;
        int firstButton = 0;
        int secondButton = 0;
        private void calculateTotalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //calculate the subtotal and print it
                pencilNumber = Int32.Parse(pencilTextBox.Text);
                penNumber = Int32.Parse(penTextBox.Text);
                eraserNumber = Int32.Parse(eraserTextBox.Text);
                subtotalAmount = (pencilNumber * pencilPrice) + (penNumber * penPrice) + (eraserNumber * eraserPrice);
                subtotalAmountLabel.Text = $"${subtotalAmount}";

                //calculate the tax and print it
                taxAmount = subtotalAmount * 0.13;
                taxAmountLabel.Text = $"${taxAmount}";

                //calcuate the total and print it
                totalAmount = subtotalAmount + taxAmount;
                totalAmountLabel.Text = $"${totalAmount}";

                //makes it so the first button is shown to be pressed
                firstButton = 1;

                //if something wrong is entered into a textbox then is corrected, gets rid of message
                Receipt.Text = "";
            }
            //if something wrong is entered into a text box
            catch { Receipt.Text = "Enter a number Value"; }
          
        }

        
        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //only runs if the first button has been pressed
                if (firstButton == 1)
                {
                    //calculate the change and print it
                    tenderedAmount = Int32.Parse(tenderedTextBox.Text);
                    changeAmount = tenderedAmount - totalAmount;
                    changeAmountLabel.Text = $"${changeAmount}";

                    //makes it so the second button is shown to be pressed
                    secondButton = 1;

                    //if something wrong is entered into a textbox then is corrected, gets rid of message
                    Receipt.Text = "";
                }
            }
            //if something wrong is entered into a textbox
            catch { Receipt.Text = "Enter a number value"; }
            
        }
    
        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            //only runs if the second button has been pressed
            if (secondButton == 1)
            {
                //print receipt
                Receipt.Text = $"\n\n                Office Supplies Receipt \n\n   Order Number: {pencilNumber}{eraserNumber}{penNumber}1 \n   Date: 2021-05-05 \n\n   Pencils:   x{pencilNumber}  @  ${pencilPrice} \n   Pens:      x{penNumber}  @  ${penPrice} \n   Erasers:  x{eraserNumber}  @  ${eraserPrice} \n\n   Sub Total:          ${subtotalAmount} \n   Tax:                   ${taxAmount} \n   Total:                 ${totalAmount} \n\n   Tendered:          ${tenderedAmount} \n   Change:             ${changeAmount}";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //reset variables and labels
            Receipt.Text = "";
            pencilTextBox.Text = "";
            penTextBox.Text = "";
            eraserTextBox.Text = "";
            tenderedTextBox.Text = "";
            totalAmountLabel.Text = "$0.00";
            taxAmountLabel.Text = "$0.00";
            subtotalAmountLabel.Text = "$0.00";
            changeAmountLabel.Text = "$0.00";
            pencilNumber = 0;
            penNumber = 0;
            eraserNumber = 0;
            tenderedAmount = 0;
            subtotalAmount = 0;
            totalAmount = 0;
            taxAmount = 0;
            changeAmount = 0;
        }
    }
}
