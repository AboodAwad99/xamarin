using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Vp3Stepper
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            msg.Rotation = sld.Value;
        }

        private void sld_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            msg.Rotation = sld.Value;
        }

        private void stp_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if(stp2.Value>20)
            msg.FontSize = stp2.Value;
        }

        private void pick_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pick.SelectedItem as string
            if (pick.SelectedItem.ToString().Equals("Red")) {
                this.BackgroundColor = Color.Red;
            }
            else if (pick.SelectedItem.ToString().Equals("Blue")) {
                this.BackgroundColor = Color.Blue;
            }
            else if (pick.SelectedItem.ToString().Equals("Yellow"))
            {
                this.BackgroundColor = Color.Yellow;
            }
            else if (pick.SelectedItem.ToString().Equals("Orange"))
            {
                this.BackgroundColor = Color.Orange;
            }
        }
    }
}
