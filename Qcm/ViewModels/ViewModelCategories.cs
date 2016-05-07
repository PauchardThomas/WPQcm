using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Qcm.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MVVM.ViewModels;
using MVVM.Service;
using MVVM.Views;
using System.Windows.Navigation;
using MVVM.Interfaces;
using Qcm.Interfaces;
using Qcm.ViewModels.Interfaces;

namespace Qcm.ViewModels
{
   public class ViewModelCategories : ViewModelList<Category> , IViewModelCategories
    {

        private string URI = "http://192.168.100.152/app_dev.php/api/categories";

        public ViewModelCategories()
        {
            LoadData();  
        }

         public override void  LoadData()
        {
            IsBusy = true;
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += WebClient_DownloadStringCompleted;
            webClient.DownloadStringAsync(new Uri(URI));
        }

        protected override void InitializePropertyTrackers()
        {
            base.InitializePropertyTrackers();

            this.AddPropertyTrackerAction(nameof(SelectedItem), (sender, args) =>
            {
                if (SelectedItem != null)
                {
                    ServiceResolver.GetService<INavigationService>().Navigate(new Uri("/Views/Qcms.xaml", UriKind.Relative));
                }
            });
        }

        public override void OnNavigatedFrom(IViewModel viewModel)
        {
            if (viewModel is IViewModelCategory)
            {
                    ((IViewModelCategory)viewModel).Item = this.SelectedItem;
                    ((IViewModelCategory)viewModel).LoadData();
                    SelectedItem = null;           
            }
        }

        private void WebClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string json = e.Result;
            List<Category> categories = new List<Category>();

            JArray jarr = JArray.Parse(json);
            foreach (var item in jarr)
            {
                Category cat = new Category();

                cat.id = int.Parse(item["id"].ToString());
                cat.libelle = item["libelle"].ToString();

               // System.Diagnostics.Debug.WriteLine(cat.id + "|" + cat.libelle);
                categories.Add(cat);

                this.ItemsSource.Add(new Category(cat.id,cat.libelle));          
            }
            IsBusy = false;

        }
    }
}
