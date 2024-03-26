namespace Homework14_16_02
{
    partial class frmPhotoShop
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelTotals = new System.Windows.Forms.Label();
            this.labelTheCost = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.radioButtonEclectic = new System.Windows.Forms.RadioButton();
            this.radioButtonVintage = new System.Windows.Forms.RadioButton();
            this.radioButtonAntique = new System.Windows.Forms.RadioButton();
            this.radioButtonModern = new System.Windows.Forms.RadioButton();
            this.radioButtonSimple = new System.Windows.Forms.RadioButton();
            this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
            this.radioButtonGold = new System.Windows.Forms.RadioButton();
            this.radioButtonSilver = new System.Windows.Forms.RadioButton();
            this.radioButtonSteel = new System.Windows.Forms.RadioButton();
            this.radioButtonOak = new System.Windows.Forms.RadioButton();
            this.radioButtonPine = new System.Windows.Forms.RadioButton();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.groupBoxFramed = new System.Windows.Forms.GroupBox();
            this.radioButtonFramed = new System.Windows.Forms.RadioButton();
            this.radioButtonMatted = new System.Windows.Forms.RadioButton();
            this.radioButtonUnframed = new System.Windows.Forms.RadioButton();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.groupBoxStyle.SuspendLayout();
            this.groupBoxMaterial.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxFramed.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(501, 609);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(95, 46);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(280, 609);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(95, 46);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelTotals
            // 
            this.labelTotals.BackColor = System.Drawing.Color.Silver;
            this.labelTotals.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.labelTotals.Location = new System.Drawing.Point(58, 730);
            this.labelTotals.Name = "labelTotals";
            this.labelTotals.Size = new System.Drawing.Size(538, 52);
            this.labelTotals.TabIndex = 16;
            // 
            // labelTheCost
            // 
            this.labelTheCost.BackColor = System.Drawing.Color.Silver;
            this.labelTheCost.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.labelTheCost.Location = new System.Drawing.Point(133, 672);
            this.labelTheCost.Name = "labelTheCost";
            this.labelTheCost.Size = new System.Drawing.Size(114, 35);
            this.labelTheCost.TabIndex = 14;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.labelCost.Location = new System.Drawing.Point(54, 681);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(58, 26);
            this.labelCost.TabIndex = 13;
            this.labelCost.Text = "Cost:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.buttonCalculate.Location = new System.Drawing.Point(63, 609);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(95, 46);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.Controls.Add(this.radioButtonEclectic);
            this.groupBoxStyle.Controls.Add(this.radioButtonVintage);
            this.groupBoxStyle.Controls.Add(this.radioButtonAntique);
            this.groupBoxStyle.Controls.Add(this.radioButtonModern);
            this.groupBoxStyle.Controls.Add(this.radioButtonSimple);
            this.groupBoxStyle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStyle.Location = new System.Drawing.Point(463, 371);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(151, 200);
            this.groupBoxStyle.TabIndex = 18;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "Style";
            // 
            // radioButtonEclectic
            // 
            this.radioButtonEclectic.AutoSize = true;
            this.radioButtonEclectic.Location = new System.Drawing.Point(6, 162);
            this.radioButtonEclectic.Name = "radioButtonEclectic";
            this.radioButtonEclectic.Size = new System.Drawing.Size(87, 27);
            this.radioButtonEclectic.TabIndex = 4;
            this.radioButtonEclectic.TabStop = true;
            this.radioButtonEclectic.Text = "Eclectic";
            this.radioButtonEclectic.UseVisualStyleBackColor = true;
            // 
            // radioButtonVintage
            // 
            this.radioButtonVintage.AutoSize = true;
            this.radioButtonVintage.Location = new System.Drawing.Point(6, 129);
            this.radioButtonVintage.Name = "radioButtonVintage";
            this.radioButtonVintage.Size = new System.Drawing.Size(85, 27);
            this.radioButtonVintage.TabIndex = 3;
            this.radioButtonVintage.TabStop = true;
            this.radioButtonVintage.Text = "Vintage";
            this.radioButtonVintage.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntique
            // 
            this.radioButtonAntique.AutoSize = true;
            this.radioButtonAntique.Location = new System.Drawing.Point(6, 96);
            this.radioButtonAntique.Name = "radioButtonAntique";
            this.radioButtonAntique.Size = new System.Drawing.Size(87, 27);
            this.radioButtonAntique.TabIndex = 2;
            this.radioButtonAntique.TabStop = true;
            this.radioButtonAntique.Text = "Antique";
            this.radioButtonAntique.UseVisualStyleBackColor = true;
            // 
            // radioButtonModern
            // 
            this.radioButtonModern.AutoSize = true;
            this.radioButtonModern.Location = new System.Drawing.Point(7, 63);
            this.radioButtonModern.Name = "radioButtonModern";
            this.radioButtonModern.Size = new System.Drawing.Size(86, 27);
            this.radioButtonModern.TabIndex = 1;
            this.radioButtonModern.TabStop = true;
            this.radioButtonModern.Text = "Modern";
            this.radioButtonModern.UseVisualStyleBackColor = true;
            // 
            // radioButtonSimple
            // 
            this.radioButtonSimple.AutoSize = true;
            this.radioButtonSimple.Location = new System.Drawing.Point(7, 28);
            this.radioButtonSimple.Name = "radioButtonSimple";
            this.radioButtonSimple.Size = new System.Drawing.Size(79, 27);
            this.radioButtonSimple.TabIndex = 0;
            this.radioButtonSimple.TabStop = true;
            this.radioButtonSimple.Text = "Simple";
            this.radioButtonSimple.UseVisualStyleBackColor = true;
            // 
            // groupBoxMaterial
            // 
            this.groupBoxMaterial.Controls.Add(this.radioButtonGold);
            this.groupBoxMaterial.Controls.Add(this.radioButtonSilver);
            this.groupBoxMaterial.Controls.Add(this.radioButtonSteel);
            this.groupBoxMaterial.Controls.Add(this.radioButtonOak);
            this.groupBoxMaterial.Controls.Add(this.radioButtonPine);
            this.groupBoxMaterial.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMaterial.Location = new System.Drawing.Point(255, 371);
            this.groupBoxMaterial.Name = "groupBoxMaterial";
            this.groupBoxMaterial.Size = new System.Drawing.Size(151, 200);
            this.groupBoxMaterial.TabIndex = 19;
            this.groupBoxMaterial.TabStop = false;
            this.groupBoxMaterial.Text = "Material";
            // 
            // radioButtonGold
            // 
            this.radioButtonGold.AutoSize = true;
            this.radioButtonGold.Location = new System.Drawing.Point(6, 162);
            this.radioButtonGold.Name = "radioButtonGold";
            this.radioButtonGold.Size = new System.Drawing.Size(64, 27);
            this.radioButtonGold.TabIndex = 4;
            this.radioButtonGold.TabStop = true;
            this.radioButtonGold.Text = "Gold";
            this.radioButtonGold.UseVisualStyleBackColor = true;
            // 
            // radioButtonSilver
            // 
            this.radioButtonSilver.AutoSize = true;
            this.radioButtonSilver.Location = new System.Drawing.Point(6, 129);
            this.radioButtonSilver.Name = "radioButtonSilver";
            this.radioButtonSilver.Size = new System.Drawing.Size(70, 27);
            this.radioButtonSilver.TabIndex = 3;
            this.radioButtonSilver.TabStop = true;
            this.radioButtonSilver.Text = "Silver";
            this.radioButtonSilver.UseVisualStyleBackColor = true;
            // 
            // radioButtonSteel
            // 
            this.radioButtonSteel.AutoSize = true;
            this.radioButtonSteel.Location = new System.Drawing.Point(6, 96);
            this.radioButtonSteel.Name = "radioButtonSteel";
            this.radioButtonSteel.Size = new System.Drawing.Size(65, 27);
            this.radioButtonSteel.TabIndex = 2;
            this.radioButtonSteel.TabStop = true;
            this.radioButtonSteel.Text = "Steel";
            this.radioButtonSteel.UseVisualStyleBackColor = true;
            // 
            // radioButtonOak
            // 
            this.radioButtonOak.AutoSize = true;
            this.radioButtonOak.Location = new System.Drawing.Point(7, 63);
            this.radioButtonOak.Name = "radioButtonOak";
            this.radioButtonOak.Size = new System.Drawing.Size(58, 27);
            this.radioButtonOak.TabIndex = 1;
            this.radioButtonOak.TabStop = true;
            this.radioButtonOak.Text = "Oak";
            this.radioButtonOak.UseVisualStyleBackColor = true;
            // 
            // radioButtonPine
            // 
            this.radioButtonPine.AutoSize = true;
            this.radioButtonPine.Location = new System.Drawing.Point(7, 28);
            this.radioButtonPine.Name = "radioButtonPine";
            this.radioButtonPine.Size = new System.Drawing.Size(61, 27);
            this.radioButtonPine.TabIndex = 0;
            this.radioButtonPine.TabStop = true;
            this.radioButtonPine.Text = "Pine";
            this.radioButtonPine.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.radioButtonWhite);
            this.groupBoxColor.Controls.Add(this.radioButtonBlue);
            this.groupBoxColor.Controls.Add(this.radioButtonGreen);
            this.groupBoxColor.Controls.Add(this.radioButtonRed);
            this.groupBoxColor.Controls.Add(this.radioButtonBlack);
            this.groupBoxColor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxColor.Location = new System.Drawing.Point(54, 362);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(151, 200);
            this.groupBoxColor.TabIndex = 17;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // radioButtonWhite
            // 
            this.radioButtonWhite.AutoSize = true;
            this.radioButtonWhite.Location = new System.Drawing.Point(6, 162);
            this.radioButtonWhite.Name = "radioButtonWhite";
            this.radioButtonWhite.Size = new System.Drawing.Size(71, 27);
            this.radioButtonWhite.TabIndex = 4;
            this.radioButtonWhite.TabStop = true;
            this.radioButtonWhite.Text = "White";
            this.radioButtonWhite.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(7, 129);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(62, 27);
            this.radioButtonBlue.TabIndex = 3;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(6, 96);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(74, 27);
            this.radioButtonGreen.TabIndex = 2;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(7, 63);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(58, 27);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(7, 28);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(70, 27);
            this.radioButtonBlack.TabIndex = 0;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "Black";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            // 
            // groupBoxFramed
            // 
            this.groupBoxFramed.Controls.Add(this.radioButtonFramed);
            this.groupBoxFramed.Controls.Add(this.radioButtonMatted);
            this.groupBoxFramed.Controls.Add(this.radioButtonUnframed);
            this.groupBoxFramed.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFramed.Location = new System.Drawing.Point(54, 175);
            this.groupBoxFramed.Name = "groupBoxFramed";
            this.groupBoxFramed.Size = new System.Drawing.Size(542, 152);
            this.groupBoxFramed.TabIndex = 15;
            this.groupBoxFramed.TabStop = false;
            this.groupBoxFramed.Text = "Framed";
            // 
            // radioButtonFramed
            // 
            this.radioButtonFramed.AutoSize = true;
            this.radioButtonFramed.Location = new System.Drawing.Point(84, 117);
            this.radioButtonFramed.Name = "radioButtonFramed";
            this.radioButtonFramed.Size = new System.Drawing.Size(94, 29);
            this.radioButtonFramed.TabIndex = 2;
            this.radioButtonFramed.TabStop = true;
            this.radioButtonFramed.Text = "Framed";
            this.radioButtonFramed.UseVisualStyleBackColor = true;
            // 
            // radioButtonMatted
            // 
            this.radioButtonMatted.AutoSize = true;
            this.radioButtonMatted.Location = new System.Drawing.Point(84, 78);
            this.radioButtonMatted.Name = "radioButtonMatted";
            this.radioButtonMatted.Size = new System.Drawing.Size(88, 29);
            this.radioButtonMatted.TabIndex = 1;
            this.radioButtonMatted.TabStop = true;
            this.radioButtonMatted.Text = "Matted";
            this.radioButtonMatted.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnframed
            // 
            this.radioButtonUnframed.AutoSize = true;
            this.radioButtonUnframed.Location = new System.Drawing.Point(84, 37);
            this.radioButtonUnframed.Name = "radioButtonUnframed";
            this.radioButtonUnframed.Size = new System.Drawing.Size(112, 29);
            this.radioButtonUnframed.TabIndex = 0;
            this.radioButtonUnframed.TabStop = true;
            this.radioButtonUnframed.Text = "Unframed";
            this.radioButtonUnframed.UseVisualStyleBackColor = true;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(203, 113);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(393, 32);
            this.textBoxHeight.TabIndex = 11;
            this.textBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWidth.Location = new System.Drawing.Point(203, 43);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(393, 32);
            this.textBoxWidth.TabIndex = 10;
            this.textBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(49, 113);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(100, 25);
            this.labelHeight.TabIndex = 21;
            this.labelHeight.Text = "Height (in)";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(49, 43);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(94, 25);
            this.labelWidth.TabIndex = 20;
            this.labelWidth.Text = "Width (in)";
            // 
            // frmPhotoShop
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(689, 823);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelTotals);
            this.Controls.Add(this.labelTheCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxStyle);
            this.Controls.Add(this.groupBoxMaterial);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxFramed);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Name = "frmPhotoShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Shop";
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxStyle.PerformLayout();
            this.groupBoxMaterial.ResumeLayout(false);
            this.groupBoxMaterial.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.groupBoxFramed.ResumeLayout(false);
            this.groupBoxFramed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelTotals;
        private System.Windows.Forms.Label labelTheCost;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.RadioButton radioButtonEclectic;
        private System.Windows.Forms.RadioButton radioButtonVintage;
        private System.Windows.Forms.RadioButton radioButtonAntique;
        private System.Windows.Forms.RadioButton radioButtonModern;
        private System.Windows.Forms.RadioButton radioButtonSimple;
        private System.Windows.Forms.GroupBox groupBoxMaterial;
        private System.Windows.Forms.RadioButton radioButtonGold;
        private System.Windows.Forms.RadioButton radioButtonSilver;
        private System.Windows.Forms.RadioButton radioButtonSteel;
        private System.Windows.Forms.RadioButton radioButtonOak;
        private System.Windows.Forms.RadioButton radioButtonPine;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radioButtonWhite;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.GroupBox groupBoxFramed;
        private System.Windows.Forms.RadioButton radioButtonFramed;
        private System.Windows.Forms.RadioButton radioButtonMatted;
        private System.Windows.Forms.RadioButton radioButtonUnframed;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
    }
}

