namespace Homework09_04
{
    partial class frmReservations
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
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblNumberOfNights = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblAvgPricePerNight = new System.Windows.Forms.Label();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.txtNumberOfNights = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtAvgPricePerNight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblArrivalDate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.Location = new System.Drawing.Point(96, 24);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(235, 32);
            this.lblArrivalDate.TabIndex = 0;
            this.lblArrivalDate.Text = "Arrival Date:";
            this.lblArrivalDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblDepartureDate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDate.Location = new System.Drawing.Point(96, 90);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(235, 32);
            this.lblDepartureDate.TabIndex = 1;
            this.lblDepartureDate.Text = "Departure Date:";
            this.lblDepartureDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfNights
            // 
            this.lblNumberOfNights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblNumberOfNights.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfNights.Location = new System.Drawing.Point(96, 161);
            this.lblNumberOfNights.Name = "lblNumberOfNights";
            this.lblNumberOfNights.Size = new System.Drawing.Size(235, 32);
            this.lblNumberOfNights.TabIndex = 2;
            this.lblNumberOfNights.Text = "Number Of Nights:";
            this.lblNumberOfNights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(96, 234);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(235, 32);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total Price:";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgPricePerNight
            // 
            this.lblAvgPricePerNight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblAvgPricePerNight.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPricePerNight.Location = new System.Drawing.Point(96, 303);
            this.lblAvgPricePerNight.Name = "lblAvgPricePerNight";
            this.lblAvgPricePerNight.Size = new System.Drawing.Size(235, 32);
            this.lblAvgPricePerNight.TabIndex = 4;
            this.lblAvgPricePerNight.Text = "Avg Price Per Night:";
            this.lblAvgPricePerNight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpArrival
            // 
            this.dtpArrival.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrival.Location = new System.Drawing.Point(368, 24);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(374, 38);
            this.dtpArrival.TabIndex = 5;
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeparture.Location = new System.Drawing.Point(368, 90);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(374, 38);
            this.dtpDeparture.TabIndex = 6;
            // 
            // txtNumberOfNights
            // 
            this.txtNumberOfNights.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfNights.Location = new System.Drawing.Point(368, 161);
            this.txtNumberOfNights.Name = "txtNumberOfNights";
            this.txtNumberOfNights.Size = new System.Drawing.Size(374, 38);
            this.txtNumberOfNights.TabIndex = 7;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(368, 234);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(374, 38);
            this.txtTotalPrice.TabIndex = 8;
            // 
            // txtAvgPricePerNight
            // 
            this.txtAvgPricePerNight.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgPricePerNight.Location = new System.Drawing.Point(368, 303);
            this.txtAvgPricePerNight.Name = "txtAvgPricePerNight";
            this.txtAvgPricePerNight.ReadOnly = true;
            this.txtAvgPricePerNight.Size = new System.Drawing.Size(374, 38);
            this.txtAvgPricePerNight.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(102, 374);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 46);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(346, 374);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 46);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(593, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 46);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmReservations
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAvgPricePerNight);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtNumberOfNights);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.dtpArrival);
            this.Controls.Add(this.lblAvgPricePerNight);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblNumberOfNights);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Name = "frmReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblNumberOfNights;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblAvgPricePerNight;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.TextBox txtNumberOfNights;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtAvgPricePerNight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

