//Zeren Yan CIS 345 9am
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class TriviaNow : Form
    {
        int numOfQuestion = 0;
        BindingList<Question> questionList;
        addQuestionForm tmpAddQuestionForm;
        ViewQuestion tmpViewQuestionForm;
        QuizGame myGame;
        help myHelp;

        public TriviaNow()
        {
            InitializeComponent();
        }

        private void TriviaNow_Load(object sender, EventArgs e)
        {
            quizQuestionNumberTextBox.Focus();
            questionNumDisplayLabel.Text = $"Number Of Question in the System ----- {numOfQuestion}";

            questionList = new BindingList<Question>();

            battleButton.Enabled = false;
        }

       

        private void QuestionForm_newQuestionCreated(Question q)
        {
            questionList.Add(q);

            numOfQuestion = questionList.Count();
            questionNumDisplayLabel.Text = $"Number Of Question in the System ----- {numOfQuestion}";
            statusLabel.Text = $"New Question Creaded! The System has {numOfQuestion} right now.";
            timer.Enabled = true;


        }

      

        private void statusLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void questionNumDisplayLabel_Click(object sender, EventArgs e)
        {

        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instantiate a new question entry form
            tmpAddQuestionForm = new addQuestionForm();
            tmpAddQuestionForm.QuestionCreated += new QuestionEventHandle(this.QuestionForm_newQuestionCreated);
            tmpAddQuestionForm.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //check the time
            timer.Enabled = false;
            statusLabel.Text = "Ready";
        }

        private void viewQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmpViewQuestionForm=new ViewQuestion(this.questionList);
            tmpViewQuestionForm.Show();
            tmpViewQuestionForm.NewList += new SavingChanges(this.UpdateMyList);
        }

        //open file
        private void openQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.FileName = "";
                openFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    questionList = (BindingList<Question>)bf.Deserialize(file);
                    numOfQuestion = questionList.Count();
                    statusLabel.Text = $"{numOfQuestion} questions are loaded";
                    questionNumDisplayLabel.Text = $"Number Of Question in the System ----- {numOfQuestion}";
                    timer.Enabled = true;
                }

            }
            catch (Exception)
            {

                statusLabel.Text = "Data loading not successful";
            }
        }

        //save file
        private void saveQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                try
                {
                    FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, questionList);
                    file.Close();
                    statusLabel.Text = "File saved.";
                    timer.Enabled = true;
                }
                catch (Exception)
                {

                    statusLabel.Text = "Save Not successful";
                    timer.Enabled = true;
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit application
            System.Environment.Exit(0);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int quizQuestionNumber;


            if (numOfQuestion < 3)
            {
                MessageBox.Show("Please add or load question into the system", "TriviaNow");

            }
            else

            {
                try
            {
                quizQuestionNumber = Convert.ToInt32(quizQuestionNumberTextBox.Text);

            }
            catch (FormatException)
            {
                if (quizQuestionNumberTextBox.Text == null)
                {
                    MessageBox.Show("Please enter the number of questions for the quiz.", "TriviaNow Error");
                    return;
                }
                else
                {
                    MessageBox.Show("The number in TextBox has to be numeric.", "TriviaNow Error");
                    return;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number is large.","TriviaNow");
                return;
            }

            



          
                if (quizQuestionNumber > numOfQuestion) { MessageBox.Show("There are not so many questions in the pools, please add more", "TriviaNow Error"); }
                else if (quizQuestionNumber < 3) { MessageBox.Show("The minimum number of quiz questions is three", "TriviaNow Error"); }
                else
                {
                    myGame = new QuizGame(questionList,quizQuestionNumber);
                    myGame.Show();
                }
            }
         

  
        }
        private void UpdateMyList(BindingList<Question>editedQuestionList)
        {
            questionList = editedQuestionList;
            questionList.ResetBindings();
            numOfQuestion = questionList.Count();
            questionNumDisplayLabel.Text = $"Number Of Question in the System ----- {numOfQuestion}";
            statusLabel.Text = $"{numOfQuestion} questions are just updated";
            timer.Enabled = true;
        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myHelp = new help();
            myHelp.Show();
            
        }

        private void battleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
