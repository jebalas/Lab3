using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            Console.Write("Please tell me your name: ");
            string userName = Console.ReadLine();
            while (keepGoing)
            {
                bool getInput = true;
                var userNum = 0;
                do
                {
                    Console.WriteLine();
                    Console.Write($"Hi {userName} ! Please enter an integer between 1 and 100: ");
                    var numInput = Console.ReadLine();
                    var isNumInt = int.TryParse(numInput, out int finalNum);
                    userNum = finalNum;
                    
                    if (!isNumInt || userNum < 1 || userNum > 100)
                    {
                        getInput = true;
                        Console.WriteLine($"Hey {userName} you must enter an integer between 1 and 100! ");
                        Console.WriteLine("Please try again\r");
                    }
                    else
                    {
                        getInput = false;
                    }

                } while (getInput);

                bool isOdd = true;

                if(userNum % 2 == 0)
                {
                    isOdd = false;
                }

                if(isOdd)
                {
                    Console.WriteLine($"Output: {userNum} and Odd");
                }
                else
                {
                    if (userNum >= 2 && userNum <=24)
                    {
                        Console.WriteLine("Output: Even and less than 25");
                    }
                    else
                    {
                        if (userNum >= 26 && userNum <= 60)
                        {
                            Console.WriteLine("Output: Even");
                        }
                        else
                        {
                            Console.WriteLine($"Output: {userNum} and Even");
                        }
                    }
                }

                bool proceed = true;
                while (proceed)
                {
                Console.WriteLine();
                Console.Write($"Do you want to continue {userName} (y/n)? ");
                string continueGame = Console.ReadLine();
                    if (continueGame.ToLower() == "y")
                    {
                        keepGoing = true;
                        getInput = true;
                        proceed = false;
                    }
                    else
                    {
                        if (continueGame.ToLower() == "n")
                        {
                            keepGoing = false;
                            proceed = false;
                            Console.WriteLine($"Goodbye {userName}!");
                        }
                        else
                        {
                            Console.WriteLine($"Hey {userName}, you must enter 'y' or 'n'!");
                            Console.WriteLine("Please try again\r");
                            proceed = true;
                        }
                    }
                }
            }

        }
    }
}
