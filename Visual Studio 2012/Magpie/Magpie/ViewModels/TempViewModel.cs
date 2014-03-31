using Magpie.Models;
using Magpie.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Magpie.ViewModels
{
    class TempViewModel : INotifyPropertyChanged
    {
        private string _userName = "Enter your name here";
        private string _message = "temp";
        private DelegateCommand sayHello;
        private SettingsModel _sessionSettings;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                NotifyPropertyChanged("Message");
            }
        }

        public ICommand SayHello
        {
            get
            {
                if (sayHello == null)
                    sayHello = new DelegateCommand(DisplayMessage);

                return sayHello;
            }
        }

        private void DisplayMessage()
        {
            Message = "Welcome to Game - " + UserName + " !!!";
        }

        public SettingsModel SessionSettings
        {
            get { return _sessionSettings; }
            set { _sessionSettings = value; }
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
