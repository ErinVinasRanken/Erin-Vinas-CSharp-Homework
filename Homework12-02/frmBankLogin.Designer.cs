namespace Homework12_02
{
    partial class frmBankLogin
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
            lblAccountNumber = new Label();
            lblPinNumber = new Label();
            txtAccountNumber = new TextBox();
            txtPinNumber = new TextBox();
            btnLogin = new Button();
            txtCustomerInformation = new TextBox();
            lblMakeADeposit = new Label();
            lblMakeAWithdrawl = new Label();
            txtMakeADeposit = new TextBox();
            txtMakeAWithdrawl = new TextBox();
            btnLogout = new Button();
            btnDeposit = new Button();
            btnWithdrawl = new Button();
            btnExit = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.BackColor = Color.FromArgb(128, 255, 128);
            lblAccountNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblAccountNumber.Location = new Point(66, 49);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(187, 31);
            lblAccountNumber.TabIndex = 10;
            lblAccountNumber.Text = "Account #:";
            lblAccountNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPinNumber
            // 
            lblPinNumber.BackColor = Color.FromArgb(128, 255, 128);
            lblPinNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblPinNumber.Location = new Point(66, 125);
            lblPinNumber.Name = "lblPinNumber";
            lblPinNumber.Size = new Size(187, 31);
            lblPinNumber.TabIndex = 11;
            lblPinNumber.Text = "Pin #:";
            lblPinNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtAccountNumber.Location = new Point(283, 49);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(233, 38);
            txtAccountNumber.TabIndex = 0;
            txtAccountNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPinNumber
            // 
            txtPinNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtPinNumber.Location = new Point(283, 118);
            txtPinNumber.Name = "txtPinNumber";
            txtPinNumber.Size = new Size(233, 38);
            txtPinNumber.TabIndex = 1;
            txtPinNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnLogin.Location = new Point(584, 88);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 47);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtCustomerInformation
            // 
            txtCustomerInformation.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtCustomerInformation.Location = new Point(66, 197);
            txtCustomerInformation.Multiline = true;
            txtCustomerInformation.Name = "txtCustomerInformation";
            txtCustomerInformation.ReadOnly = true;
            txtCustomerInformation.Size = new Size(665, 147);
            txtCustomerInformation.TabIndex = 9;
            txtCustomerInformation.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMakeADeposit
            // 
            lblMakeADeposit.BackColor = Color.FromArgb(128, 255, 128);
            lblMakeADeposit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblMakeADeposit.Location = new Point(66, 380);
            lblMakeADeposit.Name = "lblMakeADeposit";
            lblMakeADeposit.Size = new Size(356, 31);
            lblMakeADeposit.TabIndex = 12;
            lblMakeADeposit.Text = "Make A Deposit?";
            lblMakeADeposit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMakeAWithdrawl
            // 
            lblMakeAWithdrawl.BackColor = Color.FromArgb(128, 255, 128);
            lblMakeAWithdrawl.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblMakeAWithdrawl.Location = new Point(66, 533);
            lblMakeAWithdrawl.Name = "lblMakeAWithdrawl";
            lblMakeAWithdrawl.Size = new Size(356, 31);
            lblMakeAWithdrawl.TabIndex = 13;
            lblMakeAWithdrawl.Text = "Make A Withdrawl?";
            lblMakeAWithdrawl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMakeADeposit
            // 
            txtMakeADeposit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtMakeADeposit.Location = new Point(66, 432);
            txtMakeADeposit.Name = "txtMakeADeposit";
            txtMakeADeposit.Size = new Size(356, 38);
            txtMakeADeposit.TabIndex = 3;
            txtMakeADeposit.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMakeAWithdrawl
            // 
            txtMakeAWithdrawl.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtMakeAWithdrawl.Location = new Point(66, 597);
            txtMakeAWithdrawl.Name = "txtMakeAWithdrawl";
            txtMakeAWithdrawl.Size = new Size(356, 38);
            txtMakeAWithdrawl.TabIndex = 5;
            txtMakeAWithdrawl.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnLogout.Location = new Point(63, 681);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(147, 47);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "L&ogout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnDeposit.Location = new Point(584, 408);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(147, 47);
            btnDeposit.TabIndex = 4;
            btnDeposit.Text = "&Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdrawl
            // 
            btnWithdrawl.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnWithdrawl.Location = new Point(584, 573);
            btnWithdrawl.Name = "btnWithdrawl";
            btnWithdrawl.Size = new Size(147, 47);
            btnWithdrawl.TabIndex = 6;
            btnWithdrawl.Text = "&Withdrawl";
            btnWithdrawl.UseVisualStyleBackColor = true;
            btnWithdrawl.Click += btnWithdrawl_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(309, 681);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(147, 47);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(584, 681);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(147, 47);
            btnClear.TabIndex = 14;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmBankLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(893, 760);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnWithdrawl);
            Controls.Add(btnDeposit);
            Controls.Add(btnLogout);
            Controls.Add(txtMakeAWithdrawl);
            Controls.Add(txtMakeADeposit);
            Controls.Add(lblMakeAWithdrawl);
            Controls.Add(lblMakeADeposit);
            Controls.Add(txtCustomerInformation);
            Controls.Add(btnLogin);
            Controls.Add(txtPinNumber);
            Controls.Add(txtAccountNumber);
            Controls.Add(lblPinNumber);
            Controls.Add(lblAccountNumber);
            Name = "frmBankLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chapter 12 Homework problem 2 - Bank log in";
            Load += frmBankLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountNumber;
        private Label lblPinNumber;
        private TextBox txtAccountNumber;
        private TextBox txtPinNumber;
        private Button btnLogin;
        private TextBox txtCustomerInformation;
        private Label lblMakeADeposit;
        private Label lblMakeAWithdrawl;
        private TextBox txtMakeADeposit;
        private TextBox txtMakeAWithdrawl;
        private Button btnLogout;
        private Button btnDeposit;
        private Button btnWithdrawl;
        private Button btnExit;
        private Button btnClear;
    }
}
