using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nav_App
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void gotop1_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(en1.Text))
                Application.Current.Properties["myName1"] = en1.Text;
           Navigation.PushAsync(new Page1());
           // Navigation.PushModalAsync(new Page1());
        }

        private void ti1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello","ITrer","OK");
        }
    }
}
