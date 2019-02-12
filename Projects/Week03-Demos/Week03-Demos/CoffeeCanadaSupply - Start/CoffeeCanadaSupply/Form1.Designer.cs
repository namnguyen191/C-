namespace CoffeeCanadaSupply
{
    partial class frmCoffeeSupply
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
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcTotal = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.radNew = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.radPreferred = new System.Windows.Forms.RadioButton();
            this.grpCustType = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.grpCustType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(224, 85);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(72, 20);
            this.lblQty.TabIndex = 1;
            this.lblQty.Text = "&Quantity:";
            this.lblQty.Click += new System.EventHandler(this.lblQty_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(224, 124);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Pr&ice:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(224, 167);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPrice.Location = new System.Drawing.Point(339, 123);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nudPrice.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.ReadOnly = true;
            this.nudPrice.Size = new System.Drawing.Size(83, 22);
            this.nudPrice.TabIndex = 4;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrice.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(339, 167);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(83, 22);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "$0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcTotal
            // 
            this.btnCalcTotal.AutoSize = true;
            this.btnCalcTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTotal.Location = new System.Drawing.Point(23, 235);
            this.btnCalcTotal.Name = "btnCalcTotal";
            this.btnCalcTotal.Size = new System.Drawing.Size(124, 30);
            this.btnCalcTotal.TabIndex = 7;
            this.btnCalcTotal.Text = "&Calculate Total";
            this.btnCalcTotal.UseVisualStyleBackColor = true;
            this.btnCalcTotal.Click += new System.EventHandler(this.btnCalcTotal_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(228, 235);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 30);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // radNew
            // 
            this.radNew.AutoSize = true;
            this.radNew.Location = new System.Drawing.Point(11, 50);
            this.radNew.Margin = new System.Windows.Forms.Padding(4);
            this.radNew.Name = "radNew";
            this.radNew.Size = new System.Drawing.Size(53, 20);
            this.radNew.TabIndex = 0;
            this.radNew.TabStop = true;
            this.radNew.Text = "&New";
            this.radNew.UseVisualStyleBackColor = true;
            this.radNew.CheckedChanged += new System.EventHandler(this.radNew_CheckedChanged);
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(12, 22);
            this.radStandard.Margin = new System.Windows.Forms.Padding(4);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(81, 20);
            this.radStandard.TabIndex = 1;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "&Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            this.radStandard.CheckedChanged += new System.EventHandler(this.radStandard_CheckedChanged);
            // 
            // radPreferred
            // 
            this.radPreferred.AutoSize = true;
            this.radPreferred.Location = new System.Drawing.Point(11, 78);
            this.radPreferred.Margin = new System.Windows.Forms.Padding(4);
            this.radPreferred.Name = "radPreferred";
            this.radPreferred.Size = new System.Drawing.Size(82, 20);
            this.radPreferred.TabIndex = 2;
            this.radPreferred.TabStop = true;
            this.radPreferred.Text = "&Preferred";
            this.radPreferred.UseVisualStyleBackColor = true;
            this.radPreferred.CheckedChanged += new System.EventHandler(this.radPreferred_CheckedChanged);
            // 
            // grpCustType
            // 
            this.grpCustType.Controls.Add(this.radStandard);
            this.grpCustType.Controls.Add(this.radPreferred);
            this.grpCustType.Controls.Add(this.radNew);
            this.grpCustType.Location = new System.Drawing.Point(12, 86);
            this.grpCustType.Name = "grpCustType";
            this.grpCustType.Size = new System.Drawing.Size(200, 100);
            this.grpCustType.TabIndex = 9;
            this.grpCustType.TabStop = false;
            this.grpCustType.Text = "Type Of Customer";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(339, 86);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(82, 22);
            this.txtQuantity.TabIndex = 10;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // frmCoffeeSupply
            // 
            this.AcceptButton = this.btnCalcTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(446, 320);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.grpCustType);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCoffeeSupply";
            this.Text = "Coffee Canada Supply";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.grpCustType.ResumeLayout(false);
            this.grpCustType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcTotal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton radNew;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radPreferred;
        private System.Windows.Forms.GroupBox grpCustType;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}

