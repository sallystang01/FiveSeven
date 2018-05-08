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
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();

            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelephoneFormat frmTele = new TelephoneFormat();

            frmTele.Show();
        }

        private void Navigation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelephoneUnformat frmUnForm = new TelephoneUnformat();

            this.Hide();
            frmUnForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestAverages frmTest = new TestAverages();

            frmTest.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
