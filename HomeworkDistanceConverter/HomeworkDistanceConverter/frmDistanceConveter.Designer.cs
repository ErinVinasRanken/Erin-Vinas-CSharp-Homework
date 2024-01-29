namespace HomeworkDistanceConverter
{
    partial class frmDistanceConveter
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
            lblDistanceInMiles = new Label();
            lblDistanceInKilometers = new Label();
            txtDistanceInMiles = new TextBox();
            txtDistanceInKilometers = new TextBox();
            btnConvertToKM = new Button();
            btnConvertToMiles = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblDistanceInMiles
            // 
            lblDistanceInMiles.BackColor = Color.Lime;
            lblDistanceInMiles.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblDistanceInMiles.Location = new Point(138, 42);
            lblDistanceInMiles.Name = "lblDistanceInMiles";
            lblDistanceInMiles.Size = new Size(199, 37);
            lblDistanceInMiles.TabIndex = 6;
            lblDistanceInMiles.Text = "Distance In Miles:";
            // 
            // lblDistanceInKilometers
            // 
            lblDistanceInKilometers.BackColor = Color.Lime;
            lblDistanceInKilometers.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblDistanceInKilometers.Location = new Point(437, 42);
            lblDistanceInKilometers.Name = "lblDistanceInKilometers";
            lblDistanceInKilometers.Size = new Size(258, 37);
            lblDistanceInKilometers.TabIndex = 7;
            lblDistanceInKilometers.Text = "Distance In Kilometers:";
            // 
            // txtDistanceInMiles
            // 
            txtDistanceInMiles.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtDistanceInMiles.Location = new Point(138, 105);
            txtDistanceInMiles.Name = "txtDistanceInMiles";
            txtDistanceInMiles.Size = new Size(199, 38);
            txtDistanceInMiles.TabIndex = 0;
            // 
            // txtDistanceInKilometers
            // 
            txtDistanceInKilometers.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtDistanceInKilometers.Location = new Point(437, 105);
            txtDistanceInKilometers.Name = "txtDistanceInKilometers";
            txtDistanceInKilometers.Size = new Size(258, 38);
            txtDistanceInKilometers.TabIndex = 1;
            // 
            // btnConvertToKM
            // 
            btnConvertToKM.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnConvertToKM.Location = new Point(147, 193);
            btnConvertToKM.Name = "btnConvertToKM";
            btnConvertToKM.Size = new Size(199, 52);
            btnConvertToKM.TabIndex = 2;
            btnConvertToKM.Text = "Convert To &KM";
            btnConvertToKM.UseVisualStyleBackColor = true;
            btnConvertToKM.Click += btnConvertToKM_Click;
            // 
            // btnConvertToMiles
            // 
            btnConvertToMiles.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnConvertToMiles.Location = new Point(446, 193);
            btnConvertToMiles.Name = "btnConvertToMiles";
            btnConvertToMiles.Size = new Size(202, 52);
            btnConvertToMiles.TabIndex = 3;
            btnConvertToMiles.Text = "Convert To &Miles";
            btnConvertToMiles.UseVisualStyleBackColor = true;
            btnConvertToMiles.Click += btnConvertToMiles_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(147, 287);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(199, 52);
            btnClear.TabIndex = 4;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(446, 287);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(202, 52);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Lime;
            lblResult.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblResult.Location = new Point(147, 372);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(548, 37);
            lblResult.TabIndex = 8;
            // 
            // frmDistanceConveter
            // 
            AcceptButton = btnConvertToKM;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnConvertToMiles);
            Controls.Add(btnConvertToKM);
            Controls.Add(txtDistanceInKilometers);
            Controls.Add(txtDistanceInMiles);
            Controls.Add(lblDistanceInKilometers);
            Controls.Add(lblDistanceInMiles);
            Name = "frmDistanceConveter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistanceInMiles;
        private Label lblDistanceInKilometers;
        private TextBox txtDistanceInMiles;
        private TextBox txtDistanceInKilometers;
        private Button btnConvertToKM;
        private Button btnConvertToMiles;
        private Button btnClear;
        private Button btnExit;
        private Label lblResult;
    }
}
