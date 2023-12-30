using System;

namespace NumberGuesser // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get function
            GetAppInfo();

            GreetUser();

            //let's play again
            while (true)
            {

                //Init correct number
                //int correctNumber = 7;

                //random number
                Random random = new Random();
                int correctNumber = random.Next(1, 11);

                //Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //guess not correct
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //make it a number
                    if (!int.TryParse(input, out guess))
                    {
                        //printcolormessage
                        PrintColorMessage(ConsoleColor.Red, "Plese use an actual numbet");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        /*Console.ForegroundColor = ConsoleColor.Red;

                        //Write out app info
                        Console.WriteLine("Wrong number, please try again");

                        //Reset text color
                        Console.ResetColor(); */
                        PrintColorMessage(ConsoleColor.Red, "Wrong number");

                    }

                    /* else
                     {
                         Console.WriteLine("Congrats !");
                     } */
                }

                PrintColorMessage(ConsoleColor.Yellow, "You areq Correct");


                /*Console.ForegroundColor = ConsoleColor.Yellow;

                //Write out app info
                Console.WriteLine("You are CORRECT");

                //Reset text color
                Console.ResetColor();*/

                Console.WriteLine("Play again ? [y/n]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }

                else if (answer == "N")
                {
                    return;
                }

                else 
                { 
                    return; 
                }

                
            }
            //Console.WriteLine("Thank you");
    
        }

        static void GetAppInfo()
        {
            //Set variable
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Acui";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Write out app info
            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask username
            Console.WriteLine("\nWhat is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("\nHello {0} , let's play a game ...", inputName);

        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            //Write out app info
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();

        }

    }
}