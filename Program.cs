using System;

namespace calculator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02;

            Console.WriteLine("Please enter your first number : ");
            num01 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("please enter your second number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select an option from the following list:");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t/ - Multiply");
            Console.WriteLine("\t* - Divide");
            Console.Write("Your selection ");


        }
    }
}
