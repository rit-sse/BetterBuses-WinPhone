using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using BetterBuses.ViewModel.Common;
using BetterBuses.ViewModel.WinPhone;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace BetterBuses.View.WinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        /// <summary>
        /// The ViewModel associated with the Main Page.
        /// </summary>
        public IMainPageViewModel ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; }
        }

        /// <summary>
        /// Construrtor.
        /// </summary>
        /// <param name="viewModel"></param>
        public MainPage() // IMainPageViewModel viewModel )
        {
            _viewModel = new MainPageViewModel(); //viewModel;
            DataContext = ViewModel;

            InitializeComponent();
        }

        #region Internal State

        private IMainPageViewModel _viewModel;

        #endregion
    }
}