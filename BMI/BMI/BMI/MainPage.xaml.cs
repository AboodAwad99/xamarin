using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dt.Date = DateTime.Now;
            ti.Time = DateTime.Now.TimeOfDay;
            dt.MaximumDate = DateTime.Now;
           
        }

        private void pick_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_Clicked(object sender, EventArgs e)
        {
        
            if (ew.Text != null && eh.Text != null)
            {
                double bmiValue = double.Parse(ew.Text) / Math.Pow(double.Parse(eh.Text), 2);
                Lb.Text = "BMI: " + bmiValue+"\n"+ dt.Date.ToShortDateString()+"\n"+ ti.Time+"\n"+ pick.SelectedItem;
            }
            else {
                DisplayAlert("Erorr !","Pleas Enter weight and height","OK");
            }
          
        }
    }
}
