using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamRPGApp.Intro
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IntroChoice : ContentPage
	{
		public IntroChoice ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void ChoiceA_Clicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Confirmation", "In this path, you will help the company create an Android for daily use", "Yes", "No");
            if (answer)
            {
                await Navigation.PushAsync(new ChoiceA());
            }
        }
        private async void ChoiceB_Clicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Confirmation", "In this path, you will help to create a virtual space that peple can use for numerous reasons", "Yes", "No");
            if (answer)
            {
                await Navigation.PushAsync(new ChoiceB());
            }
        }
        private async void ChoiceC_Clicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Confirmation", "In this path, you will create a digital key that will allow access to any system", "Yes", "No");
            if (answer)
            {
                await Navigation.PushAsync(new ChoiceC());
            }
        }
    }
}