namespace EggCount
{
    partial class frmEggCount
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
            this.lblChickenCount = new System.Windows.Forms.Label();
            this.lblEggCount = new System.Windows.Forms.Label();
            this.txtChickenCount = new System.Windows.Forms.TextBox();
            this.txtEggCount = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(70, 325);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(147, 47);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(318, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 47);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(573, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 47);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblChickenCount
            // 
            this.lblChickenCount.BackColor = System.Drawing.Color.Gray;
            this.lblChickenCount.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChickenCount.Location = new System.Drawing.Point(152, 54);
            this.lblChickenCount.Name = "lblChickenCount";
            this.lblChickenCount.Size = new System.Drawing.Size(178, 38);
            this.lblChickenCount.TabIndex = 5;
            this.lblChickenCount.Text = "Chicken Count:";
            this.lblChickenCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEggCount
            // 
            this.lblEggCount.BackColor = System.Drawing.Color.Gray;
            this.lblEggCount.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEggCount.Location = new System.Drawing.Point(152, 134);
            this.lblEggCount.Name = "lblEggCount";
            this.lblEggCount.Size = new System.Drawing.Size(178, 38);
            this.lblEggCount.TabIndex = 6;
            this.lblEggCount.Text = "Egg Count:";
            this.lblEggCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChickenCount
            // 
            this.txtChickenCount.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChickenCount.Location = new System.Drawing.Point(362, 54);
            this.txtChickenCount.Name = "txtChickenCount";
            this.txtChickenCount.Size = new System.Drawing.Size(203, 38);
            this.txtChickenCount.TabIndex = 0;
            this.txtChickenCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEggCount
            // 
            this.txtEggCount.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEggCount.Location = new System.Drawing.Point(362, 134);
            this.txtEggCount.Name = "txtEggCount";
            this.txtEggCount.Size = new System.Drawing.Size(203, 38);
            this.txtEggCount.TabIndex = 1;
            this.txtEggCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Gray;
            this.lblResult.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(146, 231);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(439, 38);
            this.lblResult.TabIndex = 7;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEggCount
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtEggCount);
            this.Controls.Add(this.txtChickenCount);
            this.Controls.Add(this.lblEggCount);
            this.Controls.Add(this.lblChickenCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmEggCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egg Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblChickenCount;
        private System.Windows.Forms.Label lblEggCount;
        private System.Windows.Forms.TextBox txtChickenCount;
        private System.Windows.Forms.TextBox txtEggCount;
        private System.Windows.Forms.Label lblResult;
    }
}

