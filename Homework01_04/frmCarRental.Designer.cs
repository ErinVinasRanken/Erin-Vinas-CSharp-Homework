﻿namespace Homework01_04
{
    partial class frmCarRental
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.lblNumberOfMiles = new System.Windows.Forms.Label();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.txtNumberOfDays = new System.Windows.Forms.TextBox();
            this.txtTotalCharge = new System.Windows.Forms.TextBox();
            this.txtNumberOfMiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(148, 316);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 57);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(331, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 57);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(522, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 57);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNumberOfDays.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDays.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfDays.Location = new System.Drawing.Point(178, 82);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(209, 29);
            this.lblNumberOfDays.TabIndex = 6;
            this.lblNumberOfDays.Text = "Number Of Days:";
            this.lblNumberOfDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfMiles
            // 
            this.lblNumberOfMiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNumberOfMiles.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfMiles.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfMiles.Location = new System.Drawing.Point(178, 151);
            this.lblNumberOfMiles.Name = "lblNumberOfMiles";
            this.lblNumberOfMiles.Size = new System.Drawing.Size(209, 29);
            this.lblNumberOfMiles.TabIndex = 7;
            this.lblNumberOfMiles.Text = "Number Of Miles:";
            this.lblNumberOfMiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalCharge.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharge.ForeColor = System.Drawing.Color.White;
            this.lblTotalCharge.Location = new System.Drawing.Point(178, 216);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(209, 29);
            this.lblTotalCharge.TabIndex = 8;
            this.lblTotalCharge.Text = "Total Charge:";
            this.lblTotalCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumberOfDays
            // 
            this.txtNumberOfDays.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfDays.Location = new System.Drawing.Point(453, 91);
            this.txtNumberOfDays.Name = "txtNumberOfDays";
            this.txtNumberOfDays.Size = new System.Drawing.Size(171, 38);
            this.txtNumberOfDays.TabIndex = 0;
            this.txtNumberOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalCharge
            // 
            this.txtTotalCharge.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCharge.Location = new System.Drawing.Point(453, 216);
            this.txtTotalCharge.Name = "txtTotalCharge";
            this.txtTotalCharge.ReadOnly = true;
            this.txtTotalCharge.Size = new System.Drawing.Size(171, 38);
            this.txtTotalCharge.TabIndex = 5;
            this.txtTotalCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalCharge.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNumberOfMiles
            // 
            this.txtNumberOfMiles.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfMiles.Location = new System.Drawing.Point(453, 151);
            this.txtNumberOfMiles.Name = "txtNumberOfMiles";
            this.txtNumberOfMiles.Size = new System.Drawing.Size(171, 38);
            this.txtNumberOfMiles.TabIndex = 1;
            this.txtNumberOfMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCarRental
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumberOfMiles);
            this.Controls.Add(this.txtTotalCharge);
            this.Controls.Add(this.txtNumberOfDays);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.lblNumberOfMiles);
            this.Controls.Add(this.lblNumberOfDays);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmCarRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car rental Program";
            this.Load += new System.EventHandler(this.frmCarRental_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Label lblNumberOfMiles;
        private System.Windows.Forms.Label lblTotalCharge;
        private System.Windows.Forms.TextBox txtNumberOfDays;
        private System.Windows.Forms.TextBox txtTotalCharge;
        private System.Windows.Forms.TextBox txtNumberOfMiles;
    }
}

