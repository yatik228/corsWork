using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP_Testing.Question
{
    public interface IQuestion
    {
        string QuestionText { get; set; }
        double Score { get; set; }

        void MarkPerQuestion();

        void ShowVariants();

        void AddVariants();

        void EnterCorrectAnswers();

        void GetUserAnswer();
    }
}
