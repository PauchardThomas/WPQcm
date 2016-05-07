using MVVM.ViewModels;
using Qcm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MVVM.Service;

namespace Qcm.ViewModels
{
   public class ViewModelQuestion :  ViewModelList<Question>
    {
        private string URI = "http://192.168.100.152/app_dev.php/api/qcms/";
        private int id = 1;
        private string format = ".json";

        public ViewModelQuestion()
        {
            LoadData();
        }

        public override void LoadData()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += WebClient_DownloadStringCompleted;
            System.Diagnostics.Debug.WriteLine(URI + id + format);
            webClient.DownloadStringAsync(new Uri(URI + id + format));
 
                  


        }

        private void WebClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string json = e.Result;

        }

    }
}
