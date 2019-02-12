namespace Midterm
{
    partial class frmRefrigerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRefrigerator));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMakeModel = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstFeatures = new System.Windows.Forms.ListBox();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.chkEnergy = new System.Windows.Forms.CheckBox();
            this.picSingle = new System.Windows.Forms.PictureBox();
            this.grpCompact = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudShelves = new System.Windows.Forms.NumericUpDown();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radFull = new System.Windows.Forms.RadioButton();
            this.radCompact = new System.Windows.Forms.RadioButton();
            this.grpFull = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvMake = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSingle)).BeginInit();
            this.grpCompact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShelves)).BeginInit();
            this.grpSize.SuspendLayout();
            this.grpFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvMake)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make and Model:";
            // 
            // txtMakeModel
            // 
            this.txtMakeModel.Location = new System.Drawing.Point(18, 56);
            this.txtMakeModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakeModel.Name = "txtMakeModel";
            this.txtMakeModel.Size = new System.Drawing.Size(200, 22);
            this.txtMakeModel.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(280, 177);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 35);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(280, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 41);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(280, 220);
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
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Available Feature(s):";
            // 
            // lstFeatures
            // 
            this.lstFeatures.FormattingEnabled = true;
            this.lstFeatures.ItemHeight = 16;
            this.lstFeatures.Items.AddRange(new object[] {
            "Ice maker",
            "Touch controls",
            "Spill safe shelves",
            "Deli Drawer"});
            this.lstFeatures.Location = new System.Drawing.Point(18, 61);
            this.lstFeatures.Name = "lstFeatures";
            this.lstFeatures.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFeatures.Size = new System.Drawing.Size(182, 68);
            this.lstFeatures.TabIndex = 5;
            // 
            // nudCapacity
            // 
            this.nudCapacity.DecimalPlaces = 2;
            this.nudCapacity.Location = new System.Drawing.Point(18, 124);
            this.nudCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(136, 22);
            this.nudCapacity.TabIndex = 20;
            this.nudCapacity.TabStop = false;
            this.nudCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCapacity.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // chkEnergy
            // 
            this.chkEnergy.AutoSize = true;
            this.chkEnergy.Location = new System.Drawing.Point(18, 161);
            this.chkEnergy.Name = "chkEnergy";
            this.chkEnergy.Size = new System.Drawing.Size(144, 20);
            this.chkEnergy.TabIndex = 21;
            this.chkEnergy.Text = "Energy Star Rated?";
            this.chkEnergy.UseVisualStyleBackColor = true;
            // 
            // picSingle
            // 
            this.picSingle.Image = ((System.Drawing.Image)(resources.GetObject("picSingle.Image")));
            this.picSingle.Location = new System.Drawing.Point(122, 17);
            this.picSingle.Name = "picSingle";
            this.picSingle.Size = new System.Drawing.Size(94, 108);
            this.picSingle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSingle.TabIndex = 22;
            this.picSingle.TabStop = false;
            // 
            // grpCompact
            // 
            this.grpCompact.Controls.Add(this.label2);
            this.grpCompact.Controls.Add(this.nudShelves);
            this.grpCompact.Controls.Add(this.picSingle);
            this.grpCompact.Location = new System.Drawing.Point(18, 200);
            this.grpCompact.Name = "grpCompact";
            this.grpCompact.Size = new System.Drawing.Size(242, 135);
            this.grpCompact.TabIndex = 23;
            this.grpCompact.TabStop = false;
            this.grpCompact.Text = "Compact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "# of Shelves:";
            // 
            // nudShelves
            // 
            this.nudShelves.Location = new System.Drawing.Point(18, 73);
            this.nudShelves.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudShelves.Name = "nudShelves";
            this.nudShelves.Size = new System.Drawing.Size(81, 22);
            this.nudShelves.TabIndex = 24;
            this.nudShelves.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudShelves.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radFull);
            this.grpSize.Controls.Add(this.radCompact);
            this.grpSize.Location = new System.Drawing.Point(235, 35);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(120, 95);
            this.grpSize.TabIndex = 24;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // radFull
            // 
            this.radFull.AutoSize = true;
            this.radFull.Location = new System.Drawing.Point(24, 57);
            this.radFull.Name = "radFull";
            this.radFull.Size = new System.Drawing.Size(76, 20);
            this.radFull.TabIndex = 3;
            this.radFull.Text = "Full Size";
            this.radFull.UseVisualStyleBackColor = true;
            this.radFull.CheckedChanged += new System.EventHandler(this.radFullSize_CheckedChanged);
            // 
            // radCompact
            // 
            this.radCompact.AutoSize = true;
            this.radCompact.Checked = true;
            this.radCompact.Location = new System.Drawing.Point(24, 26);
            this.radCompact.Name = "radCompact";
            this.radCompact.Size = new System.Drawing.Size(80, 20);
            this.radCompact.TabIndex = 2;
            this.radCompact.TabStop = true;
            this.radCompact.Text = "Compact";
            this.radCompact.UseVisualStyleBackColor = true;
            this.radCompact.CheckedChanged += new System.EventHandler(this.radCompact_CheckedChanged);
            // 
            // grpFull
            // 
            this.grpFull.Controls.Add(this.pictureBox1);
            this.grpFull.Controls.Add(this.lstFeatures);
            this.grpFull.Controls.Add(this.label3);
            this.grpFull.Location = new System.Drawing.Point(18, 349);
            this.grpFull.Name = "grpFull";
            this.grpFull.Size = new System.Drawing.Size(337, 146);
            this.grpFull.TabIndex = 25;
            this.grpFull.TabStop = false;
            this.grpFull.Text = "Full Size";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Capacity (Cubic Feet):";
            // 
            // errorProvMake
            // 
            this.errorProvMake.ContainerControl = this;
            // 
            // frmRefrigerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 503);
            this.Controls.Add(this.grpFull);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkEnergy);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.grpCompact);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtMakeModel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRefrigerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amrit Braich   123456789";
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSingle)).EndInit();
            this.grpCompact.ResumeLayout(false);
            this.grpCompact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShelves)).EndInit();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpFull.ResumeLayout(false);
            this.grpFull.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvMake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMakeModel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstFeatures;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.CheckBox chkEnergy;
        private System.Windows.Forms.PictureBox picSingle;
        private System.Windows.Forms.GroupBox grpCompact;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radFull;
        private System.Windows.Forms.RadioButton radCompact;
        private System.Windows.Forms.GroupBox grpFull;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudShelves;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvMake;
    }
}

