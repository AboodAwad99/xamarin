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
    public partial class SimpleCal : ContentPage
    {
        public SimpleCal()
        {
            InitializeComponent();
        }

        private void signOut_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties.Remove("UserName");
            Application.Current.Properties.Remove("PassWord");
            Navigation.PopToRootAsync();
        }
    }
}