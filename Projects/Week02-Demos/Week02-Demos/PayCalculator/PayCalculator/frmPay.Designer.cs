﻿namespace PayCalculator
{
    partial class frmPay
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.btnCalcGrossPay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Hours Worked:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(215, 32);
            this.txtHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(132, 22);
            this.txtHours.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hourly Pay Rate:";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(215, 82);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(132, 22);
            this.txtRate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gross Pay Earned:";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(215, 133);
            this.txtPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPay.Name = "txtPay";
            this.txtPay.ReadOnly = true;
            this.txtPay.Size = new System.Drawing.Size(132, 22);
            this.txtPay.TabIndex = 5;
            this.txtPay.TabStop = false;
            // 
            // btnCalcGrossPay
            // 
            this.btnCalcGrossPay.Location = new System.Drawing.Point(77, 186);
            this.btnCalcGrossPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcGrossPay.Name = "btnCalcGrossPay";
            this.btnCalcGrossPay.Size = new System.Drawing.Size(100, 64);
            this.btnCalcGrossPay.TabIndex = 6;
            this.btnCalcGrossPay.Text = "Calculate Gross Pay";
            this.btnCalcGrossPay.UseVisualStyleBackColor = true;
            this.btnCalcGrossPay.Click += new System.EventHandler(this.btnCalcGrossPay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(215, 186);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 64);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 271);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalcGrossPay);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Button btnCalcGrossPay;
        private System.Windows.Forms.Button btnClose;
    }
}

