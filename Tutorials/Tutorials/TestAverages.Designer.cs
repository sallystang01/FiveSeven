namespace Tutorials
{
    partial class TestAverages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbScores = new System.Windows.Forms.ListBox();
            this.btnScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbScores
            // 
            this.lbScores.FormattingEnabled = true;
            this.lbScores.Location = new System.Drawing.Point(12, 24);
            this.lbScores.Name = "lbScores";
            this.lbScores.Size = new System.Drawing.Size(260, 147);
            this.lbScores.TabIndex = 0;
            // 
            // btnScores
            // 
            this.btnScores.Location = new System.Drawing.Point(54, 214);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(75, 23);
            this.btnScores.TabIndex = 1;
            this.btnScores.Text = "Get Scores";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(149, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TestAverages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.lbScores);
            this.Name = "TestAverages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestAverages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestAverages_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbScores;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Button btnExit;
    }
}