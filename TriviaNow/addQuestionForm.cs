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
    public delegate void QuestionEventHandle(Question q);

    public partial class addQuestionForm : Form

    {
        public event QuestionEventHandle QuestionCreated;

        Question tmpQuestion;
        public addQuestionForm()
        {
            InitializeComponent();
        }

        private void choiceDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void choiceCTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void choiceBTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void choiceATextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addQuestionForm_Load(object sender, EventArgs e)
        {

        }

    

        private void addButton_Click_1(object sender, EventArgs e)
        {
            tmpQuestion = new Question();
            tmpQuestion.QuestionString = questionTextbox.Text;
            tmpQuestion.Choice1 = choiceATextBox.Text;
            tmpQuestion.Choice2 = choiceBTextBox.Text;
            tmpQuestion.Choice3 = choiceCTextBox.Text;
            tmpQuestion.Choice4 = choiceDTextBox.Text;
            bool textBoxCompletedCheck = true;
            bool radioButtonCheck = false;
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

                questionTextbox.Focus();
                tmpQuestion.FeedBack = feedbackTextBox.Text;
                if (QuestionCreated != null)
                {
                    QuestionCreated(tmpQuestion);
                }

                //clean up all textbox and radio button


                foreach (Control tmpC in this.Controls)
                {
                    if (tmpC is TextBox) { ((TextBox)tmpC).Text = ""; }
                    if (tmpC is RadioButton) { ((RadioButton)tmpC).Checked = false; }
                }





            }

        }
    }




}


