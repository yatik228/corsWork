using CourseWork_OOP_Testing.Question;
using CourseWork_OOP_Testing.QuestionImplementation;
using CourseWork_OOP_Testing.QuestionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP_Testing.QuestionFactory
{
    abstract class QuestionCreator
    {
        public abstract IQuestion FactoryMethod();

        public IQuestion CreateQuestion()
        {
            return FactoryMethod();
        }
    }

    class OneChoiseQuestionCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new OneChoiseQuestion();
        }
    }

    class MultipleChoiseQuestionCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new MultipleChoiseQuestion();
        }
    }
    class OpenAnswerQuestionCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new OpenAnswerQuestion();
        }
    }
    class ScaleQuestionCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new ScaleQuestion();
        }
    }
    class MatchingQuestionСreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new MatchingQuestion();
        }
    }

    class DefaultQuestionCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new DefaultQuestion();
        }
    }




}
