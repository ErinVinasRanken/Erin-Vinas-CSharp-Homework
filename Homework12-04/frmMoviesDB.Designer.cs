namespace Homework12_04
{
    partial class frmMoviesDB
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblResults = new Label();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtSearch.Location = new Point(23, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(689, 38);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnSearch.Location = new Point(740, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 40);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(740, 382);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 40);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(740, 670);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 40);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResults
            // 
            lblResults.BackColor = Color.FromArgb(128, 128, 255);
            lblResults.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblResults.Location = new Point(23, 110);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(689, 600);
            lblResults.TabIndex = 4;
            // 
            // frmMoviesDB
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            CancelButton = btnClear;
            ClientSize = new Size(973, 760);
            Controls.Add(lblResults);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "frmMoviesDB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Database";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
        private Button btnExit;
        private Label lblResults;
    }
}
