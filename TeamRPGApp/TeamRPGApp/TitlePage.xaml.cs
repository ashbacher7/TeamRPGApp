using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TeamRPGApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            ViewEndingsButton.IsVisible = Globals.ViewEndButtonShow;
            NavigationPage.SetHasNavigationBar(this, false);
            Globals.Score = 0;
        }

        private void NewGame_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Intro1());
        }

        private void Endings_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewEnd());
        }
    }
}
