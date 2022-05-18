using System;

namespace WordToGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeussingGame game = new GeussingGame("Harry Potter");
            Console.WriteLine(game.GetGeussProgress());
            while (true)
            {
                string guess = Console.ReadLine();
                game.AddGuess(guess[0]);

                Console.WriteLine("Enter your next guess: ");
                Console.WriteLine(game.GetGeussProgress());
            }
        }
    }
}
