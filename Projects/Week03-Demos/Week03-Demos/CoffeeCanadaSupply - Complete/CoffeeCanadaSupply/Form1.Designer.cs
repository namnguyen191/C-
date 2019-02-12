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
            this.grpCustomerType = new System.Windows.Forms.GroupBox();
            this.radPreferred = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.radNew = new System.Windows.Forms.RadioButton();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcTotal = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpCustomerType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomerType
            // 
            this.grpCustomerType.Controls.Add(this.radPreferred);
            this.grpCustomerType.Controls.Add(this.radStandard);
            this.grpCustomerType.Controls.Add(this.radNew);
            this.grpCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerType.Location = new System.Drawing.Point(35, 46);
            this.grpCustomerType.Margin = new System.Windows.Forms.Padding(4);
            this.grpCustomerType.Name = "grpCustomerType";
            this.grpCustomerType.Padding = new System.Windows.Forms.Padding(4);
            this.grpCustomerType.Size = new System.Drawing.Size(173, 194);
            this.grpCustomerType.TabIndex = 0;
            this.grpCustomerType.TabStop = false;
            this.grpCustomerType.Text = "Customer Type";
            // 
            // radPreferred
            // 
            this.radPreferred.AutoSize = true;
            this.radPreferred.Location = new System.Drawing.Point(7, 146);
            this.radPreferred.Margin = new System.Windows.Forms.Padding(4);
            this.radPreferred.Name = "radPreferred";
            this.radPreferred.Size = new System.Drawing.Size(93, 24);
            this.radPreferred.TabIndex = 2;
            this.radPreferred.TabStop = true;
            this.radPreferred.Text = "&Preferred";
            this.radPreferred.UseVisualStyleBackColor = true;
            this.radPreferred.CheckedChanged += new System.EventHandler(this.radPreferred_CheckedChanged);
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(7, 89);
            this.radStandard.Margin = new System.Windows.Forms.Padding(4);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(93, 24);
            this.radStandard.TabIndex = 1;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "&Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            this.radStandard.CheckedChanged += new System.EventHandler(this.radStandard_CheckedChanged);
            // 
            // radNew
            // 
            this.radNew.AutoSize = true;
            this.radNew.Location = new System.Drawing.Point(7, 37);
            this.radNew.Margin = new System.Windows.Forms.Padding(4);
            this.radNew.Name = "radNew";
            this.radNew.Size = new System.Drawing.Size(58, 24);
            this.radNew.TabIndex = 0;
            this.radNew.TabStop = true;
            this.radNew.Text = "&New";
            this.radNew.UseVisualStyleBackColor = true;
            this.radNew.CheckedChanged += new System.EventHandler(this.radNew_CheckedChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(248, 82);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(72, 20);
            this.lblQty.TabIndex = 1;
            this.lblQty.Text = "&Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(248, 134);
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
            this.lblTotal.Location = new System.Drawing.Point(248, 192);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // nudQty
            // 
            this.nudQty.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQty.Location = new System.Drawing.Point(339, 83);
            this.nudQty.Margin = new System.Windows.Forms.Padding(4);
            this.nudQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(83, 22);
            this.nudQty.TabIndex = 2;
            this.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPrice.Location = new System.Drawing.Point(339, 135);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nudPrice.Name = "nudPrice";
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
            this.txtTotal.Location = new System.Drawing.Point(339, 192);
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
            this.btnCalcTotal.Location = new System.Drawing.Point(42, 267);
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
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(252, 267);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 30);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmCoffeeSupply
            // 
            this.AcceptButton = this.btnCalcTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(446, 320);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.grpCustomerType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCoffeeSupply";
            this.Text = "Coffee Canada Supply";
            this.grpCustomerType.ResumeLayout(false);
            this.grpCustomerType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerType;
        private System.Windows.Forms.RadioButton radPreferred;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radNew;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcTotal;
        private System.Windows.Forms.Button btnReset;
    }
}

