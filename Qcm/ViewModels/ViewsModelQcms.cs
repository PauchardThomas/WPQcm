using MVVM.ViewModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Qcm.Models;
using MVVM.Service;
using MVVM.Interfaces;
using Qcm.Interfaces;

namespace Qcm.ViewModels
{
   public class ViewsModelQcms : ViewModelList<Qcm.Models.Qcm>
    {

        private string URI = "http://192.168.100.152/app_dev.php/api/list/qcm";

        public ViewsModelQcms()
        {
            LoadData();
        }

        public override void LoadData()
        {
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
                    ServiceResolver.GetService<INavigationService>().Navigate(new Uri("/Views/Previsu_Qcm.xaml", UriKind.Relative));
                }
            });
        }

        public override void OnNavigatedFrom(IViewModel viewModel)
        {
            if (viewModel is IViewModelQcm)
            {
                ((IViewModelQcm)viewModel).Item = this.SelectedItem;
                ((IViewModelQcm)viewModel).LoadData();
                SelectedItem = null;
            }
        }
        private void WebClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string json = e.Result;

            JArray jarr = JArray.Parse(json);
            foreach (var item in jarr)
            {
                Qcm.Models.Qcm qcm = new Qcm.Models.Qcm();

                System.Diagnostics.Debug.WriteLine(item["id"]);
                qcm.id = int.Parse(item["id"].ToString());                
                qcm.libelle = item["libelle"].ToString();
                qcm.duree = (DateTime) item["duration"];

                this.ItemsSource.Add(new Models.Qcm(qcm.id, qcm.libelle,qcm.duree));
            }


        }

    }
}
