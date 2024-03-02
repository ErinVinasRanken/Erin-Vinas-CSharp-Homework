namespace Homework09_01
{
    partial class frmSuperhero
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
            this.lblName = new System.Windows.Forms.Label();
            this.ddlSuperhero = new System.Windows.Forms.ComboBox();
            this.lblAlterEgo = new System.Windows.Forms.Label();
            this.picSuperHeroImage = new System.Windows.Forms.PictureBox();
            this.lblBio = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSuperHeroImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Cyan;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(89, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(315, 39);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // ddlSuperhero
            // 
            this.ddlSuperhero.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSuperhero.FormattingEnabled = true;
            this.ddlSuperhero.Location = new System.Drawing.Point(92, 81);
            this.ddlSuperhero.Name = "ddlSuperhero";
            this.ddlSuperhero.Size = new System.Drawing.Size(312, 39);
            this.ddlSuperhero.TabIndex = 0;
            this.ddlSuperhero.SelectedIndexChanged += new System.EventHandler(this.ddlSuperhero_SelectedIndexChanged);
            // 
            // lblAlterEgo
            // 
            this.lblAlterEgo.BackColor = System.Drawing.Color.Cyan;
            this.lblAlterEgo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterEgo.Location = new System.Drawing.Point(89, 210);
            this.lblAlterEgo.Name = "lblAlterEgo";
            this.lblAlterEgo.Size = new System.Drawing.Size(315, 39);
            this.lblAlterEgo.TabIndex = 4;
            this.lblAlterEgo.Text = "Alter Ego:";
            // 
            // picSuperHeroImage
            // 
            this.picSuperHeroImage.Location = new System.Drawing.Point(531, 81);
            this.picSuperHeroImage.Name = "picSuperHeroImage";
            this.picSuperHeroImage.Size = new System.Drawing.Size(512, 532);
            this.picSuperHeroImage.TabIndex = 5;
            this.picSuperHeroImage.TabStop = false;
            // 
            // lblBio
            // 
            this.lblBio.BackColor = System.Drawing.Color.Cyan;
            this.lblBio.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.Location = new System.Drawing.Point(86, 280);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(318, 373);
            this.lblBio.TabIndex = 5;
            this.lblBio.Text = "Bio:";
            this.lblBio.Click += new System.EventHandler(this.lblBio_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(148, 699);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 51);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(531, 699);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 51);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblURL
            // 
            this.lblURL.BackColor = System.Drawing.Color.Cyan;
            this.lblURL.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(531, 621);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(309, 32);
            this.lblURL.TabIndex = 6;
            this.lblURL.Text = "URL:";
            // 
            // frmSuperhero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1080, 762);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.picSuperHeroImage);
            this.Controls.Add(this.lblAlterEgo);
            this.Controls.Add(this.ddlSuperhero);
            this.Controls.Add(this.lblName);
            this.Name = "frmSuperhero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Superhero Database";
            this.Load += new System.EventHandler(this.frmSuperhero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSuperHeroImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox ddlSuperhero;
        private System.Windows.Forms.Label lblAlterEgo;
        private System.Windows.Forms.PictureBox picSuperHeroImage;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblURL;
    }
}

