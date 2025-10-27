namespace HangmanGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "APPLE", "BANANA", "ORANGE", "MANGO" };
            HangmanGame game = new HangmanGame(words);

            game.StartNewGame();

            Console.WriteLine("Game started");
            Console.WriteLine("New game word length: " + game.GetWordLength());
        }
    }
}
