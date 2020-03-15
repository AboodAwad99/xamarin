using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorN
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

        private void ButtonP_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num1.Text) && !String.IsNullOrEmpty(Num2.Text))
                Result.Text = (Int32.Parse(Num1.Text) + Int32.Parse(Num2.Text)).ToString();
            else
                DisplayAlert("Error", "Please Enter Numbers ", "Cancel");
        }

        private void ButtonMi_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num1.Text) && !String.IsNullOrEmpty(Num2.Text))
                Result.Text = (Int32.Parse(Num1.Text) - Int32.Parse(Num2.Text)).ToString();
            else
                DisplayAlert("Error", "Please Enter Numbers ", "Cancel");
        }

        private void ButtonMul_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num1.Text) && !String.IsNullOrEmpty(Num2.Text))
                Result.Text = (Int32.Parse(Num1.Text) * Int32.Parse(Num2.Text)).ToString();
            else
                DisplayAlert("Error", "Please Enter Numbers ", "Cancel");
        }
        private void ButtonDiv_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num1.Text) && !String.IsNullOrEmpty(Num2.Text))
                Result.Text = (Int32.Parse(Num1.Text) / Int32.Parse(Num2.Text)).ToString();
            else
                DisplayAlert("Error", "Please Enter Numbers ", "Cancel");
        }
    }
}
