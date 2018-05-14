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

namespace DateFixer1000
{
    public partial class DateFixer1000 : Form
    {
        public DateFixer1000()
        {
            InitializeComponent();
        }
        // declares the file path variable
        string filePath;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Initializes the path that the open dialog will start
            OpenFileDialog open = new OpenFileDialog();
            string path = "C:\\..FiveSeven";
            
            // Filters for CSV, TXT files
            open.Filter = "CSV Files| *.csv| Text Files (*.txt) | *.txt| All Files (*.*)|*.*";
            open.Title = "Select a file to continue";
            open.InitialDirectory = path;
            open.CheckFileExists = true;
            open.CheckPathExists = true;

            // If OK is cliked, do this
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblPath.Text = open.FileName;
                filePath = lblPath.Text.ToString();
                btnOpen.Visible = false;
                btnLoad.Visible = true;
            }
        }

        private void DateFixer1000_Load(object sender, EventArgs e)
        {

        }

        

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                btnLoad.Visible = false;
                
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgMembers);
                dgMembers.ColumnCount = 6;
                dgMembers.Columns[0].Name = "First Name";
                dgMembers.Columns[1].Name = "Last Name";
                dgMembers.Columns[2].Name = "Birth Date";
                dgMembers.Columns[3].Name = "City";
                dgMembers.Columns[4].Name = "State";
                dgMembers.Columns[5].Name = "Join Date";


                StreamReader inputFile; //to read the file
                string line; //to hold a line from the file
                int i = 0; //line counter

                //create a delimiter array
                char[] delim = { ',' };

                //open the csv file

                inputFile = File.OpenText(filePath);

                //sam is awesome

                while (!inputFile.EndOfStream)
                {
                    //read a line from the file.
                    line = inputFile.ReadLine();

                    //get the test scores as tokens
                    string[] tokens = line.Split(delim);

                    //dgMembers.DataSource = tokens;

                    dgMembers.Rows.Add(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5]);


                    //Increments the ier
                    i++;
                }
                ///Closes the file
                inputFile.Close();
                btnFix.Visible = true;
                lblPath.Text = i + " results found.";
            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            
            try
            {
                

                dgMembers.Rows.Clear();

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgMembers);
                dgMembers.ColumnCount = 6;
                dgMembers.Columns[0].Name = "First Name";
                dgMembers.Columns[1].Name = "Last Name";
                dgMembers.Columns[2].Name = "Birth Date";
                dgMembers.Columns[3].Name = "City";
                dgMembers.Columns[4].Name = "Province";
                dgMembers.Columns[5].Name = "Join Date";


                StreamReader inputFile; //to read the file
                string line; //to hold a line from the file
                int count = 0; //line counter

                //create a delimiter array
                char[] delim = { ',' };


                //open the csv file

                inputFile = File.OpenText(filePath);
                StreamWriter OutputFile = new StreamWriter("ConvertedDates.CSV");



                while (!inputFile.EndOfStream)
                {
                    //read a line from the file.
                    line = inputFile.ReadLine();
                    line = line.Replace(".", "/");
                    line = line.Replace("-", "/");


                    // Reads each column as a token
                    string[] tokens = line.Split(delim);


                    // Formats the birthdate to the correct way
                    string date = tokens[2];

                    date = date.Replace("Jan", "1");
                    date = date.Replace("Feb", "2");
                    date = date.Replace("Mar", "3");
                    date = date.Replace("Apr", "4");
                    date = date.Replace("May", "5");
                    date = date.Replace("Jun", "6");
                    date = date.Replace("Jul", "7");
                    date = date.Replace("Aug", "8");
                    date = date.Replace("Sep", "9");
                    date = date.Replace("Oct", "10");
                    date = date.Replace("Nov", "11");
                    date = date.Replace("Dec", "12");


                    string temp = "";
                    string[] dateparts = date.Split('/');

                    // If month name, change to numeric value
                    if (int.Parse(dateparts[0]) > 12)
                    {
                        //switch the dates around
                        temp = dateparts[1];
                        dateparts[1] = dateparts[0];
                        dateparts[0] = temp;
                    }

                    if (int.Parse(dateparts[2]) < 1000)
                    {

                        dateparts[2] = "19" + dateparts[2];
                    }

                    if (dateparts[0].Contains("0"))
                    {
                        if (int.Parse(dateparts[0]) < 10)
                        {
                            dateparts[0].Replace("0", "");
                        }
                    }



                    tokens[2] = dateparts[0] + "/" + dateparts[1] + "/" + dateparts[2];

                    //next comes the join date

                    //splits the joindate into 3 parts: MM DD & YY or YYYY
                    string date2 = tokens[5];

                    date2 = date2.Replace("Jan", "1");
                    date2 = date2.Replace("Feb", "2");
                    date2 = date2.Replace("Mar", "3");
                    date2 = date2.Replace("Apr", "4");
                    date2 = date2.Replace("May", "5");
                    date2 = date2.Replace("Jun", "6");
                    date2 = date2.Replace("Jul", "7");
                    date2 = date2.Replace("Aug", "8");
                    date2 = date2.Replace("Sep", "9");
                    date2 = date2.Replace("Oct", "10");
                    date2 = date2.Replace("Nov", "11");
                    date2 = date2.Replace("Dec", "12");


                    string temp2 = "";
                    string[] dateparts2 = date2.Split('/');

                    //if month is abbreviated, switch with numeric value




                    if (int.Parse(dateparts2[0]) > 12)
                    {
                        //switch the dates around
                        temp2 = dateparts2[1];
                        dateparts2[1] = dateparts2[0];
                        dateparts2[0] = temp2;
                    }

                    if (int.Parse(dateparts2[2]) < 1000)
                    {

                        dateparts2[2] = "19" + dateparts2[2];
                    }


                    if (dateparts2[0].Contains("0"))
                    {
                        if (int.Parse(dateparts2[0]) < 10)
                        {
                            dateparts2[0] = dateparts2[0].Replace(@"0", "");
                        }
                    }

                    if (dateparts2[1].Contains("0"))
                    {
                        if (int.Parse(dateparts2[1]) < 10)
                        {
                            dateparts2[1] = dateparts2[1].Replace(@"0", "");

                        }
                    }


                    tokens[5] = dateparts2[0] + "/" + dateparts2[1] + "/" + dateparts2[2];



                    dgMembers.Rows.Add(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5]);

                    OutputFile.WriteLine(tokens[0] + "," + tokens[1] + "," + tokens[2] + "," + tokens[3] + "," + tokens[4] + "," + tokens[5]);



                    //increment the line counter
                    count++;
                }
                //close the file
                inputFile.Close();



               lblPath.Text = "Processing Complete!";
            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

    }
}

