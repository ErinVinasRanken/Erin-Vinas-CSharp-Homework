namespace CollegeAdmission
{
    partial class frmCollegeAdmission
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
            this.btnAdmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblAdmissionTestScore = new System.Windows.Forms.Label();
            this.lblAcceptOrReject = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtAdmissionTestScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdmit
            // 
            this.btnAdmit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmit.Location = new System.Drawing.Point(62, 317);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(132, 50);
            this.btnAdmit.TabIndex = 2;
            this.btnAdmit.Text = "&Admit";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(455, 317);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(617, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGPA
            // 
            this.lblGPA.BackColor = System.Drawing.Color.Lime;
            this.lblGPA.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.Location = new System.Drawing.Point(163, 98);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(161, 39);
            this.lblGPA.TabIndex = 6;
            this.lblGPA.Text = "GPA:";
            this.lblGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdmissionTestScore
            // 
            this.lblAdmissionTestScore.BackColor = System.Drawing.Color.Lime;
            this.lblAdmissionTestScore.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionTestScore.Location = new System.Drawing.Point(452, 98);
            this.lblAdmissionTestScore.Name = "lblAdmissionTestScore";
            this.lblAdmissionTestScore.Size = new System.Drawing.Size(161, 39);
            this.lblAdmissionTestScore.TabIndex = 7;
            this.lblAdmissionTestScore.Text = "ATS:";
            this.lblAdmissionTestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcceptOrReject
            // 
            this.lblAcceptOrReject.BackColor = System.Drawing.Color.Lime;
            this.lblAcceptOrReject.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptOrReject.Location = new System.Drawing.Point(255, 317);
            this.lblAcceptOrReject.Name = "lblAcceptOrReject";
            this.lblAcceptOrReject.Size = new System.Drawing.Size(161, 50);
            this.lblAcceptOrReject.TabIndex = 5;
            this.lblAcceptOrReject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGPA
            // 
            this.txtGPA.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPA.Location = new System.Drawing.Point(166, 165);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(158, 38);
            this.txtGPA.TabIndex = 0;
            this.txtGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdmissionTestScore
            // 
            this.txtAdmissionTestScore.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmissionTestScore.Location = new System.Drawing.Point(455, 165);
            this.txtAdmissionTestScore.Name = "txtAdmissionTestScore";
            this.txtAdmissionTestScore.Size = new System.Drawing.Size(158, 38);
            this.txtAdmissionTestScore.TabIndex = 1;
            this.txtAdmissionTestScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCollegeAdmission
            // 
            this.AcceptButton = this.btnAdmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAdmissionTestScore);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.lblAcceptOrReject);
            this.Controls.Add(this.lblAdmissionTestScore);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdmit);
            this.Name = "frmCollegeAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Admission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblAdmissionTestScore;
        private System.Windows.Forms.Label lblAcceptOrReject;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtAdmissionTestScore;
    }
}

