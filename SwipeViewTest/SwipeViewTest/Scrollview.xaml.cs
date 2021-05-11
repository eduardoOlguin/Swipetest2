using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SwipeViewTest;
using smaforetagarnaAPP.ViewModel;

namespace SwipeViewTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Scrollview : ContentPage
    {
        public Scrollview()
        {
            InitializeComponent();
            this.BindingContext = new NewsViewModel();

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            Action<double> callback = input => MyDraggableView.HeightRequest = input;
            double startHeight = mainDisplayInfo.Height / 4;
            double endiendHeight = 0;
            uint rate = 32;
            uint length = 500;
            Easing easing = Easing.SinOut;
            MyDraggableView.Animate("anim", callback, startHeight, endiendHeight, rate, length, easing);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;


            if (MyDraggableView.Height == 0)
            {
                Action<double> callback = input => MyDraggableView.HeightRequest = input;
                double startHeight = 0;
                double endHeight = mainDisplayInfo.Height / 4;
                uint rate = 32;
                uint length = 500;
                Easing easing = Easing.CubicOut;
                MyDraggableView.Animate("anim", callback, startHeight, endHeight, rate, length, easing);
            }
            else
            {
                Action<double> callback = input => MyDraggableView.HeightRequest = input;
                double startHeight = mainDisplayInfo.Height / 4;
                double endiendHeight = 0;
                uint rate = 32;
                uint length = 500;
                Easing easing = Easing.SinOut;
                MyDraggableView.Animate("anim", callback, startHeight, endiendHeight, rate, length, easing);

            }
        }

        private string apiUrl = "https://smaforetagarna.se/wp-json/wp/v2/posts";

       


        public void ExternalLinkTapped(object sender, EventArgs e)
        {

            // var uri = new Uri(LinkTappedCommand.Text);
            var uri = new Uri("http://xamarin.com");
            Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        private void GoToNewsFeed(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Scrollview();
            //Navigation.PopAsync();
        }

        private void GoToSignup(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Login();
        }
    }
}

//            benefits_Btn = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Button>(this, "benefits_Btn");
