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

namespace Tutorials
{
    public partial class TestAverages : Form
    {
        public TestAverages()
        {
            InitializeComponent();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile; // To read the files
                string line;            // To hold a line from 
                int count = 0;          // Student counter
                int total;              // Accumulator
                double average;         // Test score average

                // Create a delimiter array.
                char[] delim = { ',' };

                // Open the CSV file.
                inputFile = File.OpenText("Grades.csv");

                while (!inputFile.EndOfStream)
                {
                    // Increment the student counter.
                    count++;

                    // Read a line from the file
                    line = inputFile.ReadLine();

                    // Get the test scores as tokens.
                    string[] tokens = line.Split(delim);

                    // Set the accumulator to 0.
                    total = 0;

                    // Calculate the total of the
                    // test score tokens.
                    foreach (string str in tokens)
                    {
                        total += int.Parse(str);
                    }

                    // Calculate the average of these
                    // test scores.
                    average = (double)total / tokens.Length;

                    // Display the average 
                    lbScores.Items.Add("The average for student " + count + " is " + average.ToString("n1"));

                }

                // Close the file
                inputFile.Close();

            }

            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show(ex.Message);
            }
                
            }

        private void TestAverages_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit.ReturnToNav();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

