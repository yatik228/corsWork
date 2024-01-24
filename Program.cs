using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using CourseWork_OOP_Testing.AdminFeatures;
using CourseWork_OOP_Testing;
using CourseWork_OOP_Testing.QuestionTypes;

namespace project
{
    public class Program
    {
        static void Main()
        {
             ConsoleEditor consoleEditor = new ConsoleEditor();
             Editor editor = new Editor();
            consoleEditor.runConsoleEditor(editor);

           


        }
    }
}


