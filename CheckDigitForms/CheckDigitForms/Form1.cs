using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CheckDigitForms
{
    public partial class CheckDigit : Form
    {
        public CheckDigit()
        {
            InitializeComponent();
            LBL_History.Text = "History: ";
            
            LBL_Output.Text = null;
        }
        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Define Variables
                string input;
                int inputtedCheckSum;
                int lastDigit;
                // Take input
                input = TXT_Input.Text;
                // Remove last digit from input 
                // Find last digit
                lastDigit = input.Length - 1;
                int.TryParse(input[lastDigit].ToString(), out inputtedCheckSum);
                input = input.Remove(input.Length - 1, 1);
                // Compare to removed digit
                Console.Beep();
                if (CalcualteCheckDigit(input) != inputtedCheckSum)
                {
                    LBL_Output.Text = "Invalid Check Digit.";
                }
                else
                {
                    LBL_Output.Text = "Valid Check Digit";
                }
                // Store in history
                LBL_History.Text += "\n " + input + inputtedCheckSum;
            }
            catch
            {
                ErrorMessage();
            }
        }
        private void BTN_GenerateCheckDigit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_Input.TextLength < 13)
                {
                    LBL_Output.Text = "Check Digit = " + CalcualteCheckDigit(TXT_Input.Text).ToString();

                    // Store in History 
                    LBL_History.ForeColor = Color.Red;
                    LBL_History.Text += "\nCalculation: " + TXT_Input.Text + "  " + CalcualteCheckDigit(TXT_Input.Text);
                    LBL_History.ForeColor = Color.Black;
                }
                else
                {
                    ErrorMessage();
                }
            }
            catch
            {
                ErrorMessage();
            }
        }
        private int CalcualteCheckDigit(string ean)
        {
            int[] values = new int[12];
            int sumOfDigits = 0;
            int checkDigit;

            values[0] = int.Parse(ean[0].ToString());
            values[1] = int.Parse(ean[1].ToString()) * 3;
            values[2] = int.Parse(ean[2].ToString());
            values[3] = int.Parse(ean[3].ToString()) * 3;
            values[4] = int.Parse(ean[4].ToString());
            values[5] = int.Parse(ean[5].ToString()) * 3;
            values[6] = int.Parse(ean[6].ToString());
            values[7] = int.Parse(ean[7].ToString()) * 3;
            values[8] = int.Parse(ean[8].ToString());
            values[9] = int.Parse(ean[9].ToString()) * 3;
            values[10] = int.Parse(ean[10].ToString());
            values[11] = int.Parse(ean[11].ToString()) * 3;

            for (int i = 0; i < 12; i++)
            {
                sumOfDigits += values[i];
            }

            
            checkDigit = 10 - (sumOfDigits % 10);

            if (checkDigit >= 10)
            {
                checkDigit = 0;
            }

            return checkDigit;
        }
        private void ErrorMessage()
        {
            Console.Beep();
            Console.Beep();
            LBL_Output.Text = "ERROR, INVALID INPUT.";
        }
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            LBL_History.Text = "History:";
        }
    }
}
