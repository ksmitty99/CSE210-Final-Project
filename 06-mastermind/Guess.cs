using System;

namespace _06_mastermind
{
    /// <summary>
    /// Contains the pile and the number of stones for a given move.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    class Guess
    {
        private string _guessString;
        /// <summary>
        /// Initializes the move with the provided guess.
        /// </summary>
        public void SetGuess(string guess)
        {
            _guessString = guess;
        }

        /// <summary>
        /// Returns the provided guess.
        /// </summary>
        public string GetGuess()
        {
            return _guessString;   
        }

    }
}
