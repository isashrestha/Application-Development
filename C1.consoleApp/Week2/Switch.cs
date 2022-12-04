using System;
namespace C1.consoleApp.Week2
{

    public class Switch
    {
        public Switch()
        {

        }

        public void Switchcase()
        {
            int result = 0;
            switch (result)
            {
                case 1:
                    {
                        result = Addition(input_one, input_two);
                        break;
                    }


                case 2:
                    {
                        result = Subtraction(input_one, input_two);
                        break;
                    }

                case 3:
                    {
                        result = Multiplication(input_one, input_two);
                        break;
                    }

                case 4:
                    {
                        result = Division(input_one, input_two);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!!");
                    break;


            }
        }
 Console.WriteLine("The result is {0}", result);
 Console.ReadKey();

    }

}


    

        
    

