namespace Lab2
{
    partial class frm1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.txtSqrt = new System.Windows.Forms.TextBox();
            this.btnSqrt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl1.Location = new System.Drawing.Point(12, 50);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(112, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter Number:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl2.Location = new System.Drawing.Point(12, 119);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(104, 20);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Square Root:";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumber.Location = new System.Drawing.Point(152, 53);
            this.nudNumber.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(120, 26);
            this.nudNumber.TabIndex = 2;
            this.nudNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSqrt
            // 
            this.txtSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSqrt.Location = new System.Drawing.Point(152, 119);
            this.txtSqrt.Name = "txtSqrt";
            this.txtSqrt.ReadOnly = true;
            this.txtSqrt.Size = new System.Drawing.Size(120, 26);
            this.txtSqrt.TabIndex = 3;
            this.txtSqrt.TabStop = false;
            this.txtSqrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSqrt.TextChanged += new System.EventHandler(this.txtSqrt_TextChanged);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSqrt.Location = new System.Drawing.Point(59, 176);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(158, 46);
            this.btnSqrt.TabIndex = 4;
            this.btnSqrt.Text = "Square Root";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.txtSqrt);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Square Root";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frm1_Load);
            this.Click += new System.EventHandler(this.frm1_Click);
            this.DoubleClick += new System.EventHandler(this.frm1_DoubleClick);
            this.Enter += new System.EventHandler(this.frm1_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.TextBox txtSqrt;
        private System.Windows.Forms.Button btnSqrt;
    }
}

