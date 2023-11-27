using System;

namespace MyAwesomeProgram
{
    class Program
    {
        //Entry Method 
        static void Main(string[] args)
        {
            Console.Title= "Fatma";
            Console.ForegroundColor=ConsoleColor.Green;

            Console.WriteLine("What is your name?");
            String userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + ",nice to meet you");

            //Adding 2 numbers
           /* int num01;
            int num02;
            Console.Write("Enter the first number: ");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num02 = Convert.ToInt32(Console.ReadLine());
            int result = num01 * num02;
            Console.WriteLine("The result: "+ result);
            //Find the avrage of 3 numbers
            int number;
            int number2;
            int number3;
            Console.Write("Enter the first number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());
            int avrage =(number +number2 + number3)/3;
            Console.WriteLine("The avrage: "+ avrage);
            */

            Console.WriteLine("welcome ! Tickets are 5$. Please insert cash.");
            int cash = Convert.ToInt32(Console.ReadLine());
            if (cash < 5 )
            {
                Console.WriteLine("That is not enough money.");
            }
            else if (cash == 5)
            {
                Console.WriteLine("This is your ticket.");
            }
            else 
            {
                int change = cash - 5;
                Console.WriteLine("This is your ticket and " + change +" dollers in change." );
            }

            Console.ReadKey();// "Wait before close" This line waits for the user to press button, so that the window will not ending or closing 
        }
    }
}
