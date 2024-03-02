namespace Homework9_2
{
    partial class frmSearchResults
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
            this.lbSearchResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbSearchResults
            // 
            this.lbSearchResults.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchResults.ForeColor = System.Drawing.Color.Black;
            this.lbSearchResults.FormattingEnabled = true;
            this.lbSearchResults.ItemHeight = 31;
            this.lbSearchResults.Location = new System.Drawing.Point(108, 51);
            this.lbSearchResults.Name = "lbSearchResults";
            this.lbSearchResults.Size = new System.Drawing.Size(576, 314);
            this.lbSearchResults.TabIndex = 0;
            // 
            // frmSearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSearchResults);
            this.Name = "frmSearchResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSearchResults;
    }
}