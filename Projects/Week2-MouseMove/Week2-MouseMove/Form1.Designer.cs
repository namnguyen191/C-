namespace Week2_MouseMove
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
            this.lblXCoord = new System.Windows.Forms.Label();
            this.lblCoordinate2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblXCoord
            // 
            this.lblXCoord.AutoSize = true;
            this.lblXCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblXCoord.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblXCoord.Location = new System.Drawing.Point(123, 71);
            this.lblXCoord.Name = "lblXCoord";
            this.lblXCoord.Size = new System.Drawing.Size(174, 31);
            this.lblXCoord.TabIndex = 0;
            this.lblXCoord.Text = "X-Coordinate";
            // 
            // lblCoordinate2
            // 
            this.lblCoordinate2.AutoSize = true;
            this.lblCoordinate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCoordinate2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCoordinate2.Location = new System.Drawing.Point(123, 178);
            this.lblCoordinate2.Name = "lblCoordinate2";
            this.lblCoordinate2.Size = new System.Drawing.Size(174, 31);
            this.lblCoordinate2.TabIndex = 1;
            this.lblCoordinate2.Text = "Y-Coordinate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(343, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseMove);
            // 
            // frmMouseMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(665, 570);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCoordinate2);
            this.Controls.Add(this.lblXCoord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMouseMove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Co-ordinates";
            this.Load += new System.EventHandler(this.frmMouseMove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXCoord;
        private System.Windows.Forms.Label lblCoordinate2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

