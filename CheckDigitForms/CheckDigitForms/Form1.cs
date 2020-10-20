using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckDigitForms
{
    public partial class CheckDigit : Form
    {
        public CheckDigit()
        {
            InitializeComponent();
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            // Define Variables
            string input;
            int inputtedCheckSum;
            int newCheckSum;
            int lastDigit;
            int sumOfDigits = 0;
            int remainder;
            int[] values = new int[13];
            // Take input

            input = TXT_Input.Text;

            // Remove last digit from input 

            // Find last digit
            lastDigit = input.Length - 1;

            int.TryParse(input[lastDigit].ToString(), out inputtedCheckSum);
            input = input.Remove(input.Length - 1, 1);

            // Multiply as necessary (every other num is *3)

            values[0] = int.Parse(input[0].ToString()) * 3;
            values[1] = int.Parse(input[1].ToString());
            values[2] = int.Parse(input[2].ToString()) * 3;
            values[3] = int.Parse(input[3].ToString());
            values[4] = int.Parse(input[4].ToString()) * 3;
            values[5] = int.Parse(input[5].ToString());
            values[6] = int.Parse(input[6].ToString()) * 3;
            values[7] = int.Parse(input[7].ToString());
            values[8] = int.Parse(input[8].ToString()) * 3;
            values[9] = int.Parse(input[9].ToString());
            values[10] = int.Parse(input[10].ToString()) * 3;
            values[11] = int.Parse(input[11].ToString());
            values[12] = 0 * 3;

            for (int i = 0; i < 12; i++)
            {
                sumOfDigits += values[i];
            }
            // x mod 10 = r 
            remainder = sumOfDigits % 10;
            // 10 - r = checkdigit
            newCheckSum = 10 - remainder;

            // Compare to removed digit
            if ( newCheckSum != inputtedCheckSum)
            {
                Console.Beep();
                LBL_Output.Text = "Invalid Check Digit.";
            }
            else
            {
                LBL_Output.Text = "Valid Check Digit";
            }

            // Store in history
            
            LBL_History.Text += "\n " + input; 

        }

        
    }
}
