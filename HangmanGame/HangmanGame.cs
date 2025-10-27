using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class HangmanGame
    {
        private List<string> words;
        private string wordToGuess;
        private char[] guessedLetters;
        private HashSet<char> triedLetters;
        private int maxWrongGuesses;
        private int wrongGuesses;

        public HangmanGame(List<string> words, int maxWrongGuesses = 6)
        {
            this.words = words;
            this.maxWrongGuesses = maxWrongGuesses;
            this.triedLetters = new HashSet<char>();
        }

        public void StartNewGame()
        {
            Random rand = new Random();
            wordToGuess = words[rand.Next(words.Count)].ToUpper();
            guessedLetters = new string('_', wordToGuess.Length).ToCharArray();
            wrongGuesses = 0;
            triedLetters.Clear();
        }

        // testing purpuse
        public int GetWordLength() => wordToGuess.Length;
    }
}
