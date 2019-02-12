//INSTANT C# NOTE: Formerly VB.NET project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace CSharpQuiz
{
	public partial class frmQuiz : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnIf = new System.Windows.Forms.Button();
            this.cmbAnswer = new System.Windows.Forms.ComboBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.cmbQuestion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(257, 176);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(197, 43);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "Check with Select Case";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnIf
            // 
            this.btnIf.Location = new System.Drawing.Point(23, 176);
            this.btnIf.Margin = new System.Windows.Forms.Padding(4);
            this.btnIf.Name = "btnIf";
            this.btnIf.Size = new System.Drawing.Size(193, 43);
            this.btnIf.TabIndex = 10;
            this.btnIf.Text = "Check with If...Else";
            this.btnIf.Click += new System.EventHandler(this.btnIf_Click);
            // 
            // cmbAnswer
            // 
            this.cmbAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnswer.Items.AddRange(new object[] {
            "NET Library",
            "TabStop",
            "One less than the matching textbox\'s",
            "TabIndex",
            "GroupBox or Panel",
            "The CLR",
            "The Form",
            "The Button",
            "MessageBox"});
            this.cmbAnswer.Location = new System.Drawing.Point(23, 131);
            this.cmbAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAnswer.Name = "cmbAnswer";
            this.cmbAnswer.Size = new System.Drawing.Size(220, 24);
            this.cmbAnswer.TabIndex = 15;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(23, 101);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(55, 16);
            this.lblAnswer.TabIndex = 14;
            this.lblAnswer.Text = "&Answer:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(23, 22);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(64, 16);
            this.lblQuestion.TabIndex = 12;
            this.lblQuestion.Text = "&Question:";
            // 
            // cmbQuestion
            // 
            this.cmbQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestion.Items.AddRange(new object[] {
            "AcceptButton is a property of which control?",
            "To use two sets of radio buttons on a form, one set must be...",
            "Determines if TAB key causes focus?",
            "Controls program execution at run time?",
            "To use a label as a hot key for a textbox, it\'s TabIndex must be..."});
            this.cmbQuestion.Location = new System.Drawing.Point(23, 52);
            this.cmbQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbQuestion.Name = "cmbQuestion";
            this.cmbQuestion.Size = new System.Drawing.Size(431, 24);
            this.cmbQuestion.TabIndex = 13;
            this.cmbQuestion.SelectedIndexChanged += new System.EventHandler(this.cmbQuestion_SelectedIndexChanged);
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 240);
            this.Controls.Add(this.cmbAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.cmbQuestion);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnIf);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# .NET Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button btnSelect;
        internal System.Windows.Forms.Button btnIf;
        internal ComboBox cmbAnswer;
        internal Label lblAnswer;
        internal Label lblQuestion;
        internal ComboBox cmbQuestion;

	}

} //end of root namespace