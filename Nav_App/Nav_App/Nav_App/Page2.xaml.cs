using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nav_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            if (Application.Current.Properties.ContainsKey("myName1"))
                lblp2.Text = Application.Current.Properties["myName1"] as string ;
        }

        private void gotop1_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}