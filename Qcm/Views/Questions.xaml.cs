using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MVVM.Views;

namespace Qcm.Views
{
    public partial class Questions : MVVMPhonePage
    {
        public Questions()
        {
            this.ViewModel = new ViewModels.ViewModelQuestion();
            InitializeComponent();
        }
    }
}