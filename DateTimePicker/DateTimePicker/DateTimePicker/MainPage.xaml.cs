using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DateTimePicker
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            dt.Date = DateTime.Today;
          
        }

        private void dt_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime date = dt.Date;
            String msg = "Your scheduled is : " + date.Day + "/" + date.Month;
            //  DisplayAlert("New Date", msg, "OK");
            act.IsRunning = true;
        }

        private void tm_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            TimeSpan t = tm.Time;
            //   String msg = t;
            // DisplayAlert("New time",t.ToString(), "OK");
            act.IsRunning = false;
        }

        private void sw_Toggled(object sender, ToggledEventArgs e)
        {
            if(sw.IsToggled==true)
                act.IsRunning = true;
           else
                act.IsRunning = false;


        }
    }
}
