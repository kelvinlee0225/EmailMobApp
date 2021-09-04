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
    public class MailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public MailViewModel(Mail mail)
        {
            From = mail.From;
            To = $"to {mail.To}";
            Subject = mail.Subject;
            Content = mail.Content;
        }
    }
}
