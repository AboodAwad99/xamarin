using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if(Application.Current.Properties.ContainsKey("UserName"))
                Navigation.PushAsync(new SimpleCal());

        }

        private void login_Clicked(object sender, EventArgs e)
        {
            String un = uName.Text;
            String ps = Pass.Text;
          
            if (  Application.Current.Properties.ContainsKey("UserName"))
            {
                if (ps.Equals(Application.Current.Properties["PassWord"])&& un.Equals(Application.Current.Properties["UserName"]))
                {

                    Navigation.PushAsync(new SimpleCal());
                }
                else
                    DisplayAlert("Erorr", "Re Enter PassWord", "Ok");
            }
            else 
            {
                Navigation.PushModalAsync(new Signup());
            }
        }

        private void tis_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Signup());
        }
    }
}
