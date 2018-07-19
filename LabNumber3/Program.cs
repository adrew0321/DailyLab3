using System;

namespace LabNumber3
{
    class Program
    {
        static void Main(string[] args)
        {

            string userName;
            int userNumber = 0;

            bool repeat1 = true;
            while (repeat1)
            {

                //***INPUT***

                Console.Write("Hello! Before we begin may I have your name? ");
                userName = Console.ReadLine();
                Console.ReadLine();

                Console.WriteLine($"It is a pleasure to meet you, {userName}! My name is Pavilion, let us begin.");
                Console.ReadLine();

                bool repeat2 = true;
                while (repeat2)
                {
                    Console.Write("Enter a number between 1 and 100: ");
                    try
                    {
                        userNumber = int.Parse(Console.ReadLine());
                        repeat2 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(
                            $"My apologises {userName}, but I need a numerical value in order to continue.");
                        Console.ReadLine();
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine($"My apologises {userName}, but I your number is too large or too small. Please try again.");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Critical Error: {e.Message}");
                    }


                }


                //***PROCESSING***

                //Checks if userNumber functionality
                if (userNumber > 100 || userNumber < 1)
                {
                    Console.WriteLine("I'm sorry, please insert a value between 1 and 100.");
                }
                else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
                {
                    Console.WriteLine($"{userName}, you entered the number {userNumber}. This is an Even number.");
                }
                else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber < 25)
                {
                    Console.WriteLine($"{userName}, you entered the number {userNumber}. This is an Even number and less than 25.");
                }
                else if (userNumber % 2 == 0 && userNumber > 60)
                {
                    Console.WriteLine($"{userName}, you entered the number {userNumber}. This is an Even number.");
                }
                else if (userNumber % 2 != 0)
                {
                    Console.WriteLine($"{userName}, you entered the number {userNumber}. This is an Odd number");
                }
                else if (userNumber % 2 != 0 && userNumber > 60)
                {
                    Console.WriteLine($"{userName}, you entered the number {userNumber}. This number is an Odd number");
                }

                //***OUTPUT***

                bool continueResponse = true;
                while (continueResponse)
                {
                    Console.WriteLine($"Continue? (y/n)");
                    string UserResponse = Console.ReadLine();

                    if (UserResponse.ToLower() == "y" || UserResponse.ToLower() == "yes")
                    {
                        repeat1 = true;
                        continueResponse = false;
                    }
                    else if (UserResponse.ToLower() == "n" || UserResponse.ToLower() == "no")
                    {
                        Console.WriteLine($"It's been a pleasure working with you, {userName}! Until next time...Goodbye!");
                        repeat1 = false;
                        continueResponse = false;
                    }
                }

            }


        }





    }
}

