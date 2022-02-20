using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public ICommand LocalCommand => new Command(Button_Clicked_1);
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double Total = Convert.ToDouble(PA.Text) + (Convert.ToDouble(PA.Text) * Convert.ToDouble(YR.Text) * Convert.ToDouble(I.Text)) / 100;
            SI.Text = Total.ToString();
        }

        private void Button_Clicked_1()
        {
            PA.Text ="";
            YR.Text = "";
            I.Text = "";
            SI.Text = "";

        }
        
    }
}
