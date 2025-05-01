using System;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "applejuice";
            string guess = "";
            int attempt = 0;
            bool limitreached = false;
            
            while (guess != secretWord && !limitreached)
            {
                if (attempt < 3 ){
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    attempt++;
                }
                else
                {
                    limitreached = true;
                }
            }
            if (limitreached)
            {
                Console.Write("You lost!");
            }
            else
            {
                Console.Write("Congrats! You guessed the right word!");
            }
        }
    }
}