using System;

namespace Comp5202_Problem1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
         //Start the program with Clear();
         Console.Clear();
         //Program function
         Console.WriteLine("------------------------------------------------------------------");
         Console.WriteLine("This program takes two numbers & finds the difference between them");
         Console.WriteLine("------------------------------------------------------------------");
         //create var
         Console.WriteLine("Please enter your first number");
         var input1 = Console.ReadLine();
         Console.WriteLine($"The number you chose was {input1}");
         Console.WriteLine(Environment.NewLine);
         Console.WriteLine("Please enter your second number");
         var input2 = Console.ReadLine();
         Console.WriteLine($"The number you chose was {input2}");
         var num1 = 0;
         var num2 = 0;
         var isNumber1 = int.TryParse(input1, out num1);
         var isNumber2 = int.TryParse(input2, out num2);
         Console.WriteLine(Environment.NewLine);
         if (num1 < num2)
        {
            Console.WriteLine($"{num2} is greater then {num1}");
        } else 
        {
            Console.WriteLine($"{num1} is greater then {num2}");
        }
         //End the program with blank line and instructions
         Console.ResetColor();
         Console.WriteLine();
         Console.WriteLine("Please Press <Enter> to quit the program");
         Console.ReadKey();
        }
    }
}
