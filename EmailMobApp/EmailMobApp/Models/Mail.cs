using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EmailMobApp.Models
{
    public class Mail : INotifyPropertyChanged
    {
        public Mail(string from, string to, string subject, string content)
        {
            From = from;
            To = to;
            Subject = subject;
            Content = content;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }


    }
}
