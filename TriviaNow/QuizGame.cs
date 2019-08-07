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
    
    public partial class QuizGame : Form
    {
        int[] questionIndex;
        BindingList<Question> myQuestionpool;

        int quizQuestionNum;
        int index=0;
        int correctCount = 0;
        int myPickIndex;
        //int myQuestionOrder=0;
        bool chooseCheck=false;
        double currentGrade;
        Question tmpQuestion;

        public QuizGame()
        {
            InitializeComponent();
        }
        public QuizGame(BindingList<Question>tmpQuestionList,int questionNum)
        {
            myQuestionpool = tmpQuestionList;
            quizQuestionNum=questionNum;
            
            InitializeComponent();

        }

        private void QuizGame_Load(object sender, EventArgs e)
        {
            questionIndex = new int[quizQuestionNum];
            do
                //random the number
            {

                Random r = new Random();
                bool  randomRepeat = false;
                int tmpRandom = r.Next(0, myQuestionpool.Count());
                for (int i = 0; i < questionIndex.Length; i++)
                {

                    if (questionIndex[i] == tmpRandom) { randomRepeat = true; }
                }

                if (randomRepeat) { index--; randomRepeat = false; }
                else { questionIndex[index] = tmpRandom; }
                index++;
            } while (index < questionIndex.Length);


            index = 0;
            tmpQuestion = myQuestionpool[questionIndex[index]];

            questionTitleLabel.Text = $"{index + 1}/{quizQuestionNum}. {tmpQuestion.QuestionString}";
            choice1Label.Text = $"{tmpQuestion.Choice1}";
            choice2Label.Text = $"{tmpQuestion.Choice2}";
            choice3Label.Text = $"{tmpQuestion.Choice3}";
            choice4Label.Text = $"{tmpQuestion.Choice4}";



            answerAndFeedbackLabel.Hide();
            nextButton.Enabled = false;

        }



        //save answer
        private void saveAnswer_Click(object sender, EventArgs e)
        {
            saveAnswerButton.Enabled = false;
            //check if select the answer
            foreach (Control c in Controls)
            {
                if (c is RadioButton)
                {
                    if (((RadioButton)c).Checked == true)
                    {
                        chooseCheck = true;
                    }
                }
            }
            if (chooseCheck == false)
            {
                MessageBox.Show("Please select the answer", "Error");

            }
            else
            {

                //check the answer right


                if (aChoiceRadioButton.Checked)
                { myPickIndex = 0; }

                else
            if (bChoiceRadioButton.Checked)
                {

                    myPickIndex = 1;

                }
                else
               if (cChoiceRadioButton.Checked)
                {
                    myPickIndex = 2;
                }
                else
              if (dChoiceRadioButton.Checked)
                {
                    myPickIndex = 3;

                }


                if (myPickIndex == tmpQuestion.CorrectIndex) {
                    MessageBox.Show("Congradualation! You are right!!");
                    correctCount++;
                }
                else
                { MessageBox.Show("You miss one question."); }


                answerAndFeedbackLabel.Text = ($"The correct answer is --- {tmpQuestion.CorrectAnswer}\nFeedback:{tmpQuestion.FeedBack}");
                answerAndFeedbackLabel.Show();
                nextButton.Enabled = true;


                currentGrade = ((double)correctCount / (index+1) * 100);
                currentGradeLabel.Text = $"Grade:{correctCount}/{index+1}={currentGrade:f2}%";


                foreach (Control c in Controls)
                {
                    if (c is RadioButton)
                    {
                        ((RadioButton)c).Checked = false;
                    }
                }






            }

            }

        private void nextButton_Click(object sender, EventArgs e)
        {

          
            index++;
          
            nextButton.Enabled = false;
            saveAnswerButton.Enabled = true;
            if (index < questionIndex.Count())
            {
              
                tmpQuestion = myQuestionpool[questionIndex[index]];

                questionTitleLabel.Text = $"{index + 1}/{quizQuestionNum}. {tmpQuestion.QuestionString}";
                choice1Label.Text = $"{tmpQuestion.Choice1}";
                choice2Label.Text = $"{tmpQuestion.Choice2}";
                choice3Label.Text = $"{tmpQuestion.Choice3}";
                choice4Label.Text = $"{tmpQuestion.Choice4}";



                answerAndFeedbackLabel.Hide();
                
            }
            else
            {
                MessageBox.Show($"Congratulations !! Your score is {correctCount}/{questionIndex.Count()}----{currentGrade:f2}%","TriviaNow Final Grade");
                this.Close();
            }
           
        }
    }
    }
