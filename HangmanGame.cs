using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangGame
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

        // test method to get the length of the word to guess
        public int GetWordLength() => wordToGuess.Length;


        public bool GuessLetter(char letter)
        {
            letter = char.ToUpper(letter);

            if (triedLetters.Contains(letter))
            {
                Console.WriteLine($"You already tried '{letter}'!");
                return false;
            }

            triedLetters.Add(letter);
            bool found = false;

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == letter)
                {
                    guessedLetters[i] = letter;
                    found = true;
                }
            }

            if (!found)
            {
                wrongGuesses++;
                Console.WriteLine($"Wrong guess! You have {maxWrongGuesses - wrongGuesses} tries left.");
            }

            return found;
        }
        public string GetCurrentWordState()
        {
            return string.Join(" ", guessedLetters);
        }
    }

}


     
    
