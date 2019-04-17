using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShadowBug
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var childPage = new ChildPage();

            await Navigation.PushAsync(childPage);
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
