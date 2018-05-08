using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorials
{
    public partial class TelephoneFormat : Form
    {
        public TelephoneFormat()
        {
            InitializeComponent();
        }

        private bool IsValidNumber(string str)
        {
            const int VALID_LENGTH = 10; // Length of a valid string
            bool valid = true; // Flag to indicate validtiy

            // Check the string's length.
            if (str.Length == VALID_LENGTH)
            {
                // Check ejach charcater in str.
                foreach (char ch in str)
                {
                    // If this charachter is not a digit. The 
                    // string is not valid.
                    if (!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                }
            }

            else
            {
                // Incorrect length.
                valid = false;
            }

            // Return the status.
            return valid;

        }

        // The TelephoneFormat mwethod accepts a string arguement
        // by reference and formats it as a telephone number.

        private void TelephoneFormatMethod (ref string str)
        {
            // First, insert the left paren at position 0.
            str = str.Insert(0, "(");

            // Next, insert the right paron at position 4.
            str = str.Insert(4, ")");

            // Next, insert the hyphen at positon 8.
            str = str.Insert(8, "-");

        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            // Get a trimmed copy of the user's input.
            string input = tbNumber.Text.Trim();

            // If the input is a valid number, format it
            // and display it.
            if (IsValidNumber(input))
            {
                TelephoneFormatMethod(ref input);
                MessageBox.Show(input);
            }
            else
            {
                // Display an error message
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
            
        
        }

        private void TelephoneFormat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit.ReturnToNav();
        }
    }
}
