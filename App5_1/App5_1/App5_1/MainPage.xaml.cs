using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5_1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<String> items = new List<String>();
        public MainPage()
        {
            InitializeComponent();
            items.Add("Red");
            items.Add("Yellow");
            items.Add("Green");
            items.Add("Blue");
            items.Add("Pink");

            lst.ItemsSource = items;
        }

        private void lst_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            pg.ProgressTo(.95,10000,Easing.Linear);
            string ch = lst.SelectedItem as string;
            if (ch.Equals("Red")) {
                this.BackgroundColor = Color.Red;
            }
            else if (ch.Equals("Yellow")) {
                this.BackgroundColor = Color.Yellow;
            }
            else if (ch.Equals("Green"))
            {
                this.BackgroundColor = Color.Green;
            }
            else if (ch.Equals("Blue"))
            {
                this.BackgroundColor = Color.Blue;
            }
            else if (ch.Equals("Yellow"))
            {
                this.BackgroundColor = Color.Yellow;
            }
            else if (ch.Equals("Pink"))
            {
                this.BackgroundColor = Color.Pink;
            }
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var newData = items.Where<string>(
                x=>x.StartsWith(search.Text)
                );
            lst.ItemsSource = newData;
        }
    }
    }

