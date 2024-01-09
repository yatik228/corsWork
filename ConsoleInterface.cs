using CourseWork_OOP_Testing.AdminFeatures;
using CourseWork_OOP_Testing.auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_OOP_Testing
{
    
    class ConsoleEditor
    {
        public static void CenterText(string text)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = text.Length;

            int leftPadding = (screenWidth - stringWidth) / 2;

            Console.WriteLine(new string(' ', leftPadding) + text);
        }
        public void runConsoleEditor(Editor editor)
        {
            CenterText("Welcome to the testing application.");
            String userAnswer = "";
            while (userAnswer != "1" && userAnswer != "2" && userAnswer != "0")
            {
                CenterText("Do you want to login or register?");
                CenterText("1.Login");
                CenterText("2.Register");
                userAnswer = Console.ReadLine();
                if (userAnswer != "1" && userAnswer != "2" && userAnswer != "0") Console.WriteLine("Invalid input. Try again.");
            }

            if (userAnswer != "0")
            {
                Authorization auth = new Authorization();
                auth.Login(userAnswer);

                String teacherOrNot = "";
                Console.WriteLine("Select what you gonna be: ");
                while (teacherOrNot != "1" && teacherOrNot != "2")
                {
                    Console.WriteLine("1.Teacher");
                    Console.WriteLine("2.Student");
                    Console.Write("Your choise: ");
                    teacherOrNot = Console.ReadLine();
                    if (teacherOrNot != "1" && teacherOrNot != "2") Console.WriteLine("Invalid input. Try again.");
                }

                if (teacherOrNot == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Logged in as teacher. \n\n");
                    int option;
                    bool toContinue = true;
                    while (toContinue)
                    {
                        Console.WriteLine("\n\nOptions available:");
                        Console.WriteLine("1 - add test \n2 - delete test \n3 - edit test name \n4 - print all tests \n5 - edit test \n6 - log out");
                        Console.Write("Choose option: ");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.Clear();
                                editor.AddTest();
                                break;
                            case 2:
                                Console.Clear();
                                editor.DeleteTest();
                                break;
                            case 3:
                                Console.Clear();
                                editor.EditTestName();
                                break;
                            case 4:
                                Console.Clear();
                                editor.PrintAllTests();
                                break;
                            case 5:
                                Console.Clear();
                                editor.EditTest();
                                break;
                            case 6:
                                Console.Clear();
                                toContinue = false;
                                runConsoleEditor(editor);
                                break;
                        }
                    }
                }

                if (teacherOrNot == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Logged in as student.");
                
                    bool toContinue = true;
                    int option;
                    while (toContinue)
                    {
                        Console.WriteLine("Options available:");
                        Console.WriteLine("1 - choose test \n2 - log out");
                        Console.Write("Choose option: ");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                            {
                                if (editor.getListSize() == 0)
                                {
                                    Console.WriteLine("No tests have been created yet.");
                                    break;
                                }
                                editor.PrintAllTests();
                                Console.Write("Choose number of test:");
                                editor.TestPassing(Convert.ToInt32(Console.ReadLine()) - 1);
                                break;
                            }
                                
                            case 2:
                            {
                                toContinue = false;
                                Console.Clear();
                                runConsoleEditor(editor);
                                break;
                            }
                               
                        }
                    }
                }
            }
        }
    }
}
