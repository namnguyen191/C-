namespace Lab7_8
{
    partial class frmHouseForRent
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
            this.lblHouseForRent = new System.Windows.Forms.Label();
            this.grpPropertyInformation = new System.Windows.Forms.GroupBox();
            this.txtPropertyId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPropertyId = new System.Windows.Forms.Label();
            this.grpHouse = new System.Windows.Forms.GroupBox();
            this.grpNumberOfBedrooms = new System.Windows.Forms.GroupBox();
            this.rad1Room = new System.Windows.Forms.RadioButton();
            this.rad2Rooms = new System.Windows.Forms.RadioButton();
            this.rad3Rooms = new System.Windows.Forms.RadioButton();
            this.grpPropertyInformation.SuspendLayout();
            this.grpHouse.SuspendLayout();
            this.grpNumberOfBedrooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHouseForRent
            // 
            this.lblHouseForRent.AutoSize = true;
            this.lblHouseForRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblHouseForRent.Location = new System.Drawing.Point(12, 9);
            this.lblHouseForRent.Name = "lblHouseForRent";
            this.lblHouseForRent.Size = new System.Drawing.Size(197, 31);
            this.lblHouseForRent.TabIndex = 0;
            this.lblHouseForRent.Text = "House for Rent";
            // 
            // grpPropertyInformation
            // 
            this.grpPropertyInformation.Controls.Add(this.txtPropertyId);
            this.grpPropertyInformation.Controls.Add(this.txtAddress);
            this.grpPropertyInformation.Controls.Add(this.lblAddress);
            this.grpPropertyInformation.Controls.Add(this.lblPropertyId);
            this.grpPropertyInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpPropertyInformation.Location = new System.Drawing.Point(18, 56);
            this.grpPropertyInformation.Name = "grpPropertyInformation";
            this.grpPropertyInformation.Size = new System.Drawing.Size(334, 120);
            this.grpPropertyInformation.TabIndex = 1;
            this.grpPropertyInformation.TabStop = false;
            this.grpPropertyInformation.Text = "Property Information";
            // 
            // txtPropertyId
            // 
            this.txtPropertyId.Location = new System.Drawing.Point(107, 32);
            this.txtPropertyId.Name = "txtPropertyId";
            this.txtPropertyId.Size = new System.Drawing.Size(206, 23);
            this.txtPropertyId.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(107, 76);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(206, 23);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress.Location = new System.Drawing.Point(6, 79);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // lblPropertyId
            // 
            this.lblPropertyId.AutoSize = true;
            this.lblPropertyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPropertyId.Location = new System.Drawing.Point(6, 33);
            this.lblPropertyId.Name = "lblPropertyId";
            this.lblPropertyId.Size = new System.Drawing.Size(83, 17);
            this.lblPropertyId.TabIndex = 0;
            this.lblPropertyId.Text = "Property ID:";
            // 
            // grpHouse
            // 
            this.grpHouse.Controls.Add(this.grpNumberOfBedrooms);
            this.grpHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpHouse.Location = new System.Drawing.Point(18, 252);
            this.grpHouse.Name = "grpHouse";
            this.grpHouse.Size = new System.Drawing.Size(390, 207);
            this.grpHouse.TabIndex = 2;
            this.grpHouse.TabStop = false;
            this.grpHouse.Text = "House";
            // 
            // grpNumberOfBedrooms
            // 
            this.grpNumberOfBedrooms.Controls.Add(this.rad3Rooms);
            this.grpNumberOfBedrooms.Controls.Add(this.rad2Rooms);
            this.grpNumberOfBedrooms.Controls.Add(this.rad1Room);
            this.grpNumberOfBedrooms.Location = new System.Drawing.Point(9, 34);
            this.grpNumberOfBedrooms.Name = "grpNumberOfBedrooms";
            this.grpNumberOfBedrooms.Size = new System.Drawing.Size(167, 149);
            this.grpNumberOfBedrooms.TabIndex = 0;
            this.grpNumberOfBedrooms.TabStop = false;
            this.grpNumberOfBedrooms.Text = "Number of Bedrooms";
            // 
            // rad1Room
            // 
            this.rad1Room.AutoSize = true;
            this.rad1Room.Location = new System.Drawing.Point(6, 34);
            this.rad1Room.Name = "rad1Room";
            this.rad1Room.Size = new System.Drawing.Size(75, 21);
            this.rad1Room.TabIndex = 0;
            this.rad1Room.TabStop = true;
            this.rad1Room.Text = "1 Room";
            this.rad1Room.UseVisualStyleBackColor = true;
            // 
            // rad2Rooms
            // 
            this.rad2Rooms.AutoSize = true;
            this.rad2Rooms.Location = new System.Drawing.Point(6, 73);
            this.rad2Rooms.Name = "rad2Rooms";
            this.rad2Rooms.Size = new System.Drawing.Size(82, 21);
            this.rad2Rooms.TabIndex = 1;
            this.rad2Rooms.TabStop = true;
            this.rad2Rooms.Text = "2 Rooms";
            this.rad2Rooms.UseVisualStyleBackColor = true;
            // 
            // rad3Rooms
            // 
            this.rad3Rooms.AutoSize = true;
            this.rad3Rooms.Location = new System.Drawing.Point(6, 111);
            this.rad3Rooms.Name = "rad3Rooms";
            this.rad3Rooms.Size = new System.Drawing.Size(82, 21);
            this.rad3Rooms.TabIndex = 2;
            this.rad3Rooms.TabStop = true;
            this.rad3Rooms.Text = "3 Rooms";
            this.rad3Rooms.UseVisualStyleBackColor = true;
            // 
            // frmHouseForRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 554);
            this.Controls.Add(this.grpHouse);
            this.Controls.Add(this.grpPropertyInformation);
            this.Controls.Add(this.lblHouseForRent);
            this.Name = "frmHouseForRent";
            this.Text = "Vu Hoang Nam Nguyen";
            this.grpPropertyInformation.ResumeLayout(false);
            this.grpPropertyInformation.PerformLayout();
            this.grpHouse.ResumeLayout(false);
            this.grpNumberOfBedrooms.ResumeLayout(false);
            this.grpNumberOfBedrooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHouseForRent;
        private System.Windows.Forms.GroupBox grpPropertyInformation;
        private System.Windows.Forms.TextBox txtPropertyId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPropertyId;
        private System.Windows.Forms.GroupBox grpHouse;
        private System.Windows.Forms.GroupBox grpNumberOfBedrooms;
        private System.Windows.Forms.RadioButton rad3Rooms;
        private System.Windows.Forms.RadioButton rad2Rooms;
        private System.Windows.Forms.RadioButton rad1Room;
    }
}

