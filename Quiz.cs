using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    internal class Quiz
    {
        private Questions[] questions;

        public Quiz(Questions[] questions)
        {
            this.questions = questions;
        }
        private void DisplayQuestion(Questions questions)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("┌────────────────────────────────────┐\r\n" +
                              "│              Question              │\r\n" +
                              "└────────────────────────────────────┘");
            Console.WriteLine(questions.QuestionText);
            for (int i= 0;i<questions.Answers.Length;i++)
            {
               
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("    ");
                Console.Write(i+1);
                Console.ResetColor();
                Console.WriteLine($". {questions.Answers[i]}");
            }
           /* if(GetUserChoice() == questions.CorrectAnswerIndex)
            {
                Console.WriteLine("Correct ");
            }
            else
            {
                Console.WriteLine("Incorrect ");
            }*/
        }
        public int GetUserChoice()
        {
            int choice = 0;
            Console.Write("Your answer (number):");
            string userAnswer = Console.ReadLine();
            while(!int.TryParse(userAnswer,out choice)|| choice < 1||choice>4)
            {
                Console.WriteLine("Invalid choice.Please enter between 1 and 4 :");
                userAnswer = Console.ReadLine();
            }
            return choice-1;
        }
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the quiz.");
            int questionNumber = 1;

            foreach (Questions question in questions)
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);
                int  userChoice = GetUserChoice();
                if(question.IsCorrect(userChoice))
                {
                    Console.WriteLine("Correct!!");
                }
                else
                {
                    Console.WriteLine($"Wrong!!!The correct answer was: {question.CorrectAnswerIndex}");
                }
            }
        }
    }
}
