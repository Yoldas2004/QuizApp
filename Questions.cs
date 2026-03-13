using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    internal class Questions
    {
        public string  QuestionText{ get; set; }
        public string [] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public Questions(string quesionText, string[] answers,int correctAnswerIndex)
        {
            QuestionText = quesionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
        public bool IsCorrect(int choice)
        {
            return CorrectAnswerIndex == choice;
        }
        
    }
}
