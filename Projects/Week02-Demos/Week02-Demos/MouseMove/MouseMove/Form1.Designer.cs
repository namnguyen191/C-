namespace MouseMove
{
    partial class frmMouseMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMouseMove));
            this.lblXCoord = new System.Windows.Forms.Label();
            this.lblYCoord = new System.Windows.Forms.Label();
            this.txtXCoord = new System.Windows.Forms.TextBox();
            this.txtYCoord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblXCoord
            // 
            this.lblXCoord.AutoSize = true;
            this.lblXCoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblXCoord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblXCoord.Location = new System.Drawing.Point(30, 43);
            this.lblXCoord.Name = "lblXCoord";
            this.lblXCoord.Size = new System.Drawing.Size(116, 18);
            this.lblXCoord.TabIndex = 0;
            this.lblXCoord.Text = "&X Co-ordinate";
            // 
            // lblYCoord
            // 
            this.lblYCoord.AutoSize = true;
            this.lblYCoord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblYCoord.Location = new System.Drawing.Point(30, 127);
            this.lblYCoord.Name = "lblYCoord";
            this.lblYCoord.Size = new System.Drawing.Size(116, 18);
            this.lblYCoord.TabIndex = 2;
            this.lblYCoord.Text = "&Y Co-ordinate";
            // 
            // txtXCoord
            // 
            this.txtXCoord.Location = new System.Drawing.Point(243, 43);
            this.txtXCoord.Name = "txtXCoord";
            this.txtXCoord.Size = new System.Drawing.Size(116, 26);
            this.txtXCoord.TabIndex = 1;
            this.txtXCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYCoord
            // 
            this.txtYCoord.BackColor = System.Drawing.SystemColors.Window;
            this.txtYCoord.Location = new System.Drawing.Point(243, 127);
            this.txtYCoord.Name = "txtYCoord";
            this.txtYCoord.ReadOnly = true;
            this.txtYCoord.Size = new System.Drawing.Size(116, 26);
            this.txtYCoord.TabIndex = 3;
            this.txtYCoord.Text = "Y co-ordinate";
            this.txtYCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMouseMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(429, 237);
            this.Controls.Add(this.txtYCoord);
            this.Controls.Add(this.txtXCoord);
            this.Controls.Add(this.lblYCoord);
            this.Controls.Add(this.lblXCoord);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMouseMove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Co-ordinates";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMouseMove_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXCoord;
        private System.Windows.Forms.Label lblYCoord;
        private System.Windows.Forms.TextBox txtXCoord;
        private System.Windows.Forms.TextBox txtYCoord;
    }
}

