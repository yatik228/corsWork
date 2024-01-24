using CourseWork_OOP_Testing.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP_Testing.Decorator
{
    public abstract class QuestionDecorator : IQuestion
    {
        protected IQuestion _question;

        public QuestionDecorator(IQuestion question)
        {
            _question = question;
        }

        public virtual string QuestionText
        {
            get => _question.QuestionText;
            set => _question.QuestionText = value;
        }

        public virtual double Score
        {
            get => _question.Score;
            set => _question.Score = value;
        }

        public virtual void MarkPerQuestion()
        {
            _question.MarkPerQuestion();
        }

        public virtual void ShowVariants()
        {
            _question.ShowVariants();
        }

        public virtual void AddVariants()
        {
            _question.AddVariants();
        }

        public virtual void EnterCorrectAnswers()
        {
            _question.EnterCorrectAnswers();
        }

        public virtual void GetUserAnswer()
        {
            _question.GetUserAnswer();
        }
    }
}
