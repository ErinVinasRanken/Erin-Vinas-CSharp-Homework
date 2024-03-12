namespace Homework12_03
{
    partial class frmGameBreak
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
            lblGameName = new Label();
            btnSearch = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblGamePublisher = new Label();
            lblGamePrice = new Label();
            txtGameName = new TextBox();
            txtGamePublisher = new TextBox();
            txtGamePrice = new TextBox();
            txtSearchTerm = new TextBox();
            lblSearchTerm = new Label();
            SuspendLayout();
            // 
            // lblGameName
            // 
            lblGameName.BackColor = Color.FromArgb(255, 255, 128);
            lblGameName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblGameName.Location = new Point(47, 168);
            lblGameName.Name = "lblGameName";
            lblGameName.Size = new Size(295, 35);
            lblGameName.TabIndex = 0;
            lblGameName.Text = "Game Name:";
            lblGameName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnSearch.Location = new Point(41, 570);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(144, 48);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(322, 570);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 48);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(606, 570);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(144, 48);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblGamePublisher
            // 
            lblGamePublisher.BackColor = Color.FromArgb(255, 255, 128);
            lblGamePublisher.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblGamePublisher.Location = new Point(47, 301);
            lblGamePublisher.Name = "lblGamePublisher";
            lblGamePublisher.Size = new Size(295, 35);
            lblGamePublisher.TabIndex = 4;
            lblGamePublisher.Text = "Game Publisher:";
            lblGamePublisher.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGamePrice
            // 
            lblGamePrice.BackColor = Color.FromArgb(255, 255, 128);
            lblGamePrice.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblGamePrice.Location = new Point(47, 447);
            lblGamePrice.Name = "lblGamePrice";
            lblGamePrice.Size = new Size(295, 35);
            lblGamePrice.TabIndex = 5;
            lblGamePrice.Text = "Game Price:";
            lblGamePrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGameName
            // 
            txtGameName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtGameName.Location = new Point(387, 168);
            txtGameName.Name = "txtGameName";
            txtGameName.ReadOnly = true;
            txtGameName.Size = new Size(363, 38);
            txtGameName.TabIndex = 7;
            txtGameName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGamePublisher
            // 
            txtGamePublisher.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtGamePublisher.Location = new Point(387, 301);
            txtGamePublisher.Name = "txtGamePublisher";
            txtGamePublisher.ReadOnly = true;
            txtGamePublisher.Size = new Size(363, 38);
            txtGamePublisher.TabIndex = 8;
            txtGamePublisher.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGamePrice
            // 
            txtGamePrice.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtGamePrice.Location = new Point(387, 447);
            txtGamePrice.Name = "txtGamePrice";
            txtGamePrice.ReadOnly = true;
            txtGamePrice.Size = new Size(363, 38);
            txtGamePrice.TabIndex = 9;
            txtGamePrice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtSearchTerm.Location = new Point(387, 47);
            txtSearchTerm.Name = "txtSearchTerm";
            txtSearchTerm.Size = new Size(363, 38);
            txtSearchTerm.TabIndex = 11;
            txtSearchTerm.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSearchTerm
            // 
            lblSearchTerm.BackColor = Color.FromArgb(255, 255, 128);
            lblSearchTerm.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblSearchTerm.Location = new Point(47, 47);
            lblSearchTerm.Name = "lblSearchTerm";
            lblSearchTerm.Size = new Size(295, 35);
            lblSearchTerm.TabIndex = 10;
            lblSearchTerm.Text = "Search Term:";
            lblSearchTerm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmGameBreak
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            CancelButton = btnClear;
            ClientSize = new Size(834, 711);
            Controls.Add(txtSearchTerm);
            Controls.Add(lblSearchTerm);
            Controls.Add(txtGamePrice);
            Controls.Add(txtGamePublisher);
            Controls.Add(txtGameName);
            Controls.Add(lblGamePrice);
            Controls.Add(lblGamePublisher);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(lblGameName);
            Name = "frmGameBreak";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chapter 12 Homework Problem #3 - Game Break";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGameName;
        private Button btnSearch;
        private Button btnClear;
        private Button btnExit;
        private Label lblGamePublisher;
        private Label lblGamePrice;
        private TextBox txtGameName;
        private TextBox txtGamePublisher;
        private TextBox txtGamePrice;
        private TextBox txtSearchTerm;
        private Label lblSearchTerm;
    }
}
