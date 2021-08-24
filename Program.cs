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
            Console.WriteLine("   \t+ to Add \t- to Subtract \t/ to Multiply \t * to Divide");
            Console.Write("Your selection ");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"your result is :{num01} + {num02}= " + (num01 + num02));
                    break;
                case "-":
                    Console.WriteLine($"your result is :{num01} - {num02}= " + (num01 - num02));
                    break;
                // user needs to enter a number greater than 0
                case "/":
                    while (num02 == 0)
                    {
                        Console.WriteLine("please Enter a second number greater than 0 ");
                        num02 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"your result is :{num01} / {num02}= " + (num01 / num02));
                    break;

                case "*":
                    Console.WriteLine($"your result is :{num01} * {num02}= " + (num01 * num02));
                    break;
            }
            Console.Write("press the return key to close the Program.");
            Console.ReadKey();

        }
    }
}
