using CourseWork_OOP_Testing.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP_Testing.QuestionTypes
{
    class ScaleQuestion : IQuestion
    {
        private string questionText = "";
        private double mark;
        private int userScale;
        private int scale;
        public int Scale
        {
            get
            {
                return scale;
            }

            set
            {
                if (value > 0 && value <= 5)
                {
                    this.scale = value;
                }
            }
        }

        public int UserScale
        {
            get
            {
                return this.userScale;
            }
            set
            {
                this.userScale = value;
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

        public void MarkPerQuestion()
        {
            if (UserScale != Scale)
            {
                Score = 0;
            }
        }

        public void AddVariants()
        {
            Console.WriteLine("Your scale will have variants from 1 to 5.");
        }

        public void EnterCorrectAnswers()
        {
            System.Console.WriteLine("Choose right answer for this question: ");
            Scale = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowVariants()
        {
            System.Console.WriteLine("You can choose one number from 1 to 5.");
        }

        public void GetUserAnswer()
        {
            System.Console.WriteLine("Use only integers!");
            System.Console.WriteLine("Enter your answer: ");
            UserScale = Convert.ToInt32(Console.ReadLine());
        }
    }
}
