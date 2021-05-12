using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwipeViewTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Scrollview();


        }

        private void GoToNewsFeed(object sender, EventArgs e)
        {
            return;
            //Navigation.PopAsync();
        }

        private void GoToSignup(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Login();
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
