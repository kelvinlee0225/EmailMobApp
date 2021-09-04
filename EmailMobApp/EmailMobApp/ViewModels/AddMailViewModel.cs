using EmailMobApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EmailMobApp.ViewModels
{
    public class AddMailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public ICommand AddMailCommand { get;  }

        public AddMailViewModel(ObservableCollection<Mail> mails)
        {
           AddMailCommand = new Command(async() =>
           {
               mails.Add(new Mail(From, To, Subject, Content));
               await App.Current.MainPage.Navigation.PopAsync();
           });
        }
    }
}
