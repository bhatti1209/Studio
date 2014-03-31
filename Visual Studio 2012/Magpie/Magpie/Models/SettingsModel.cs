using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magpie.Models
{
    class SettingsModel
    {
        private int _maxGuessesAllowed;

        public int MaxGuessesAllowed
        {
            get { return _maxGuessesAllowed; }
            set { _maxGuessesAllowed = value; }
        }
    }
}
