using CourseWork_OOP_Testing.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP_Testing.QuestionTypes
{
    class MultipleChoiseQuestion : IQuestion
    {
        private string questionText = "";
        private double mark;
        private List<String> variantAsnwerArr = new List<String>();
        private List<int> rightVariantsAnswer = new List<int>();
        private List<int> userAnswer = new List<int>();

        public List<String> VariantAnswerArr
        {
            get
            {
                return this.variantAsnwerArr;
            }
            set
            {
                this.variantAsnwerArr = value;
            }
        }

        public List<int> RightVariantsAnswer
        {
            get
            {
                return this.rightVariantsAnswer;
            }
            set
            {
                this.rightVariantsAnswer = value;
            }
        }

        public List<int> UserAnswer
        {
            get
            {
                return this.userAnswer;
            }
            set
            {
                this.userAnswer = value;
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
            double counter = 0;
            for (int i = 0; i < userAnswer.Count; i++)
            {
                if (rightVariantsAnswer.Contains(userAnswer[i]))
                {
                    counter += Score / rightVariantsAnswer.Count;
                }
            }
            Score = counter;
        }

        public void AddVariants()
        {
            System.Console.WriteLine("Enter amount of variants: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter variants of answers: ");
            for (int i = 0; i < amount; i++)
            {
                System.Console.WriteLine((i + 1) + ":");
                VariantAnswerArr.Add(Console.ReadLine());
            }
        }

        public void EnterCorrectAnswers()
        {
            System.Console.WriteLine("How many right answers are you planning?");
            int amount = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter right answers: ");
            for (int i = 0; i < amount; i++)
            {
                System.Console.WriteLine((i + 1) + ":");
                rightVariantsAnswer.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }

        public void ShowVariants()
        {
            for (int i = 0; i < variantAsnwerArr.Count; i++)
            {
                System.Console.WriteLine((i + 1) + ". " + variantAsnwerArr[i]);
            }
        }

        public void GetUserAnswer()
        {
            Console.WriteLine("How many answers are you planning?");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Use only integers!");
            Console.WriteLine("Enter your answers: ");
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"{i + 1}: ");
                int answer;
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    UserAnswer.Add(answer);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    i--; // Decrement i to re-enter the current iteration
                }
            }
        }

    }
}
