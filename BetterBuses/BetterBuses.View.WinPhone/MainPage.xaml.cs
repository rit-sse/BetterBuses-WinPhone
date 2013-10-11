using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using BetterBuses.ViewModel.WinPhone;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace BetterBuses.View.WinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            DataContext = new MainPageViewModel();
            InitializeComponent();
        }
    }
}