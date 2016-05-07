using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Qcm.Resources;
using Qcm.Views;
using MVVM.Views;

namespace Qcm
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructeur
        public MainPage()
        {
            this.DataContext = new ViewModels.ViewModelLogin();
            InitializeComponent();

           
        }

    }
}