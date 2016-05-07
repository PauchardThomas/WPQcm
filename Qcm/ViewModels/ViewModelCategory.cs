using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.ViewModels;
using MVVM.Interfaces;
using Qcm.Models;
using Qcm.Interfaces;

namespace Qcm.ViewModels
{
    public class ViewModelCategory : ViewModelItem<Category> , IViewModelCategory
    {

        private ViewModels.ViewsModelQcms _ViewModelQcms;

        public ViewModels.ViewsModelQcms ViewModelQcms => _ViewModelQcms;

        public ViewModelCategory()
        {
            _ViewModelQcms = new ViewsModelQcms();
        }

        public override void LoadData()
        {
           // _ViewModelQcms.
        }

        public override void OnNavigatedFrom(IViewModel viewModel)
        {
            base.OnNavigatedFrom(viewModel);

            //Si le vue-modèle de la page suivante est celui de la fiche d'une catégorie.
            if (viewModel is IViewModelQcm)
            {
                //On donné l'élément sélectionné au vue-modèle.
                ((IViewModelQcm)viewModel).Item = this.ViewModelQcms.SelectedItem;
                //On charge les données
                ((IViewModelQcm)viewModel).LoadData();
                //On remet la sélection à null.
                this.ViewModelQcms.SelectedItem = null;
            }
        }

    }
}
