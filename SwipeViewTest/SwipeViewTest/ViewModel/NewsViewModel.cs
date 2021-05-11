using smaforetagarnaAPP.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using smaforetagarnaAPP.View;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Windows.Input;

namespace smaforetagarnaAPP.ViewModel
{
    public class NewsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string apiUrl = "https://smaforetagarna.se/wp-json/wp/v2/posts?_embed";

        private ObservableCollection<News> _newsPostsOC;
        
        public ObservableCollection<News> NewsPostsOC
        {
            get { return _newsPostsOC; }
            set { _newsPostsOC = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NewsPostsOC"));
                }
        }

        public NewsViewModel()
        {
            GetNewsPosts();
        }

      
        private async void GetNewsPosts()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(apiUrl);

            var content = await response.Content.ReadAsStringAsync();

            var deserializeContent = JsonConvert.DeserializeObject<ObservableCollection<News>>(content);

            // Console.WriteLine(deserializeContent[0].Embedded.WpFeaturedmedia[0].MediaDetails.Sizes.Medium.SourceUrl);

            NewsPostsOC = deserializeContent;
            
        }




    }
}

