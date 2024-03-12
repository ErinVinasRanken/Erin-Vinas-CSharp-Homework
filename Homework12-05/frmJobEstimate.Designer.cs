namespace Homework12_05
{
    partial class frmJobEstimate
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
            lblNewValue = new Label();
            lblCurrentValue = new Label();
            lblDescription = new Label();
            lblHoursToComplete = new Label();
            lblHourlyRate = new Label();
            lblTotalFee = new Label();
            lblResults = new Label();
            txtDescription = new TextBox();
            txtHoursToComplete = new TextBox();
            txtHourlyRate = new TextBox();
            btnUpdate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblNewValue
            // 
            lblNewValue.BackColor = Color.FromArgb(255, 192, 255);
            lblNewValue.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNewValue.Location = new Point(317, 54);
            lblNewValue.Name = "lblNewValue";
            lblNewValue.Size = new Size(236, 32);
            lblNewValue.TabIndex = 12;
            lblNewValue.Text = "New Value";
            lblNewValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentValue
            // 
            lblCurrentValue.BackColor = Color.FromArgb(255, 192, 255);
            lblCurrentValue.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCurrentValue.Location = new Point(644, 54);
            lblCurrentValue.Name = "lblCurrentValue";
            lblCurrentValue.Size = new Size(191, 32);
            lblCurrentValue.TabIndex = 13;
            lblCurrentValue.Text = "Current Value";
            lblCurrentValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.FromArgb(255, 192, 255);
            lblDescription.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblDescription.Location = new Point(35, 136);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(229, 32);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description:";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoursToComplete
            // 
            lblHoursToComplete.BackColor = Color.FromArgb(255, 192, 255);
            lblHoursToComplete.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHoursToComplete.Location = new Point(35, 231);
            lblHoursToComplete.Name = "lblHoursToComplete";
            lblHoursToComplete.Size = new Size(229, 32);
            lblHoursToComplete.TabIndex = 9;
            lblHoursToComplete.Text = "Hours To Complete:";
            lblHoursToComplete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHourlyRate
            // 
            lblHourlyRate.BackColor = Color.FromArgb(255, 192, 255);
            lblHourlyRate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHourlyRate.Location = new Point(35, 334);
            lblHourlyRate.Name = "lblHourlyRate";
            lblHourlyRate.Size = new Size(229, 32);
            lblHourlyRate.TabIndex = 10;
            lblHourlyRate.Text = "Hourly Rate:";
            lblHourlyRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalFee
            // 
            lblTotalFee.BackColor = Color.FromArgb(255, 192, 255);
            lblTotalFee.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblTotalFee.Location = new Point(35, 435);
            lblTotalFee.Name = "lblTotalFee";
            lblTotalFee.Size = new Size(229, 32);
            lblTotalFee.TabIndex = 11;
            lblTotalFee.Text = "Total Fee:";
            lblTotalFee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            lblResults.BackColor = Color.FromArgb(255, 192, 255);
            lblResults.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblResults.Location = new Point(644, 136);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(191, 337);
            lblResults.TabIndex = 7;
            lblResults.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtDescription.Location = new Point(317, 136);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(236, 38);
            txtDescription.TabIndex = 0;
            txtDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHoursToComplete
            // 
            txtHoursToComplete.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtHoursToComplete.Location = new Point(317, 231);
            txtHoursToComplete.Name = "txtHoursToComplete";
            txtHoursToComplete.Size = new Size(236, 38);
            txtHoursToComplete.TabIndex = 1;
            txtHoursToComplete.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtHourlyRate.Location = new Point(317, 334);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(236, 38);
            txtHourlyRate.TabIndex = 2;
            txtHourlyRate.TextAlign = HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnUpdate.Location = new Point(67, 512);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 42);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(373, 512);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(143, 42);
            btnClear.TabIndex = 4;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(671, 512);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(143, 42);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmJobEstimate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(947, 607);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(txtHourlyRate);
            Controls.Add(txtHoursToComplete);
            Controls.Add(txtDescription);
            Controls.Add(lblResults);
            Controls.Add(lblTotalFee);
            Controls.Add(lblHourlyRate);
            Controls.Add(lblHoursToComplete);
            Controls.Add(lblDescription);
            Controls.Add(lblCurrentValue);
            Controls.Add(lblNewValue);
            Name = "frmJobEstimate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Harolds Home Services";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewValue;
        private Label lblCurrentValue;
        private Label lblDescription;
        private Label lblHoursToComplete;
        private Label lblHourlyRate;
        private Label lblTotalFee;
        private Label lblResults;
        private TextBox txtDescription;
        private TextBox txtHoursToComplete;
        private TextBox txtHourlyRate;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnExit;
    }
}
