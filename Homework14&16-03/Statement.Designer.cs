using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Homework14_16_03
{
    public partial class Statement : Form
    {
        public Statement(List<string> transactions)
        {
            InitializeComponent();

            // Display the transactions in the Label
            lblStatement.Text = string.Join("\n", transactions);
        }

        // Default constructor
        public Statement()
        {
            InitializeComponent();
        }

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
            this.lblStatement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatement
            // 
            this.lblStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblStatement.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement.Location = new System.Drawing.Point(30, 36);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(587, 722);
            this.lblStatement.TabIndex = 0;
            // 
            // Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(644, 777);
            this.Controls.Add(this.lblStatement);
            this.Name = "Statement";
            this.Text = "Statement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStatement;
    }
}
