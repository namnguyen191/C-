namespace Coffee_Shop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMocha = new System.Windows.Forms.RadioButton();
            this.radEspresso = new System.Windows.Forms.RadioButton();
            this.radLatte = new System.Windows.Forms.RadioButton();
            this.radCap = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkToGo = new System.Windows.Forms.CheckBox();
            this.chkSugar = new System.Windows.Forms.CheckBox();
            this.chkMilk = new System.Windows.Forms.CheckBox();
            this.chkDecaf = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMocha);
            this.groupBox1.Controls.Add(this.radEspresso);
            this.groupBox1.Controls.Add(this.radLatte);
            this.groupBox1.Controls.Add(this.radCap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beverage";
            // 
            // radMocha
            // 
            this.radMocha.AutoSize = true;
            this.radMocha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMocha.Location = new System.Drawing.Point(6, 141);
            this.radMocha.Name = "radMocha";
            this.radMocha.Size = new System.Drawing.Size(67, 20);
            this.radMocha.TabIndex = 3;
            this.radMocha.TabStop = true;
            this.radMocha.Text = "&Mocha";
            this.radMocha.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkToGo);
            this.groupBox2.Controls.Add(this.chkSugar);
            this.groupBox2.Controls.Add(this.chkMilk);
            this.groupBox2.Controls.Add(this.chkDecaf);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(220, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 176);
            this.groupBox2.TabIndex = 1;
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
            this.btnOrder.Location = new System.Drawing.Point(405, 62);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "&Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(405, 126);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(15, 265);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(465, 34);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.Text = "Your Order:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 358);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FIRSTCUP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMocha;
        private System.Windows.Forms.RadioButton radEspresso;
        private System.Windows.Forms.RadioButton radLatte;
        private System.Windows.Forms.RadioButton radCap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkToGo;
        private System.Windows.Forms.CheckBox chkSugar;
        private System.Windows.Forms.CheckBox chkMilk;
        private System.Windows.Forms.CheckBox chkDecaf;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label lblOrder;
    }
}

