namespace Homework12_06
{
    partial class frmTileEstimate
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
            lblRoomName = new Label();
            lblRoomWidth = new Label();
            lblRoomLength = new Label();
            txtRoomName = new TextBox();
            txtRoomWidth = new TextBox();
            txtRoomLength = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            txtResults = new TextBox();
            btnExit = new Button();
            lblHeading = new Label();
            SuspendLayout();
            // 
            // lblRoomName
            // 
            lblRoomName.BackColor = Color.FromArgb(192, 255, 255);
            lblRoomName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblRoomName.Location = new Point(32, 32);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(234, 34);
            lblRoomName.TabIndex = 7;
            lblRoomName.Text = "Room Name:";
            lblRoomName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoomWidth
            // 
            lblRoomWidth.BackColor = Color.FromArgb(192, 255, 255);
            lblRoomWidth.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblRoomWidth.Location = new Point(351, 32);
            lblRoomWidth.Name = "lblRoomWidth";
            lblRoomWidth.Size = new Size(234, 34);
            lblRoomWidth.TabIndex = 8;
            lblRoomWidth.Text = "Room Width:";
            lblRoomWidth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoomLength
            // 
            lblRoomLength.BackColor = Color.FromArgb(192, 255, 255);
            lblRoomLength.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblRoomLength.Location = new Point(685, 32);
            lblRoomLength.Name = "lblRoomLength";
            lblRoomLength.Size = new Size(234, 34);
            lblRoomLength.TabIndex = 9;
            lblRoomLength.Text = "Room Length:";
            lblRoomLength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRoomName
            // 
            txtRoomName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtRoomName.Location = new Point(32, 86);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(234, 38);
            txtRoomName.TabIndex = 0;
            txtRoomName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRoomWidth
            // 
            txtRoomWidth.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtRoomWidth.Location = new Point(351, 86);
            txtRoomWidth.Name = "txtRoomWidth";
            txtRoomWidth.Size = new Size(234, 38);
            txtRoomWidth.TabIndex = 1;
            txtRoomWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRoomLength
            // 
            txtRoomLength.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtRoomLength.Location = new Point(685, 86);
            txtRoomLength.Name = "txtRoomLength";
            txtRoomLength.Size = new Size(234, 38);
            txtRoomLength.TabIndex = 2;
            txtRoomLength.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnAdd.Location = new Point(996, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 45);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(996, 295);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 45);
            btnClear.TabIndex = 4;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtResults
            // 
            txtResults.BackColor = Color.White;
            txtResults.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResults.Location = new Point(32, 290);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(887, 490);
            txtResults.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(996, 610);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 45);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblHeading
            // 
            lblHeading.BackColor = Color.FromArgb(192, 255, 255);
            lblHeading.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHeading.Location = new Point(32, 147);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(887, 109);
            lblHeading.TabIndex = 10;
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmTileEstimate
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            CancelButton = btnClear;
            ClientSize = new Size(1180, 813);
            Controls.Add(lblHeading);
            Controls.Add(btnExit);
            Controls.Add(txtResults);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtRoomLength);
            Controls.Add(txtRoomWidth);
            Controls.Add(txtRoomName);
            Controls.Add(lblRoomLength);
            Controls.Add(lblRoomWidth);
            Controls.Add(lblRoomName);
            Name = "frmTileEstimate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chapter 12 Homework Problem 6 - Tile Estimate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoomName;
        private Label lblRoomWidth;
        private Label lblRoomLength;
        private TextBox txtRoomName;
        private TextBox txtRoomWidth;
        private TextBox txtRoomLength;
        private Button btnAdd;
        private Button btnClear;
        private TextBox txtResults;
        private Button btnExit;
        private Label lblHeading;
    }
}
