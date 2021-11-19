using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ICE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void btnpag1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
            
        }
    }
}
