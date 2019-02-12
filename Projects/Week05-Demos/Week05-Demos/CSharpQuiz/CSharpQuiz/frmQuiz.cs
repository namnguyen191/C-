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
	public partial class frmQuiz
	{

		internal frmQuiz()
		{
			InitializeComponent();
		}
		private void btnIf_Click(object sender, System.EventArgs e)
		{
			if (cmbQuestion.SelectedIndex == -1)
			{
				MessageBox.Show("Please select a question");
				cmbQuestion.Focus();
				return;
			}
			if (cmbAnswer.SelectedIndex == -1)
			{
				MessageBox.Show("Please select an answer");
				cmbAnswer.Focus();
				return;
			}

			if (cmbQuestion.SelectedIndex == 0 && cmbAnswer.SelectedIndex == 6)
			{
				MessageBox.Show("Correct!", "Quiz");
			}
			else if (cmbQuestion.SelectedIndex == 1 && cmbAnswer.SelectedIndex == 4)
			{
				MessageBox.Show("Correct!", "Quiz");
			}
			else if (cmbQuestion.SelectedIndex == 2 && cmbAnswer.SelectedIndex == 1)
			{
				MessageBox.Show("Correct!", "Quiz");
			}
			else if (cmbQuestion.SelectedIndex == 3 && cmbAnswer.SelectedIndex == 5)
			{
				MessageBox.Show("Correct!", "Quiz");
			}
			else if (cmbQuestion.SelectedIndex == 4 && cmbAnswer.SelectedIndex == 2)
			{
				MessageBox.Show("Correct!", "Quiz");
			}
			else
			{
				MessageBox.Show("Incorrect!", "Quiz");
			}
		}

		private void btnSelect_Click(object sender, System.EventArgs e)
		{
			if (cmbQuestion.SelectedIndex == -1)
			{
				MessageBox.Show("Please select a question", "Error");
				cmbQuestion.Focus();
				return;
			}
			if (cmbAnswer.SelectedIndex == -1)
			{
				MessageBox.Show("Please select an answer", "Error");
				cmbAnswer.Focus();
				return;
			}
			switch (cmbQuestion.SelectedIndex)
			{
				case 0:

					if (cmbAnswer.SelectedIndex == 6)
					{
						MessageBox.Show("Correct!", "Quiz");

					}
					else
					{
						MessageBox.Show("Incorrect!", "Quiz");
					}
					break;
				case 1:
					if (cmbAnswer.SelectedIndex == 4)
					{
						MessageBox.Show("Correct!", "Quiz");
					}
					else
					{
						MessageBox.Show("Incorrect!", "Quiz");
					}
					break;
				case 2:
					if (cmbAnswer.SelectedIndex == 1)
					{
						MessageBox.Show("Correct!", "Quiz");
					}
					else
					{
						MessageBox.Show("Incorrect!", "Quiz");
					}
					break;
				case 3:
					if (cmbAnswer.SelectedIndex == 5)
					{
						MessageBox.Show("Correct!", "Quiz");
					}
					else
					{
						MessageBox.Show("Incorrect!", "Quiz");
					}
					break;
				case 4:
					if (cmbAnswer.SelectedIndex == 2)
					{
						MessageBox.Show("Correct!", "Quiz");
					}
					else
					{
						MessageBox.Show("Incorrect!", "Quiz");
					}
					break;
				default:
					MessageBox.Show("Incorrect!", "Quiz");
					break;
			}
		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

	}

} //end of root namespace