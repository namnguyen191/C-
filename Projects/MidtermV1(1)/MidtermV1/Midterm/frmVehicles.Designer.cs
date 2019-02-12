namespace Midterm
{
    partial class frmVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicles));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radTruch = new System.Windows.Forms.RadioButton();
            this.radCar = new System.Windows.Forms.RadioButton();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMail = new System.Windows.Forms.ListBox();
            this.nudCargo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chkHatchback = new System.Windows.Forms.CheckBox();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 22);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type of Vehicle:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radTruch);
            this.panel1.Controls.Add(this.radCar);
            this.panel1.Location = new System.Drawing.Point(20, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 71);
            this.panel1.TabIndex = 11;
            // 
            // radTruch
            // 
            this.radTruch.AutoSize = true;
            this.radTruch.Location = new System.Drawing.Point(15, 40);
            this.radTruch.Name = "radTruch";
            this.radTruch.Size = new System.Drawing.Size(60, 20);
            this.radTruch.TabIndex = 1;
            this.radTruch.Text = "Truck";
            this.radTruch.UseVisualStyleBackColor = true;
            this.radTruch.CheckedChanged += new System.EventHandler(this.radTruch_CheckedChanged);
            // 
            // radCar
            // 
            this.radCar.AutoSize = true;
            this.radCar.Location = new System.Drawing.Point(15, 14);
            this.radCar.Name = "radCar";
            this.radCar.Size = new System.Drawing.Size(47, 20);
            this.radCar.TabIndex = 0;
            this.radCar.Text = "Car";
            this.radCar.UseVisualStyleBackColor = true;
            this.radCar.CheckedChanged += new System.EventHandler(this.radCar_CheckedChanged);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(360, 31);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 35);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(360, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 41);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(360, 74);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 35);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Category for Customer Mailing List::";
            // 
            // lstMail
            // 
            this.lstMail.FormattingEnabled = true;
            this.lstMail.ItemHeight = 16;
            this.lstMail.Items.AddRange(new object[] {
            "Specials",
            "Events",
            "New Model Information"});
            this.lstMail.Location = new System.Drawing.Point(18, 107);
            this.lstMail.Name = "lstMail";
            this.lstMail.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstMail.Size = new System.Drawing.Size(260, 52);
            this.lstMail.TabIndex = 5;
            // 
            // nudCargo
            // 
            this.nudCargo.DecimalPlaces = 2;
            this.nudCargo.Location = new System.Drawing.Point(155, 266);
            this.nudCargo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCargo.Name = "nudCargo";
            this.nudCargo.ReadOnly = true;
            this.nudCargo.Size = new System.Drawing.Size(120, 22);
            this.nudCargo.TabIndex = 20;
            this.nudCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCargo.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cargo Weight (Tons):";
            // 
            // chkHatchback
            // 
            this.chkHatchback.AutoSize = true;
            this.chkHatchback.Location = new System.Drawing.Point(155, 195);
            this.chkHatchback.Name = "chkHatchback";
            this.chkHatchback.Size = new System.Drawing.Size(92, 20);
            this.chkHatchback.TabIndex = 21;
            this.chkHatchback.Text = "Hatchback";
            this.chkHatchback.UseVisualStyleBackColor = true;
            // 
            // picCar
            // 
            this.picCar.Image = ((System.Drawing.Image)(resources.GetObject("picCar.Image")));
            this.picCar.Location = new System.Drawing.Point(298, 182);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(137, 110);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar.TabIndex = 22;
            this.picCar.TabStop = false;
            // 
            // frmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 314);
            this.Controls.Add(this.picCar);
            this.Controls.Add(this.chkHatchback);
            this.Controls.Add(this.nudCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vu Hoang Nam Nguyen      N01185573";
            this.Load += new System.EventHandler(this.frmVehicles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radCar;
        private System.Windows.Forms.RadioButton radTruch;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstMail;
        private System.Windows.Forms.NumericUpDown nudCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkHatchback;
        private System.Windows.Forms.PictureBox picCar;
    }
}

