namespace Homework12_01
{
    partial class frmFlashCards
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
            lblTerm = new Label();
            txtTerm = new TextBox();
            btnDefine = new Button();
            btnClear = new Button();
            txtDefinition = new TextBox();
            lblAddNew = new Label();
            txtNewDefinition = new TextBox();
            btnAdd = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTerm
            // 
            lblTerm.BackColor = Color.FromArgb(255, 192, 128);
            lblTerm.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblTerm.Location = new Point(41, 41);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(436, 36);
            lblTerm.TabIndex = 0;
            lblTerm.Text = "What Term Do You Want Me To Define?";
            lblTerm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTerm
            // 
            txtTerm.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtTerm.Location = new Point(41, 96);
            txtTerm.Name = "txtTerm";
            txtTerm.Size = new Size(436, 38);
            txtTerm.TabIndex = 1;
            txtTerm.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDefine
            // 
            btnDefine.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnDefine.Location = new Point(555, 65);
            btnDefine.Name = "btnDefine";
            btnDefine.Size = new Size(141, 38);
            btnDefine.TabIndex = 2;
            btnDefine.Text = "&Define";
            btnDefine.UseVisualStyleBackColor = true;
            btnDefine.Click += this.btnDefine_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(759, 65);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 38);
            btnClear.TabIndex = 3;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += this.btnClear_Click;
            // 
            // txtDefinition
            // 
            txtDefinition.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtDefinition.Location = new Point(41, 155);
            txtDefinition.Multiline = true;
            txtDefinition.Name = "txtDefinition";
            txtDefinition.Size = new Size(756, 234);
            txtDefinition.TabIndex = 4;
            // 
            // lblAddNew
            // 
            lblAddNew.BackColor = Color.FromArgb(255, 192, 128);
            lblAddNew.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblAddNew.Location = new Point(41, 414);
            lblAddNew.Name = "lblAddNew";
            lblAddNew.Size = new Size(756, 36);
            lblAddNew.TabIndex = 5;
            lblAddNew.Text = "I Don't know This Term. Please Enter The Definition";
            lblAddNew.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNewDefinition
            // 
            txtNewDefinition.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtNewDefinition.Location = new Point(41, 484);
            txtNewDefinition.Multiline = true;
            txtNewDefinition.Name = "txtNewDefinition";
            txtNewDefinition.Size = new Size(436, 234);
            txtNewDefinition.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnAdd.Location = new Point(555, 602);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 38);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += this.btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(759, 602);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(141, 38);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // frmFlashCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(936, 777);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(txtNewDefinition);
            Controls.Add(lblAddNew);
            Controls.Add(txtDefinition);
            Controls.Add(btnClear);
            Controls.Add(btnDefine);
            Controls.Add(txtTerm);
            Controls.Add(lblTerm);
            Name = "frmFlashCards";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chapter 12 Homework Problem 1 - Flashcards";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTerm;
        private TextBox txtTerm;
        private Button btnDefine;
        private Button btnClear;
        private TextBox txtDefinition;
        private Label lblAddNew;
        private TextBox txtNewDefinition;
        private Button btnAdd;
        private Button btnExit;
    }
}
