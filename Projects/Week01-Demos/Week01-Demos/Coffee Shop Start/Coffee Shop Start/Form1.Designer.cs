namespace Coffee_Shop_Start
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkToGo = new System.Windows.Forms.CheckBox();
            this.chkSugar = new System.Windows.Forms.CheckBox();
            this.chkMilk = new System.Windows.Forms.CheckBox();
            this.chkDecaf = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEspresso = new System.Windows.Forms.RadioButton();
            this.radLatte = new System.Windows.Forms.RadioButton();
            this.radCap = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.chkToGo);
            this.groupBox2.Controls.Add(this.chkSugar);
            this.groupBox2.Controls.Add(this.chkMilk);
            this.groupBox2.Controls.Add(this.chkDecaf);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(210, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 197);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // chkToGo
            // 
            this.chkToGo.AutoSize = true;
            this.chkToGo.Location = new System.Drawing.Point(6, 141);
            this.chkToGo.Name = "chkToGo";
            this.chkToGo.Size = new System.Drawing.Size(63, 20);
            this.chkToGo.TabIndex = 3;
            this.chkToGo.Text = "&To go";
            this.chkToGo.UseVisualStyleBackColor = true;
            // 
            // chkSugar
            // 
            this.chkSugar.AutoSize = true;
            this.chkSugar.Location = new System.Drawing.Point(6, 103);
            this.chkSugar.Name = "chkSugar";
            this.chkSugar.Size = new System.Drawing.Size(63, 20);
            this.chkSugar.TabIndex = 2;
            this.chkSugar.Text = "&Sugar";
            this.chkSugar.UseVisualStyleBackColor = true;
            // 
            // chkMilk
            // 
            this.chkMilk.AutoSize = true;
            this.chkMilk.Location = new System.Drawing.Point(6, 66);
            this.chkMilk.Name = "chkMilk";
            this.chkMilk.Size = new System.Drawing.Size(51, 20);
            this.chkMilk.TabIndex = 1;
            this.chkMilk.Text = "&Milk";
            this.chkMilk.UseVisualStyleBackColor = true;
            // 
            // chkDecaf
            // 
            this.chkDecaf.AutoSize = true;
            this.chkDecaf.Location = new System.Drawing.Point(6, 31);
            this.chkDecaf.Name = "chkDecaf";
            this.chkDecaf.Size = new System.Drawing.Size(111, 20);
            this.chkDecaf.TabIndex = 0;
            this.chkDecaf.Text = "&Decaffeinated";
            this.chkDecaf.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(421, 67);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 111);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Click Bait";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(15, 263);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(465, 34);
            this.lblOrder.TabIndex = 5;
            this.lblOrder.Text = "Your Order: LOLOLOLOLOLLMAO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEspresso);
            this.groupBox1.Controls.Add(this.radLatte);
            this.groupBox1.Controls.Add(this.radCap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 176);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beverage";
            // 
            // radEspresso
            // 
            this.radEspresso.AutoSize = true;
            this.radEspresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEspresso.Location = new System.Drawing.Point(6, 103);
            this.radEspresso.Name = "radEspresso";
            this.radEspresso.Size = new System.Drawing.Size(84, 20);
            this.radEspresso.TabIndex = 2;
            this.radEspresso.TabStop = true;
            this.radEspresso.Text = "&Espresso";
            this.radEspresso.UseVisualStyleBackColor = true;
            // 
            // radLatte
            // 
            this.radLatte.AutoSize = true;
            this.radLatte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLatte.Location = new System.Drawing.Point(6, 66);
            this.radLatte.Name = "radLatte";
            this.radLatte.Size = new System.Drawing.Size(55, 20);
            this.radLatte.TabIndex = 1;
            this.radLatte.TabStop = true;
            this.radLatte.Text = "&Latte";
            this.radLatte.UseVisualStyleBackColor = true;
            // 
            // radCap
            // 
            this.radCap.AutoSize = true;
            this.radCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCap.Location = new System.Drawing.Point(6, 30);
            this.radCap.Name = "radCap";
            this.radCap.Size = new System.Drawing.Size(98, 20);
            this.radCap.TabIndex = 0;
            this.radCap.TabStop = true;
            this.radCap.Text = "&Cappuccino";
            this.radCap.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 167);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(149, 20);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Blood of your enemy";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "FIRSTCUP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkToGo;
        private System.Windows.Forms.CheckBox chkSugar;
        private System.Windows.Forms.CheckBox chkMilk;
        private System.Windows.Forms.CheckBox chkDecaf;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radEspresso;
        private System.Windows.Forms.RadioButton radLatte;
        private System.Windows.Forms.RadioButton radCap;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

