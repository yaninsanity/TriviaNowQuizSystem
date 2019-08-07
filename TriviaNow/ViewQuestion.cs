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
    public delegate void SavingChanges (BindingList<Question> NewList );
    public partial class ViewQuestion : Form
    {
        EditQuestion myEditForm;
        
        public event SavingChanges NewList;

        BindingList<Question> searchQuestionList;


        BindingList<Question> questionList;
        string tmpLongString;
        int currentListBoxIndex;
        int editIndex = 0;
        public ViewQuestion()
        {
            InitializeComponent();
        }

        public ViewQuestion(BindingList<Question> myQuestionList)
        {
            
            questionList = myQuestionList;
            InitializeComponent();
        }

        private void ViewQuestion_Load(object sender, EventArgs e)
        {
            questionListBox.DataSource = questionList;
       


        }

       

        private void editButton_Click(object sender, EventArgs e)
        {
            //edit the list
            if (questionListBox.SelectedItem == null)
            { MessageBox.Show("Please select the question.","Error"); }
            else
            {
                Question tmpQuestion = (Question)questionListBox.SelectedItem;
                myEditForm = new EditQuestion(tmpQuestion);
                myEditForm.Show();
                editIndex = questionList.IndexOf(tmpQuestion);
                currentListBoxIndex = questionListBox.SelectedIndex;
                myEditForm.UpdateQuestion += new QuestionEventHandle(this.QuestionUpdate);
                
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //remove from the list

            if (questionListBox.SelectedItem == null)
            { MessageBox.Show("Please select the question.", "Error"); }
            else
            {
                Question tmpQuestion = (Question)questionListBox.SelectedItem;

                if (questionListBox.DataSource == searchQuestionList)
                {
                    searchQuestionList.Remove(tmpQuestion);
                }
                questionList.Remove(tmpQuestion);
                
                

            }
        }

        private void QuestionUpdate(Question tmpQuestion)
        {
            //Update Question 
            
            if (questionListBox.DataSource == searchQuestionList)
            {
                
                        searchQuestionList[currentListBoxIndex] = tmpQuestion;
                        searchQuestionList.ResetBindings();
                        questionListBox.Refresh();
                    
                }
            

            questionList[editIndex] = tmpQuestion;
            questionList.ResetBindings();
            questionListBox.Refresh();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (NewList!= null)
            {
                NewList(questionList);
            }
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchQuestionList = new BindingList<Question>();
            if (searchTextBox.Text == null)
            {
                MessageBox.Show("Please type keyword into the search box!","TrivaNow");
            }
            else
            {
                string keyWord = searchTextBox.Text;
               
                foreach (Question q in questionList)
                {
                    tmpLongString = q.QuestionString + " " + q.Choice1 + " " + q.Choice2 + " " + q.Choice3 + " " + q.Choice4 + " " + q.FeedBack;
                    tmpLongString=tmpLongString.ToUpper();
                    if (tmpLongString.Contains(keyWord.ToUpper()))
                    {
                        searchQuestionList.Add(q);
                        
                        
                    }

                   
                }

            }

            if (searchQuestionList.Count() == 0)
            {
                MessageBox.Show("Not Found!", "TrivaNow");


            }
            else
            {
                questionListBox.DataSource = searchQuestionList;

            }

        }

        

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            questionListBox.DataSource = questionList;
        }
    }
}
