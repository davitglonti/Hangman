namespace HangGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "APPLE", "BANANA", "ORANGE", "MANGO" };
            HangmanGame game = new HangmanGame(words, 6);

            game.StartNewGame();

            Console.WriteLine("Game started");
            Console.WriteLine("New game word length: " + game.GetWordLength());

            Console.WriteLine("\nGuessing A:");
            game.GuessLetter('A');
            Console.WriteLine("Current word: " + game.GetCurrentWordState());

            Console.WriteLine("\nGuessing Z:");
            game.GuessLetter('Z');
            Console.WriteLine("Current word: " + game.GetCurrentWordState());

        }
    }
}
