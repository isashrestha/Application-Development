using System;
namespace C1.consoleApp.Week2
{
    public class ControlStatement
    {
        public ControlStatement()
        {
        }
        public void userInput(int a , int b)
        {
            if (a > b)
            { Console.WriteLine("a is greater than b");
            }
            else if (a > b)
            {
                Console.WriteLine("b is greater tha a");
            }
            else
            {
                Console.WriteLine("a is Equal to b");
            }
        }
    }
}

