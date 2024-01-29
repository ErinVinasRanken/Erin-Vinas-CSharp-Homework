namespace RockPaperScissors
{
    partial class frmRockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRockPaperScissors));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRock = new System.Windows.Forms.Label();
            this.lblPaper = new System.Windows.Forms.Label();
            this.lblScissors = new System.Windows.Forms.Label();
            this.lblComputerWins = new System.Windows.Forms.Label();
            this.lblTieGames = new System.Windows.Forms.Label();
            this.lblUserWins = new System.Windows.Forms.Label();
            this.txtComputerWins = new System.Windows.Forms.TextBox();
            this.txtTieGames = new System.Windows.Forms.TextBox();
            this.txtUserWins = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Image = ((System.Drawing.Image)(resources.GetObject("btnRock.Image")));
            this.btnRock.Location = new System.Drawing.Point(86, 124);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(200, 200);
            this.btnRock.TabIndex = 0;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Image = ((System.Drawing.Image)(resources.GetObject("btnPaper.Image")));
            this.btnPaper.Location = new System.Drawing.Point(462, 124);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(200, 200);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Image = ((System.Drawing.Image)(resources.GetObject("btnScissors.Image")));
            this.btnScissors.Location = new System.Drawing.Point(818, 124);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(200, 200);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(226, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(591, 44);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Let\'s Play Some Rock Paper Scissors!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRock
            // 
            this.lblRock.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRock.Location = new System.Drawing.Point(86, 327);
            this.lblRock.Name = "lblRock";
            this.lblRock.Size = new System.Drawing.Size(200, 44);
            this.lblRock.TabIndex = 6;
            this.lblRock.Text = "ROCK";
            this.lblRock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaper
            // 
            this.lblPaper.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaper.Location = new System.Drawing.Point(462, 327);
            this.lblPaper.Name = "lblPaper";
            this.lblPaper.Size = new System.Drawing.Size(200, 44);
            this.lblPaper.TabIndex = 7;
            this.lblPaper.Text = "PAPER";
            this.lblPaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScissors
            // 
            this.lblScissors.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScissors.Location = new System.Drawing.Point(818, 327);
            this.lblScissors.Name = "lblScissors";
            this.lblScissors.Size = new System.Drawing.Size(200, 44);
            this.lblScissors.TabIndex = 8;
            this.lblScissors.Text = "SCISSORS";
            this.lblScissors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerWins
            // 
            this.lblComputerWins.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWins.Location = new System.Drawing.Point(299, 423);
            this.lblComputerWins.Name = "lblComputerWins";
            this.lblComputerWins.Size = new System.Drawing.Size(364, 44);
            this.lblComputerWins.TabIndex = 9;
            this.lblComputerWins.Text = "Computer Wins";
            this.lblComputerWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTieGames
            // 
            this.lblTieGames.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieGames.Location = new System.Drawing.Point(299, 591);
            this.lblTieGames.Name = "lblTieGames";
            this.lblTieGames.Size = new System.Drawing.Size(364, 44);
            this.lblTieGames.TabIndex = 11;
            this.lblTieGames.Text = "Tie Games";
            this.lblTieGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserWins
            // 
            this.lblUserWins.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserWins.Location = new System.Drawing.Point(299, 505);
            this.lblUserWins.Name = "lblUserWins";
            this.lblUserWins.Size = new System.Drawing.Size(364, 44);
            this.lblUserWins.TabIndex = 10;
            this.lblUserWins.Text = "User Wins";
            this.lblUserWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtComputerWins
            // 
            this.txtComputerWins.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComputerWins.Location = new System.Drawing.Point(691, 417);
            this.txtComputerWins.Name = "txtComputerWins";
            this.txtComputerWins.ReadOnly = true;
            this.txtComputerWins.Size = new System.Drawing.Size(126, 50);
            this.txtComputerWins.TabIndex = 3;
            // 
            // txtTieGames
            // 
            this.txtTieGames.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieGames.Location = new System.Drawing.Point(691, 585);
            this.txtTieGames.Name = "txtTieGames";
            this.txtTieGames.ReadOnly = true;
            this.txtTieGames.Size = new System.Drawing.Size(126, 50);
            this.txtTieGames.TabIndex = 5;
            // 
            // txtUserWins
            // 
            this.txtUserWins.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserWins.Location = new System.Drawing.Point(691, 499);
            this.txtUserWins.Name = "txtUserWins";
            this.txtUserWins.ReadOnly = true;
            this.txtUserWins.Size = new System.Drawing.Size(126, 50);
            this.txtUserWins.TabIndex = 4;
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1137, 724);
            this.Controls.Add(this.txtUserWins);
            this.Controls.Add(this.txtTieGames);
            this.Controls.Add(this.txtComputerWins);
            this.Controls.Add(this.lblUserWins);
            this.Controls.Add(this.lblTieGames);
            this.Controls.Add(this.lblComputerWins);
            this.Controls.Add(this.lblScissors);
            this.Controls.Add(this.lblPaper);
            this.Controls.Add(this.lblRock);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "frmRockPaperScissors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRock;
        private System.Windows.Forms.Label lblPaper;
        private System.Windows.Forms.Label lblScissors;
        private System.Windows.Forms.Label lblComputerWins;
        private System.Windows.Forms.Label lblTieGames;
        private System.Windows.Forms.Label lblUserWins;
        private System.Windows.Forms.TextBox txtComputerWins;
        private System.Windows.Forms.TextBox txtTieGames;
        private System.Windows.Forms.TextBox txtUserWins;
    }
}

