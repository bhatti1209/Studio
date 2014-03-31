using Magpie.Models;
using Magpie.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Magpie.ViewModels
{
    class PlayViewModel : INotifyPropertyChanged
    {
        private GameSessionModel _gameSession;
        private SettingsModel _sessionSettings;
        public ObservableCollection<string> tempList = new ObservableCollection<string>();

        public ObservableCollection<string> SampleData
        {
            get
            {
                if (tempList.Count <= 0)
                {
                    tempList.Add("1");
                    tempList.Add("2");
                    tempList.Add("3");
                    tempList.Add("4");
                }
                return tempList;
            }
        }

        public GameSessionModel GameSession
        {
            get { return _gameSession; }
            set { _gameSession = value; }
        }
        public SettingsModel SessionSettings
        {
            get { return _sessionSettings; }
            set { _sessionSettings = value; }
        }

        public PlayViewModel()
        {
            this.GameSession = new GameSessionModel{ WordToGuess = "saini" };
            this.SessionSettings = new SettingsModel{ MaxGuessesAllowed = 10 };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
