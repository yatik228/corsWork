using CourseWork_OOP_Testing.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP_Testing.QuestionTypes
{
    class OpenAnswerQuestion : IQuestion
    {
        private string questionText = "";
        private double mark;
        private String textAnswer = "";
        private string userAnswer = "";

        public String TextAnswer
        {
            get
            {
                return textAnswer;
            }
            set
            {
                this.textAnswer = value;
            }
        }

        public string QuestionText
        {
            get
            {
                return this.questionText;
            }

            set
            {
                this.questionText = value;
            }
        }

        public double Score
        {
            get
            {
                return this.mark;
            }

            set
            {
                this.mark = value;
            }
        }

        public string UserAnswer
        {
            get
            {
                return userAnswer;
            }
            set
            {
                this.userAnswer = value;
            }
        }

        public void MarkPerQuestion()
        {
            if (UserAnswer != TextAnswer)
            {
                Score = 0;
            }
        }

        public void AddVariants()
        {
            return;
        }

        public void EnterCorrectAnswers()
        {
            System.Console.WriteLine("Choose right answer for this question: ");
            TextAnswer = Console.ReadLine();
        }

        public void ShowVariants()
        {
            return;
        }

        public void GetUserAnswer()
        {
            System.Console.WriteLine("Use only strings");
            System.Console.WriteLine("Enter your answer: ");
            UserAnswer = Console.ReadLine();
        }
    }
}
