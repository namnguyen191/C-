namespace BuildABurger
{
    partial class frmBurger
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
            this.grpBurgerType = new System.Windows.Forms.GroupBox();
            this.radSpecial = new System.Windows.Forms.RadioButton();
            this.radRegular = new System.Windows.Forms.RadioButton();
            this.grpCondiments = new System.Windows.Forms.GroupBox();
            this.chkPickles = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkMustard = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.btnInstantiate = new System.Windows.Forms.Button();
            this.grpBurgerType.SuspendLayout();
            this.grpCondiments.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBurgerType
            // 
            this.grpBurgerType.Controls.Add(this.radSpecial);
            this.grpBurgerType.Controls.Add(this.radRegular);
            this.grpBurgerType.Location = new System.Drawing.Point(18, 30);
            this.grpBurgerType.Margin = new System.Windows.Forms.Padding(4);
            this.grpBurgerType.Name = "grpBurgerType";
            this.grpBurgerType.Padding = new System.Windows.Forms.Padding(4);
            this.grpBurgerType.Size = new System.Drawing.Size(360, 72);
            this.grpBurgerType.TabIndex = 0;
            this.grpBurgerType.TabStop = false;
            this.grpBurgerType.Text = "Burger Type";
            this.grpBurgerType.Enter += new System.EventHandler(this.grpBurgerType_Enter);
            // 
            // radSpecial
            // 
            this.radSpecial.AutoSize = true;
            this.radSpecial.Enabled = false;
            this.radSpecial.Location = new System.Drawing.Point(186, 26);
            this.radSpecial.Margin = new System.Windows.Forms.Padding(4);
            this.radSpecial.Name = "radSpecial";
            this.radSpecial.Size = new System.Drawing.Size(122, 22);
            this.radSpecial.TabIndex = 3;
            this.radSpecial.TabStop = true;
            this.radSpecial.Text = "Special Burger";
            this.radSpecial.UseVisualStyleBackColor = true;
            // 
            // radRegular
            // 
            this.radRegular.AutoSize = true;
            this.radRegular.Location = new System.Drawing.Point(9, 26);
            this.radRegular.Margin = new System.Windows.Forms.Padding(4);
            this.radRegular.Name = "radRegular";
            this.radRegular.Size = new System.Drawing.Size(125, 22);
            this.radRegular.TabIndex = 2;
            this.radRegular.TabStop = true;
            this.radRegular.Text = "&Regular Burger";
            this.radRegular.UseVisualStyleBackColor = true;
            // 
            // grpCondiments
            // 
            this.grpCondiments.Controls.Add(this.chkPickles);
            this.grpCondiments.Controls.Add(this.chkOnions);
            this.grpCondiments.Controls.Add(this.chkMustard);
            this.grpCondiments.Controls.Add(this.chkLettuce);
            this.grpCondiments.Controls.Add(this.chkKetchup);
            this.grpCondiments.Location = new System.Drawing.Point(18, 136);
            this.grpCondiments.Margin = new System.Windows.Forms.Padding(4);
            this.grpCondiments.Name = "grpCondiments";
            this.grpCondiments.Padding = new System.Windows.Forms.Padding(4);
            this.grpCondiments.Size = new System.Drawing.Size(360, 98);
            this.grpCondiments.TabIndex = 1;
            this.grpCondiments.TabStop = false;
            this.grpCondiments.Text = "Condiments";
            // 
            // chkPickles
            // 
            this.chkPickles.AutoSize = true;
            this.chkPickles.Location = new System.Drawing.Point(136, 55);
            this.chkPickles.Margin = new System.Windows.Forms.Padding(4);
            this.chkPickles.Name = "chkPickles";
            this.chkPickles.Size = new System.Drawing.Size(75, 22);
            this.chkPickles.TabIndex = 6;
            this.chkPickles.Text = "Pickles";
            this.chkPickles.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(8, 55);
            this.chkOnions.Margin = new System.Windows.Forms.Padding(4);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(75, 22);
            this.chkOnions.TabIndex = 5;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkMustard
            // 
            this.chkMustard.AutoSize = true;
            this.chkMustard.Location = new System.Drawing.Point(259, 25);
            this.chkMustard.Margin = new System.Windows.Forms.Padding(4);
            this.chkMustard.Name = "chkMustard";
            this.chkMustard.Size = new System.Drawing.Size(81, 22);
            this.chkMustard.TabIndex = 4;
            this.chkMustard.Text = "Mustard";
            this.chkMustard.UseVisualStyleBackColor = true;
            // 
            // chkLettuce
            // 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.Location = new System.Drawing.Point(136, 25);
            this.chkLettuce.Margin = new System.Windows.Forms.Padding(4);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(75, 22);
            this.chkLettuce.TabIndex = 3;
            this.chkLettuce.Text = "Lettuce";
            this.chkLettuce.UseVisualStyleBackColor = true;
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.Location = new System.Drawing.Point(9, 25);
            this.chkKetchup.Margin = new System.Windows.Forms.Padding(4);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(81, 22);
            this.chkKetchup.TabIndex = 2;
            this.chkKetchup.Text = "Ketchup";
            this.chkKetchup.UseVisualStyleBackColor = true;
            // 
            // btnInstantiate
            // 
            this.btnInstantiate.Location = new System.Drawing.Point(129, 264);
            this.btnInstantiate.Name = "btnInstantiate";
            this.btnInstantiate.Size = new System.Drawing.Size(143, 37);
            this.btnInstantiate.TabIndex = 2;
            this.btnInstantiate.Text = "Instantiate Class";
            this.btnInstantiate.UseVisualStyleBackColor = true;
            this.btnInstantiate.Click += new System.EventHandler(this.btnInstantiate_Click);
            // 
            // frmBurger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 313);
            this.Controls.Add(this.btnInstantiate);
            this.Controls.Add(this.grpCondiments);
            this.Controls.Add(this.grpBurgerType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBurger";
            this.Text = "Build A Burger";
            this.grpBurgerType.ResumeLayout(false);
            this.grpBurgerType.PerformLayout();
            this.grpCondiments.ResumeLayout(false);
            this.grpCondiments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBurgerType;
        private System.Windows.Forms.RadioButton radSpecial;
        private System.Windows.Forms.RadioButton radRegular;
        private System.Windows.Forms.GroupBox grpCondiments;
        private System.Windows.Forms.CheckBox chkPickles;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkMustard;
        private System.Windows.Forms.CheckBox chkLettuce;
        private System.Windows.Forms.CheckBox chkKetchup;
        private System.Windows.Forms.Button btnInstantiate;
    }
}

