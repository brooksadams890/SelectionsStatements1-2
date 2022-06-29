using System;

namespace Selection_Statements_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var r = new Random();
            //var favNumber = r.Next(1, 1000);
            //int userInput;

            //do
            //{


            //    Console.WriteLine("Guess a number between 1 & 10");
            //    userInput = int.Parse(Console.ReadLine());

            //    if (userInput < favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too low");
            //    }
            //    else if (userInput > favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too high");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You guessed it!!!");
            //    }
            //} while (favNumber != userInput);

            //Exercise 2 

            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject)
            {
                case "math":
                    Console.WriteLine("I hate Math!");
                    break;
                case "science":
                    Console.WriteLine("I love science!");
                    break;
                case "pe":
                    Console.WriteLine("PE is the best!!!");
                    break;
                case "history":
                    Console.WriteLine("History is fun.");
                    break;
                case "english":
                    Console.WriteLine("English is boring.");
                    break;
                default:
                    Console.WriteLine("I don't know that subject");
                    break;
            }
    }
}
