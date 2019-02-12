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
            this.txtKPL.TabIndex = 4;
            this.txtKPL.Text = "0";
            this.txtKPL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmKPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 219);
            this.Controls.Add(this.txtKPL);
            this.Controls.Add(this.txtKL);
            this.Controls.Add(this.lblKPL);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKPL";
            this.Text = "Kilometers Per Litre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblKPL;
        private System.Windows.Forms.TextBox txtKL;
        private System.Windows.Forms.TextBox txtKPL;
    }
}

