namespace Homework14_16_03
{
    partial class Form1
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
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblPinNumber = new System.Windows.Forms.Label();
            this.lblDepsoit = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtPinNumber = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAccountNumber.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(51, 54);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(141, 34);
            this.lblAccountNumber.TabIndex = 9;
            this.lblAccountNumber.Text = "Account #:";
            this.lblAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPinNumber
            // 
            this.lblPinNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPinNumber.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinNumber.Location = new System.Drawing.Point(54, 138);
            this.lblPinNumber.Name = "lblPinNumber";
            this.lblPinNumber.Size = new System.Drawing.Size(141, 34);
            this.lblPinNumber.TabIndex = 10;
            this.lblPinNumber.Text = "Pin #:";
            this.lblPinNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepsoit
            // 
            this.lblDepsoit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblDepsoit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepsoit.Location = new System.Drawing.Point(54, 369);
            this.lblDepsoit.Name = "lblDepsoit";
            this.lblDepsoit.Size = new System.Drawing.Size(596, 34);
            this.lblDepsoit.TabIndex = 12;
            this.lblDepsoit.Text = "Would You Like To Make A Deposit?";
            this.lblDepsoit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblWithdraw.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdraw.Location = new System.Drawing.Point(54, 488);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(596, 34);
            this.lblWithdraw.TabIndex = 13;
            this.lblWithdraw.Text = "Would You Like To Make A Withdrawl?";
            this.lblWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblResults.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(54, 209);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(596, 121);
            this.lblResults.TabIndex = 11;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(222, 50);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(278, 38);
            this.txtAccountNumber.TabIndex = 0;
            this.txtAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPinNumber
            // 
            this.txtPinNumber.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinNumber.Location = new System.Drawing.Point(222, 138);
            this.txtPinNumber.Name = "txtPinNumber";
            this.txtPinNumber.Size = new System.Drawing.Size(278, 38);
            this.txtPinNumber.TabIndex = 1;
            this.txtPinNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(57, 425);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(393, 38);
            this.txtDeposit.TabIndex = 2;
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithdraw.Location = new System.Drawing.Point(57, 548);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(393, 38);
            this.txtWithdraw.TabIndex = 3;
            this.txtWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(580, 83);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 41);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(519, 425);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(131, 41);
            this.btnDeposit.TabIndex = 5;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(519, 548);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(131, 41);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(259, 623);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(191, 41);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print Statement";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(297, 702);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 41);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(775, 770);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtPinNumber);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.lblDepsoit);
            this.Controls.Add(this.lblPinNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblPinNumber;
        private System.Windows.Forms.Label lblDepsoit;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtPinNumber;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnLogout;
    }
}

