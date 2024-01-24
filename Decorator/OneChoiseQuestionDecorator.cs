using CourseWork_OOP_Testing.Question;
using CourseWork_OOP_Testing.QuestionTypes;

namespace CourseWork_OOP_Testing.Decorator
{

    public class OneChoiseQuestionDecorator : QuestionDecorator
    {
        private IQuestion decoratedQuestion;
        private bool _userAnswerReceived;
        private bool _timeExpired;
        private double _defaultScore = 0;
        private CancellationTokenSource _cancellationTokenSource;

        public OneChoiseQuestionDecorator(IQuestion question) : base(question)
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

            // После выполнения оригинального метода проверяем условие таймера
            if (!_userAnswerReceived && _timeExpired)
            {
                Score = _defaultScore;
                Console.WriteLine("Time is up! Your score for this question is 0.");
            }
        }

        public override void ShowVariants()
        {
            base.ShowVariants();
        }

        public override void AddVariants()
        {
 
            Console.WriteLine("Custom logic in AddVariants of the decorator.");

    
            base.AddVariants();
        }

        public override void EnterCorrectAnswers()
        {

            Console.WriteLine("Custom logic in EnterCorrectAnswers of the decorator.");

 
            base.EnterCorrectAnswers();
        }

        public void GetUserAnswerWithTimer()
        {
            Console.WriteLine("You have 10 seconds to choose your answer:");

            _cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = _cancellationTokenSource.Token;

            var delayTask = Task.Delay(TimeSpan.FromSeconds(10), cancellationToken);
            var getUserAnswerTask = Task.Run(() =>
            {
                GetUserAnswer(); 
                _userAnswerReceived = true;
            });

            // Ожидаем, когда одна из задач завершится
            var completedTask = Task.WaitAny(delayTask, getUserAnswerTask);

            if (completedTask == 0)
            {
                _timeExpired = true;
            }
            else if (completedTask == 1)
            {
                // Пользователь ввел ответ, отменяем таймер
                _cancellationTokenSource.Cancel();
            }
        }

        public override void GetUserAnswer()
        {
            base.GetUserAnswer();
        }
    }

}