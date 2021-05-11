using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwipeViewTest;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwipeViewTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : FlexLayout
    {
      //  private Button benefitsBtn;
//        private FlexLayout menuContainer;
        public Menu()
        {
            InitializeComponent();
            
        //    benefitsBtn = this.FindByName<Button>("benefits_Btn");
         //   menuContainer = this.FindByName<FlexLayout>("menu_Container");
        }

        private void benefits_Btn_Clicked(object sender, EventArgs e)
        {
           
            BenefitsView.IsVisible = true;
            menuContainer.IsVisible = false;
            BackBtn.IsVisible = true;
            
        }

        private void Back_Btn_Clicked(object sender, EventArgs e)
        {
            BenefitsView.IsVisible = false;
            menuContainer.IsVisible = true;
            BackBtn.IsVisible = false;
        }

        private void GoToBenefitsBig(object sender, EventArgs e)
        {
            Application.Current.MainPage = (new BenefitsBig());
            //Navigation.PushAsync(new BenefitsBig());
        }
    }
}