using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMIApp_2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<string> items = new List<string>();
        public MainPage()
        {
            InitializeComponent();
           
        }

        private void save_Clicked(object sender, EventArgs e)
        {
            //read data
            double height =double.Parse(he.Text) ; 
            double weight = double.Parse(we.Text);
            String gen = gender.SelectedItem as string; //or ToString();
            DateTime dd = dp.Date;
            TimeSpan tt = tp.Time;
            //compute BMI
            double bmi = weight / Math.Pow(height, 2);
            //Status BMI
            String status = " ";
            if (bmi < 18) status = "Unhealthy";
            else if (bmi > 25) status = "Fat";
            else status = "Healthy";

            String msg = dd.ToShortDateString() + "," + tt.ToString() + "," + gen + "," + bmi + "," + status;

            items.Add(msg);
            ls.ItemsSource = null;
            ls.ItemsSource = items;





        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var newData = items.Where<string>(
              x => x.Contains(sb.Text)
              );
            ls.ItemsSource = newData;
        }
    }
}
