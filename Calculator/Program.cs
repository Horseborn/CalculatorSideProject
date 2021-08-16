using System;
using System.Runtime.InteropServices;

namespace Calculator
{
    class Program
    {
       static void Main(string[] args)
       {
           bool closeApp = false;
           Console.WriteLine("My personal calculator");
            // Declare variables
            while (!closeApp)
            {
                float num1;
                float num2;

                

                // Type first number
                num1Input:
                Console.WriteLine("Type a number and press enter please.");
                try
                {
                   
                    num1 = Convert.ToInt32(Console.ReadLine());
                    
                }
                catch
                {
                    Console.WriteLine("The input needs to be a number, please try again.");
                    goto num1Input;

                }



                // Type seccond number
                num2input:
                Console.WriteLine("Type a second number please!");
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("The input needs to be a number, please try again.");
                    goto num2input;
                }


                //Request user pick an option 
                Console.WriteLine("Choose an option from below");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                //Switch statement to do math 
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                        break;

                    case "s":
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        break;

                    case "m":
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;

                    case "d":
                        Console.WriteLine($"Your result: {num1} ÷ {num2} = " + (num1 / num2));
                        break;

                }

               /* Console.WriteLine("Press any key to exit the calculator application");
                Console.ReadKey();
               */
               Console.WriteLine("\n");
               Console.WriteLine("Type 'exit' to exit the application, or press any key to continue.");
               if (Console.ReadLine() == "exit") closeApp = true;
            }
       }
        
    }
}
