﻿using EmailMobApp.Models;
using EmailMobApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmailMobApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmailPage : ContentPage
    {
        public AddEmailPage(ObservableCollection<Mail> mails)
        {
            InitializeComponent();
            BindingContext = new AddMailViewModel(mails);
        }
    }
}