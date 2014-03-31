using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magpie.Models
{
    class GameSessionModel
    {
        private string _wordToGuess = "stone";
        private bool isFinished;        

        public string WordToGuess
        {
            get { return _wordToGuess; }
            set { _wordToGuess = value; }
        }
        
    }
}
