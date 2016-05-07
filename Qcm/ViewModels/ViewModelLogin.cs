using MVVM;
using MVVM.Data;
using MVVM.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qcm.ViewModels
{
    public class ViewModelLogin : ObservableObject
    {

        #region Fields

        private DelegateCommand _ConnectCommand;

        #endregion

        #region Properties

        public DelegateCommand ConnectCommand => _ConnectCommand;

        #endregion

        public ViewModelLogin()
        {
            LoadData();
            _ConnectCommand = new DelegateCommand(ExecuteConnectCommand, CanExecuteConnectCommand);
        }

        private void LoadData()
        {
           // throw new NotImplementedException();
        }

        #region CategoyCommand

        private bool CanExecuteConnectCommand(object parameter)
        {
            return true;
        }

        private void ExecuteConnectCommand(object parameter)
        {
            ServiceResolver.GetService<INavigationService>().Navigate(new Uri("/Views/Categories.xaml", UriKind.Relative));
        }

        #endregion




    }
}
