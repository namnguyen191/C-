namespace Kilometers_Per_Litre
{
    partial class frmKPL
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
            this.lblK = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblKPL = new System.Windows.Forms.Label();
            this.txtKL = new System.Windows.Forms.TextBox();
            this.txtKPL = new System.Windows.Forms.TextBox();
            this.nudLitres = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLitres)).BeginInit();
            this.SuspendLayout();
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(36, 47);
            this.lblK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(83, 18);
            this.lblK.TabIndex = 0;
            this.lblK.Text = "Kilometres:";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(36, 109);
            this.lblL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(129, 18);
            this.lblL.TabIndex = 1;
            this.lblL.Text = "Litres of gas used:";
            // 
            // lblKPL
            // 
            this.lblKPL.AutoSize = true;
            this.lblKPL.Location = new System.Drawing.Point(36, 172);
            this.lblKPL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKPL.Name = "lblKPL";
            this.lblKPL.Size = new System.Drawing.Size(135, 18);
            this.lblKPL.TabIndex = 2;
            this.lblKPL.Text = "Kilometres per litre:";
            // 
            // txtKL
            // 
            this.txtKL.Location = new System.Drawing.Point(212, 44);
            this.txtKL.Name = "txtKL";
            this.txtKL.Size = new System.Drawing.Size(100, 24);
            this.txtKL.TabIndex = 3;
            this.txtKL.Text = "0";
            this.txtKL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKPL
            // 
            this.txtKPL.Location = new System.Drawing.Point(212, 169);
            this.txtKPL.Name = "txtKPL";
            this.txtKPL.ReadOnly = true;
            this.txtKPL.Size = new System.Drawing.Size(100, 24);
            this.txtKPL.TabIndex = 5;
            this.txtKPL.Text = "0";
            this.txtKPL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudLitres
            // 
            this.nudLitres.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLitres.Location = new System.Drawing.Point(212, 109);
            this.nudLitres.Name = "nudLitres";
            this.nudLitres.Size = new System.Drawing.Size(100, 24);
            this.nudLitres.TabIndex = 4;
            this.nudLitres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLitres.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(39, 234);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 31);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(212, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 31);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmKPL
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(342, 281);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudLitres);
            this.Controls.Add(this.txtKPL);
            this.Controls.Add(this.txtKL);
            this.Controls.Add(this.lblKPL);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKPL";
            this.Text = "Kilometers Per Litre";
            ((System.ComponentModel.ISupportInitialize)(this.nudLitres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblKPL;
        private System.Windows.Forms.TextBox txtKL;
        private System.Windows.Forms.TextBox txtKPL;
        private System.Windows.Forms.NumericUpDown nudLitres;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
    }
}

