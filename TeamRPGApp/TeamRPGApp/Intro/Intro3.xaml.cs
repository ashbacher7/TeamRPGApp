using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamRPGApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Intro3 : ContentPage
	{
		public Intro3 ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Intro3Button_Clicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Confirmation", "Is this your ID card?", "Yes", "No");
                if (answer)
            {
                await Navigation.PushAsync(new Intro4());
            }
        }
    }
}