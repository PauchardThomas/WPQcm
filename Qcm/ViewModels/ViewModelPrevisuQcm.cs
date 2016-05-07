using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.ViewModels;
using Qcm.Models;
using Qcm.Interfaces;
using MVVM;
using MVVM.Service;

namespace Qcm.ViewModels
{
    public class ViewModelPrevisuQcm : ViewModelItem<Models.Qcm> , IViewModelQcm
    {
        #region Fields

        private DelegateCommand _StartQcmCommand;

        #endregion

        #region Properties

        public DelegateCommand StartQcmCommand => _StartQcmCommand;

        #endregion

        public ViewModelPrevisuQcm()
        {
            LoadData();
            _StartQcmCommand = new DelegateCommand(ExecuteStartQcmCommand, CanExecuteStartQcmCommand);
        }

        private void LoadData()
        {
            // throw new NotImplementedException();
        }

        #region CategoyCommand

        private bool CanExecuteStartQcmCommand(object parameter)
        {
            return true;
        }

        private void ExecuteStartQcmCommand(object parameter)
        {
            ServiceResolver.GetService<INavigationService>().Navigate(new Uri("/Views/Questions.xaml", UriKind.Relative));
        }

        #endregion


    }
}
