using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Signup : ContentPage
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void signup_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(SName.Text)&& !string.IsNullOrEmpty(SPass.Text)) { 
            Application.Current.Properties["UserName"] = SName.Text;
            Application.Current.Properties["PassWord"] = SPass.Text;
                Navigation.PopModalAsync();
            }
        }
    }
}