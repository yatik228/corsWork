using CourseWork_OOP_Testing.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP_Testing.Decorator
{
     class OpenAnswerQuestionDecorator : QuestionDecorator
    {
        public OpenAnswerQuestionDecorator(IQuestion question) : base(question)
        {
        }
        public override string QuestionText
        {
            get { return base.QuestionText; }
            set { base.QuestionText = value; }
        }

        public override double Score
        {
            get { return base.Score; }
            set { base.Score = value; }
        }

        public override void MarkPerQuestion()
        {
            base.MarkPerQuestion();
        }

        public override void ShowVariants()
        {
            base.ShowVariants();
        }

        public override void AddVariants()
        {

            base.AddVariants();
        }

        public override void EnterCorrectAnswers()
        {
            base.EnterCorrectAnswers();
        }



        public override void GetUserAnswer()
        {
            base.GetUserAnswer();
        }
    }
}
