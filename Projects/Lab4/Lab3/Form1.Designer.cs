namespace Lab3
{
    partial class Nam_N01185573
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblNumOfBedRoom = new System.Windows.Forms.Label();
            this.nudBed = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBedRent = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.grbFinalMess = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBed)).BeginInit();
            this.grbFinalMess.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(221, 41);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(193, 26);
            this.txtFName.TabIndex = 0;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(221, 106);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(193, 26);
            this.txtLName.TabIndex = 1;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(122, 44);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(86, 20);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(122, 106);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(86, 20);
            this.lblLName.TabIndex = 3;
            this.lblLName.Text = "Last Name";
            // 
            // lblNumOfBedRoom
            // 
            this.lblNumOfBedRoom.AutoSize = true;
            this.lblNumOfBedRoom.Location = new System.Drawing.Point(122, 152);
            this.lblNumOfBedRoom.Name = "lblNumOfBedRoom";
            this.lblNumOfBedRoom.Size = new System.Drawing.Size(155, 20);
            this.lblNumOfBedRoom.TabIndex = 5;
            this.lblNumOfBedRoom.Text = "Number Of Bedroom";
            // 
            // nudBed
            // 
            this.nudBed.Location = new System.Drawing.Point(352, 152);
            this.nudBed.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBed.Name = "nudBed";
            this.nudBed.ReadOnly = true;
            this.nudBed.Size = new System.Drawing.Size(62, 26);
            this.nudBed.TabIndex = 6;
            this.nudBed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.Location = new System.Drawing.Point(164, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuy.Location = new System.Drawing.Point(36, 329);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 33);
            this.btnBuy.TabIndex = 8;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.Location = new System.Drawing.Point(301, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBedRent
            // 
            this.txtBedRent.Location = new System.Drawing.Point(0, 73);
            this.txtBedRent.Name = "txtBedRent";
            this.txtBedRent.ReadOnly = true;
            this.txtBedRent.Size = new System.Drawing.Size(187, 26);
            this.txtBedRent.TabIndex = 10;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(209, 73);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(187, 26);
            this.txtCost.TabIndex = 11;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(6, 31);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(0, 20);
            this.lblFullName.TabIndex = 12;
            // 
            // grbFinalMess
            // 
            this.grbFinalMess.Controls.Add(this.txtBedRent);
            this.grbFinalMess.Controls.Add(this.lblFullName);
            this.grbFinalMess.Controls.Add(this.txtCost);
            this.grbFinalMess.Cursor = System.Windows.Forms.Cursors.No;
            this.grbFinalMess.Location = new System.Drawing.Point(12, 210);
            this.grbFinalMess.Name = "grbFinalMess";
            this.grbFinalMess.Size = new System.Drawing.Size(402, 99);
            this.grbFinalMess.TabIndex = 13;
            this.grbFinalMess.TabStop = false;
            this.grbFinalMess.Visible = false;
            // 
            // Nam_N01185573
            // 
            this.AcceptButton = this.btnBuy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.grbFinalMess);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.nudBed);
            this.Controls.Add(this.lblNumOfBedRoom);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Nam_N01185573";
            this.Text = "Nam Real Estate";
            ((System.ComponentModel.ISupportInitialize)(this.nudBed)).EndInit();
            this.grbFinalMess.ResumeLayout(false);
            this.grbFinalMess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblNumOfBedRoom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBedRent;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.GroupBox grbFinalMess;
        internal System.Windows.Forms.NumericUpDown nudBed;
    }
}

