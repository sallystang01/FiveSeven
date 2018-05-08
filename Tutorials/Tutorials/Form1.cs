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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The NumberUpperCase method accepts a string and returns the number of uppercase letters it contains.

        private int NumberUpperCase(string str)

        {
            int upperCase = 0; // the number of uppercase letters

            // Count the uppercase characters in str.
            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    upperCase++;
                }
            }
            // Return the number of uppercase characters.
            return upperCase;
        }

        // The NumberLowerCase methods accepts a string argument and returns the number of lowercase letters it contains.

        private int NumberLowerCase(string str)
        {
            int lowerCase = 0; // Number of lowercase letters

            // Count the lowercase characters in str
            foreach (char ch in str)
                {
                if (char.IsLower(ch))
                {
                    lowerCase++;
                }
            }
            // Return the number of lowercase characters.
            return lowerCase;
        }

        // The NumberDigits method accepts a string arguement

        // and returns the number of numeric digits it contains.

            private int NumberDigits(string str)
        {
            int digits = -0; // The number of digits
            
            // Count the digits in str.
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }
            }

            // Return the numbers of digits.
            return digits;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckPass_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8; // Password's minimum length

            // Get  the password from the TextBox.
            string password = tbPassword.Text;

            // Validate the password
            if (password.Length >= MIN_LENGTH &&
                NumberUpperCase(password) >= 1 &&
                NumberLowerCase(password) >= 1 &&
                NumberDigits(password) >= 1)
            {
                // This will pop up once the password meets the criteria
                MessageBox.Show("The password is valid.");
            }
            else
            {
                // If the password does not meet the criteria
                MessageBox.Show("The password does not meet " + "the requirements. ");
            }
                }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits application
            this.Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit.ReturnToNav();
        }
    }
        }
    

