using System;
namespace C1.consoleApp.Week2
{
    public class Do
    {
        public Do()
        {
        }
        public void dowhile()
        {
            string password;
            do
            {
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();
            }
            while (password != "SecretPassword");
        }
    }
}

