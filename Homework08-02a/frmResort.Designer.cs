namespace Homework08_02a
{
    partial class frmResort
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
            this.lblNightsStayed = new System.Windows.Forms.Label();
            this.lblNightsString = new System.Windows.Forms.Label();
            this.lblNightlyCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtNightsStayed = new System.Windows.Forms.TextBox();
            this.txtNightsString = new System.Windows.Forms.TextBox();
            this.txtNightlyCost = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNightsStayed
            // 
            this.lblNightsStayed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNightsStayed.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightsStayed.Location = new System.Drawing.Point(25, 83);
            this.lblNightsStayed.Name = "lblNightsStayed";
            this.lblNightsStayed.Size = new System.Drawing.Size(170, 36);
            this.lblNightsStayed.TabIndex = 7;
            this.lblNightsStayed.Text = "Nights Stayed:";
            this.lblNightsStayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNightsString
            // 
            this.lblNightsString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNightsString.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightsString.Location = new System.Drawing.Point(227, 83);
            this.lblNightsString.Name = "lblNightsString";
            this.lblNightsString.Size = new System.Drawing.Size(161, 36);
            this.lblNightsString.TabIndex = 8;
            this.lblNightsString.Text = "Nights String:";
            this.lblNightsString.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNightlyCost
            // 
            this.lblNightlyCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNightlyCost.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightlyCost.Location = new System.Drawing.Point(420, 83);
            this.lblNightlyCost.Name = "lblNightlyCost";
            this.lblNightlyCost.Size = new System.Drawing.Size(161, 36);
            this.lblNightlyCost.TabIndex = 9;
            this.lblNightlyCost.Text = "Nightly Cost:";
            this.lblNightlyCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalCost.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(612, 83);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(155, 36);
            this.lblTotalCost.TabIndex = 10;
            this.lblTotalCost.Text = "Total Cost:";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNightsStayed
            // 
            this.txtNightsStayed.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNightsStayed.Location = new System.Drawing.Point(31, 200);
            this.txtNightsStayed.Name = "txtNightsStayed";
            this.txtNightsStayed.Size = new System.Drawing.Size(158, 38);
            this.txtNightsStayed.TabIndex = 0;
            this.txtNightsStayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNightsString
            // 
            this.txtNightsString.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNightsString.Location = new System.Drawing.Point(233, 200);
            this.txtNightsString.Name = "txtNightsString";
            this.txtNightsString.ReadOnly = true;
            this.txtNightsString.Size = new System.Drawing.Size(158, 38);
            this.txtNightsString.TabIndex = 4;
            this.txtNightsString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNightlyCost
            // 
            this.txtNightlyCost.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNightlyCost.Location = new System.Drawing.Point(426, 200);
            this.txtNightlyCost.Name = "txtNightlyCost";
            this.txtNightlyCost.ReadOnly = true;
            this.txtNightlyCost.Size = new System.Drawing.Size(158, 38);
            this.txtNightlyCost.TabIndex = 5;
            this.txtNightlyCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(618, 200);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(158, 38);
            this.txtTotalCost.TabIndex = 6;
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(67, 313);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(127, 42);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(323, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 42);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(585, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmResort
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.txtNightlyCost);
            this.Controls.Add(this.txtNightsString);
            this.Controls.Add(this.txtNightsStayed);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblNightlyCost);
            this.Controls.Add(this.lblNightsString);
            this.Controls.Add(this.lblNightsStayed);
            this.Name = "frmResort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homework Chapter 8 - Resort #1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNightsStayed;
        private System.Windows.Forms.Label lblNightsString;
        private System.Windows.Forms.Label lblNightlyCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtNightsStayed;
        private System.Windows.Forms.TextBox txtNightsString;
        private System.Windows.Forms.TextBox txtNightlyCost;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

