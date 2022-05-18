using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordToGuess
{
    public class GeussingGame
    {
        private string _guessWord;
        private string _guessProgress;



        public GeussingGame(string guessWord)
        {
            _guessWord = guessWord;
            for (int index = 0; index < _guessWord.Length; index++)
            {
                _guessProgress += "*";
            }
        }
        public string GetGeussProgress()
        {
            return _guessProgress;
        }


        public void AddGuess(char letter)
        {
            char[] guessProgressArray = _guessProgress.ToCharArray();

            for (int index = 0; index < _guessWord.Length; index++)
            {
                if (_guessWord[index] == letter)
                {
                    guessProgressArray[index] = letter;
                }
            }
            _guessProgress = new string( guessProgressArray);
        }
    }
}
