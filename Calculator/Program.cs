using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice;
            int Number1;
            int Number2;
            int Result;

            Console.WriteLine("Please select an option from the list: ");
            Console.WriteLine("1:  Add");
            Console.WriteLine("2:  Substruct");
            Console.WriteLine("3:  Multiply");
            Console.WriteLine("4:  Divide");
            Choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please select the first number: ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please select the second number: ");
            Number2 = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Result = Number1 + Number2;
                    Console.WriteLine("Your result: " + Result);
                    break;
                case 2:
                    Result = Number1 - Number2;
                    Console.WriteLine("Your result: " + Result);
                    break;
                case 3:
                    Result = Number1 * Number2;
                    Console.WriteLine("Your result: " + Result);
                    break;
                case 4:
                    Result = Number1 / Number2;
                    Console.WriteLine("Your result: " + Result);
                    break;

            }
        }
    }
}
