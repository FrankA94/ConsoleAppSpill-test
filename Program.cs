
using System;

namespace ConsoleAppGuess_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                string secretWord = "covid";
                string guess = "";
                int guessCount = 0;
                int guessLimit = 3;
                bool outOfGuesses = false;


                while (guess != secretWord && !outOfGuesses)
                {
                    if (guessCount < guessLimit)
                    {
                        Console.Write("Gjett her!: ");
                        guess = Console.ReadLine();
                        guessCount++;
                    }
                    else
                    {
                        outOfGuesses = true;
                    }

             
                if (outOfGuesses)
                {
                    Console.Write("Du tapte!");
                }
                else
                {
                    Console.Write("Du gjettet riktig!");
                }


            }
           
            Console.ReadLine();
        }
    }
}