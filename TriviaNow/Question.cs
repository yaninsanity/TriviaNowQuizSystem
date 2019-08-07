//Zeren Yan CIS 345 9am
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNow
{
    [Serializable]
    public class Question
    {
        private string questionString;
        private string choice1;
        private string choice2;
        private string choice3;
        private string choice4;
        private string correctAnswer;

        private string feedBack;


        private int correctIndex;
        public Question()
        {
        }


        public string QuestionString { get => questionString; set => questionString = value; }
        public string Choice1 { get => choice1; set => choice1 = value; }
        public string Choice2 { get => choice2; set => choice2 = value; }
        public string Choice3 { get => choice3; set => choice3 = value; }
        public string Choice4 { get => choice4; set => choice4 = value; }
        public string CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public string FeedBack { get => feedBack; set => feedBack = value; }
        public int CorrectIndex { get => correctIndex; set => correctIndex = value; }


        public override string ToString()
        {
            return questionString;
        }
    }
}
