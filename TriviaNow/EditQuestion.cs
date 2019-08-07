//Zeren Yan CIS 345 9am
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class EditQuestion : Form
    {
        Question tmpQuestion;
        public event QuestionEventHandle UpdateQuestion;
        public EditQuestion()
        {
            InitializeComponent();
        }
        public EditQuestion(Question q)

        {
            //edit question
            this.tmpQuestion = q;

            InitializeComponent();
            questionTextbox.Text = tmpQuestion.QuestionString;
            choiceATextBox.Text = tmpQuestion.Choice1;
            choiceBTextBox.Text = tmpQuestion.Choice2;
            choiceCTextBox.Text = tmpQuestion.Choice3;
            choiceDTextBox.Text = tmpQuestion.Choice4;

            switch (tmpQuestion.CorrectIndex)
            {
                case 0:
                    {
                        aChoiceRadioButton.Checked = true; 
                        break;
                    }
                case 1:
                    {
                        bChoiceRadioButton.Checked = true; 
                        break;

                    }
                case 2:
                    {
                        cChoiceRadioButton.Checked = true; 
                        break;
                    }

                case 3:
                    {
                        dChoiceRadioButton.Checked = true; 
                        break;
                    }

            }
        }
            private void updateButton_Click(object sender, EventArgs e)
        {

            bool textBoxCompletedCheck = true;
            bool radioButtonCheck = false;

            //loop and casting 
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Text == "") { textBoxCompletedCheck = false; }
                }

                if (c is RadioButton)
                {
                    if (((RadioButton)c).Checked == true)
                    { radioButtonCheck = true; }
                }
            }
            //check completed or not
            if (textBoxCompletedCheck == false || radioButtonCheck == false)
            { MessageBox.Show("Type incompleted", "Error"); }
            else


            {




                if (aChoiceRadioButton.Checked)
                {
                    tmpQuestion.CorrectAnswer = choiceATextBox.Text;
                    tmpQuestion.CorrectIndex = 0;
                }
                else
            if (bChoiceRadioButton.Checked)
                {

                    tmpQuestion.CorrectAnswer = choiceBTextBox.Text;
                    tmpQuestion.CorrectIndex = 1;

                }
                else
               if (cChoiceRadioButton.Checked)
                {

                    tmpQuestion.CorrectAnswer = choiceCTextBox.Text;
                    tmpQuestion.CorrectIndex = 2;
                }
                else
              if (dChoiceRadioButton.Checked)
                {
                    tmpQuestion.CorrectAnswer = choiceDTextBox.Text;
                    tmpQuestion.CorrectIndex = 3;

                }

                tmpQuestion.QuestionString = questionTextbox.Text;
                questionTextbox.Focus();
                tmpQuestion.FeedBack = feedbackTextBox.Text;
                if (UpdateQuestion != null)
                {
                    UpdateQuestion(tmpQuestion);
                  
                   
                }

                this.Close();
            }
        }

        private void EditQuestion_Load(object sender, EventArgs e)
        {
       
            }

        }
    }

