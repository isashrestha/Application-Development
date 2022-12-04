using System;
namespace C1.consoleApp.Week3
{
    public class Animal
    {
        public Animal()
        {
        }
        public void display()
        {
            Console.WriteLine("I am an animal");
        }
        protected void displaypvt()
        {
            Console.WriteLine("I am an animal"); //inside a protected method
        }


    }

    class Cat: Animal
    {
        public void displaycat()
        {
            Console.WriteLine("I am a cat");
        }

    }

    class Isha
    {
        public static void ishas()
        {
            Cat obj = new Cat();
            obj.displaycat();
            Console.ReadLine();

        }
    }

}



