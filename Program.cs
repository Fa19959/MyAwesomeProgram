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
            Console.ReadKey();// "Wait before close" This line waits for the user to press button, so that the window will not ending or closing 
        }
    }
}
