using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Newtonsoft.Json;
using smaforetagarnaAPP.Model;
using smaforetagarnaAPP.ViewModel;
using smaforetagarnaAPP.View;
using Xamarin.Essentials;
using System.Windows.Input;

namespace smaforetagarnaAPP.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsView : ContentPage
    {
        private string apiUrl = "https://smaforetagarna.se/wp-json/wp/v2/posts";
        
        public NewsView()
        {
            InitializeComponent();
            this.BindingContext = new NewsViewModel();
            
        }

        
        public void ExternalLinkTapped(object sender, EventArgs e)
        {

            // var uri = new Uri(LinkTappedCommand.Text);
            var uri = new Uri("http://xamarin.com");
            Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}