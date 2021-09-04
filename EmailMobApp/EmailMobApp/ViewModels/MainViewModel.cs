using EmailMobApp.Models;
using EmailMobApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EmailMobApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Mail _selectedMail;
        public Mail SelectMail
        {
            get
            {
                return _selectedMail;
            }
            set
            {
                _selectedMail = value;

                if (_selectedMail != null)
                {
                    SelectedMailCommand.Execute(_selectedMail);
                }
            }
        }
        public ICommand SelectedMailCommand { get; }
        public ICommand AddMailCommand { get; }
        public ICommand DeleteMailCommand { get; }
        public ICommand AttachPhoto { get; }

        public ObservableCollection<Mail> Mails { get; set; } = new ObservableCollection<Mail>();
        public MainViewModel()
        {
            SelectedMailCommand = new Command<Mail>(OnMailSelected);
            AddMailCommand = new Command<Mail>(AddMail);
            DeleteMailCommand = new Command<Mail>(DeleteMail);
            //AttachPhoto = new Command<Mail>(PhotoAttachment);
        }

        private void DeleteMail(Mail mail)
        {
            Mails.Remove(mail);
        }

        private async void AddMail(Mail mail)
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddEmailPage(Mails));
        }

        private async void OnMailSelected(Mail mail)
        {
            await App.Current.MainPage.Navigation.PushAsync(new MailPage(mail));
        }
    }
}
