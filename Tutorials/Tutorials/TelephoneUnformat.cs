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
    public partial class TelephoneUnformat : Form
    {
        public TelephoneUnformat()
        {
            InitializeComponent();
        }

        private void TelephoneUnformat_FormClosing(object sender, FormClosingEventArgs e)
        {

            Exit.ReturnToNav();
            
        }

        // This IsValidFormat method accepts a string argument
        // and determines whehter it\ is properly formatted as
        // a US telephone number in the following manner:
        // (XXX)XXX-XXXX
        // If the argument is properly formatted, the method
        // returns true, otherwise false.

        private bool IsValidFormat(string str)
        {
            const int VALID_LENGTH = 13; // Length of a valid string
            bool valid; // Flag to indicate validity

            // Determine whether str is properly formatted.
            if (str.Length == VALID_LENGTH && str[0] == '(' &&
                str[4] == ')' && str[8] == '-')
            {
                valid = true;
            }

            else
            {
                valid = false;
            }

            // Return the value of valid
            return valid;
                }

        // The unformat method accepts a string, by reference,
        // assumed to contain a tele number formatted in
        // this manner: (XXX)XXX-XXXX
        // The method unformats the string removing the 
        // parentheses and the hyphen.

        private void Unformat(ref string str)
        {
            // First, delete the left paren at position 0.
            str = str.Remove(0, 1);

            // Next, delete the right paren. Because of the 
            // previous deletion it is now located at
            // position 3.
            str = str.Remove(3, 1);

            // Next, delete the hyphen. BEcause of the
            // previous deletions it is now located at
            // position 6.
            str = str.Remove(6, 1);

        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            // Get a trimmed copy of the user's input.
            string input = tbNumber.Text.Trim();

            // If the input is properly formatted, unformat it
            // and display it.
            if (IsValidFormat(input))
            {
                Unformat(ref input);
                MessageBox.Show(input);
            }
            else
            {
                // Display an error message.
                MessageBox.Show("invalid input");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
