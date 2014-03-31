using HelloWorld_CS.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelloWorld_CS.Model
{
    class HelloWorldViewModel : INotifyPropertyChanged
    {
        private string _userName = "Enter your name here";
        private string _message = "temp";
        private DelegateCommand sayHello;

        public string WelcomeMessage
        {
            get { return "Welcome To Hello World !!!"; }
        }
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
                if(sayHello == null)
                    sayHello = new DelegateCommand(DisplayMessage);

                return sayHello; 
            }
        }

        private void DisplayMessage()
        {
            Message = "Welcome to Game - " + UserName + " !!!";
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
