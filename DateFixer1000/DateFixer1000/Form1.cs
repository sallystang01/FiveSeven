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
        string filePath;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            string path = "C:\\..FiveSeven";
            

            open.Filter = "CSV Files| *.csv| Text Files (*.txt) | *.txt| All Files (*.*)|*.*";
            open.Title = "Select a file to continue";
            open.InitialDirectory = path;
            open.CheckFileExists = true;
            open.CheckPathExists = true;

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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
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
                int count = 0; //line counter

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


                    //increment the line counter
                    count++;
                }
                //close the file
                inputFile.Close();
                lblPath.Text = count + " lines processed.";
            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
