namespace HangGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = LoadWordsFromFile("words.txt");
  
            HangmanGame game = new HangmanGame(words, 6);

            Console.WriteLine("Game started");
            game.StartNewGame();

            Console.WriteLine($"New game word length: {game.GetWordLength()}"); 
            

            while (!game.IsGameOver())
            {
                Console.Write("Enter a letter: ");
                char input = Console.ReadKey().KeyChar;
                
                game.GuessLetter(input);
                Console.WriteLine($"Current word: {game.GetCurrentWordState()}");
               
            }

            if (game.IsWordGuessed())
                Console.WriteLine($"\n You won! The word was: {game.GetWord()}");
            else
                Console.WriteLine($"\n You lost! The word was: {game.GetWord()}");

        }


    }
}
