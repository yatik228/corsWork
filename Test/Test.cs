using CourseWork_OOP_Testing.Question;
using CourseWork_OOP_Testing.QuestionFactory;
using CourseWork_OOP_Testing.QuestionTypes;

public class Test
{
    private List<IQuestion> questionsArr = new List<IQuestion>();
    private double resultOfTest;

    private string nameOfTest;

    public Test(string nameOfTest)
    {
        System.Console.WriteLine("Test <<" + nameOfTest + ">> has been created.");
        NameOfTest = nameOfTest;
    }

    public List<IQuestion> QuestionsArr
    {

        get
        {
            return this.questionsArr;
        }

        private set
        {
        }

    }

    public double ResultOfTest
    {

        get
        {
            return this.resultOfTest;
        }

        set
        {
            this.resultOfTest = value;
        }

    }

    public string NameOfTest
    {

        get
        {
            return this.nameOfTest;
        }

        set
        {
            this.nameOfTest = value;
        }

    }

    public void AddQuestionToTest()
    {
        System.Console.WriteLine("Choose the type for this question:\n1. Text answer question;\n2. One right variant question;\n3. Some right variants question\n4. Scale question\n5.Matching Question");
        string type = Console.ReadLine();
        QuestionCreator creator;
        IQuestion questionInTest;
        switch (type)
        {
            case "1":
                creator = new OpenAnswerQuestionCreator();
                questionInTest = creator.FactoryMethod();
                break;
            case "2":
                creator = new OneChoiseQuestionCreator();
                questionInTest = creator.FactoryMethod();
                break;
            case "3":
                creator = new MultipleChoiseQuestionCreator();
                questionInTest = creator.FactoryMethod();
                break;
            case "4":
                creator = new ScaleQuestionCreator();
                questionInTest = creator.FactoryMethod();
                break;
            case "5":
                creator = new MatchingQuestionСreator();
                questionInTest = creator.FactoryMethod();
                break;
            default:
                System.Console.WriteLine("You have automatically chosen text answer question!");
                creator = new OpenAnswerQuestionCreator();
                questionInTest = creator.FactoryMethod();
                break;
        }
        QuestionsArr.Add(questionInTest);
        System.Console.WriteLine("Write your question: ");
        questionInTest.QuestionText = Console.ReadLine();
        questionInTest.AddVariants();
        questionInTest.EnterCorrectAnswers();
        System.Console.WriteLine("Choose the mark for this question: ");
        questionInTest.Score = Convert.ToInt32(Console.ReadLine());
    }

    public void DeleteQuestionFromTest()
    {
        System.Console.Write("Please choose the number of the question you want to delete: ");
        int num = Convert.ToInt32(Console.ReadLine());
        questionsArr.RemoveAt(num - 1);
    }

    public void ChangePlaceInTest()
    {
        System.Console.Write("Choose the number of the question which place you want to change: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Choose the number of the second question which place the first question will be changed with: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        IQuestion temp = QuestionsArr[num1 - 1];
        QuestionsArr[num1 - 1] = QuestionsArr[num2 - 1];
        QuestionsArr[num2 - 1] = temp;
    }

    public void EditQuestionInTest()
    {

        Console.Write("Which question you want to change: ");
        int numOfQ = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Do you want to change the text of the question? 1 - yes, 2 - no");
        Console.Write("Your choise: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 == 1)
        {
            System.Console.Write("Enter your question: ");
            QuestionsArr[numOfQ - 1].QuestionText = Console.ReadLine();
        }
        System.Console.WriteLine("Do you want to change the type of the question? 1 - yes, 2 - no");
        Console.Write("Your choise: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num2 == 1)
        {
            System.Console.WriteLine("Choose the type for this question: \n1.Text answer question;\n2. One right variant question;\n3. Some right variants question\n4. Scale question\n5.Matching Question");
            string type = Console.ReadLine();
            QuestionCreator creator;
            switch (type)
            {
                case "1":
                    creator = new OpenAnswerQuestionCreator();
                    QuestionsArr[numOfQ - 1] = creator.FactoryMethod();
                    break;
                case "2":
                    creator = new OneChoiseQuestionCreator();
                    QuestionsArr[numOfQ - 1] = creator.FactoryMethod();
                    break;
                case "3":
                    creator = new MultipleChoiseQuestionCreator();
                    QuestionsArr[numOfQ - 1] = creator.FactoryMethod();
                    break;
                case "4":
                    creator = new ScaleQuestionCreator();
                    QuestionsArr[numOfQ - 1] = creator.FactoryMethod();
                    break;
                case "5":
                    creator = new MatchingQuestionСreator();
                    QuestionsArr[numOfQ - 1] = creator.FactoryMethod();
                    break;
                default:
                    //System.Console.WriteLine("You have automatically chosen text answer question!");
                    creator = new OpenAnswerQuestionCreator();
                    QuestionsArr[numOfQ - 1] = creator.FactoryMethod();
                    break;
            }

            System.Console.WriteLine("Type of you question is " + QuestionsArr[numOfQ - 1].GetType());

        }
        else if (num2 == 2)
        {
            System.Console.WriteLine("Nothing is changed.");
        }
        System.Console.WriteLine("Do you want to change the mark for the question? 1 - yes, 2 - no");
        int num3 = Convert.ToInt32(Console.ReadLine());
        if (num3 == 1)
        {
            System.Console.Write("Choose the mark for this question: ");
            QuestionsArr[numOfQ - 1].Score = Convert.ToInt32(Console.ReadLine());
        }
    }
}