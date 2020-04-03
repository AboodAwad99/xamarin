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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            if(Application.Current.Properties.ContainsKey("myName1"))
            lblp1.Text = Application.Current.Properties["myName1"] as string;
        }

        private void gotop1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void b1_Clicked(object sender, EventArgs e)
        {
            lblp1.Text = "afdssdf";
        }
    }
}