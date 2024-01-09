using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CourseWork_OOP_Testing.auth
{
    public class Users
    {
        public string username;
        public string password;

        public Users(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
    public class Authorization
    {
        bool login_success = false;
        public void Login(string input)
        {
            var arrUsers = new Users[]
            {
                new Users("Anton","2004"),
                new Users("Yarik", "1994"),
                new Users("Vika", "2003")
            };

            while (!login_success)
            {
                if (input == "1")
                {
                    Console.Write("Write your username: ");
                    var username = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    var password = Console.ReadLine();


                    foreach (Users user in arrUsers)
                    {
                        if (username == user.username && password == user.password)
                        {
                            Console.WriteLine("You have successfully logged in. Please press enter...");
                            Console.ReadLine();
                            login_success = true;
                            break;
                        }
                    }

                    if (!login_success)
                    {
                        Console.WriteLine("Your username or password is incorect, try again");
                    }

                }
                else if (input == "2")
                {

                    Console.WriteLine("Create your username:");
                    var username = Console.ReadLine();

                    Console.WriteLine("Create your password:");
                    var password = Console.ReadLine();

                    Array.Resize(ref arrUsers, arrUsers.Length + 1);
                    arrUsers[arrUsers.Length - 1] = new Users(username, password);
                    Console.WriteLine("Account created");
                    input = "1";
                }
                else
                {
                    Console.WriteLine("Wrong Login/Password");
                    break;
                }

            }
        }
    }
}


