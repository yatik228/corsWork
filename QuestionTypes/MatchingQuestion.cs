using CourseWork_OOP_Testing.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP_Testing.QuestionTypes
{
    public class MatchingQuestion : IQuestion
    {
        private string questionText = "";
        private double mark;
        private List<string> leftColumn = new List<string>();
        private List<string> rightColumn = new List<string>();
        private Dictionary<string, string> correctMatches = new Dictionary<string, string>();
        private Dictionary<string, string> userMatches = new Dictionary<string, string>();

        public List<string> LeftColumn
        {
            get { return this.leftColumn; }
            set { this.leftColumn = value; }
        }

        public List<string> RightColumn
        {
            get { return this.rightColumn; }
            set { this.rightColumn = value; }
        }

        public Dictionary<string, string> CorrectMatches
        {
            get { return this.correctMatches; }
            set { this.correctMatches = value; }
        }

        public Dictionary<string, string> UserMatches
        {
            get { return this.userMatches; }
            set { this.userMatches = value; }
        }

        public string QuestionText
        {
            get { return this.questionText; }
            set { this.questionText = value; }
        }

        public double Score
        {
            get { return this.mark; }
            set { this.mark = value; }
        }

        public void MarkPerQuestion()
        {
            bool allMatchesCorrect = true;

            foreach (var pair in CorrectMatches)
            {
                if (!UserMatches.ContainsKey(pair.Key) || UserMatches[pair.Key] != pair.Value)
                {
                    allMatchesCorrect = false;
                    break;
                }
            }

            Score = allMatchesCorrect ? 1.0 : 0.0;
        }

        public void AddVariants()
        {
            Console.WriteLine("Enter the number of pairs: ");
            int numberOfPairs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the pairs (left element - right element): ");
            for (int i = 0; i < numberOfPairs; i++)
            {
                Console.Write($"Pair {i + 1}: ");
                string[] pair = Console.ReadLine().Split('-');

                if (pair.Length == 2)
                {
                    LeftColumn.Add(pair[0]);
                    RightColumn.Add(pair[1]);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter pairs in the format 'left element - right element'.");
                    i--;
                }
            }
        }

        public void EnterCorrectAnswers()
        {
            Console.WriteLine("Enter the correct matches (left element - right element): ");
            for (int i = 0; i < LeftColumn.Count; i++)
            {
                Console.Write($"{LeftColumn[i]} - ");
                CorrectMatches[LeftColumn[i]] = Console.ReadLine();
            }
        }

        public void ShowVariants()
        {
            for (int i = 0; i < LeftColumn.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {LeftColumn[i]} - {RightColumn[i]}");
            }
        }

        public void GetUserAnswer()
        {
            Console.WriteLine("Enter your matches (left element - right element): ");
            for (int i = 0; i < LeftColumn.Count; i++)
            {
                Console.Write($"{LeftColumn[i]} - ");
                UserMatches[LeftColumn[i]] = Console.ReadLine();
            }
        }
    }
}
