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
	public partial class ViewEnd : ContentPage
	{
		public ViewEnd ()
		{
			InitializeComponent ();
            EndingAGButton.IsVisible = Globals.AndroidGoodEndShow;
            EndingABButton.IsVisible = Globals.AndroidBadEndShow;
            EndingASButton.IsVisible = Globals.AndroidSelfishEndShow;
            EndingBGButton.IsVisible = Globals.CRGoodEndShow;
            EndingBBButton.IsVisible = Globals.CRBadEndShow;
            EndingBSButton.IsVisible = Globals.CRSelfishEndShow;
            EndingCGButton.IsVisible = Globals.SKGoodEndShow;
            EndingCBButton.IsVisible = Globals.SKBadEndShow;
            EndingCSButton.IsVisible = Globals.SKSelfishEndShow;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void EndingAGButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndAG());
        }

        private void EndingABButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndA());
        }

        private void EndingASButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndAS());
        }

        private void EndingBGButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndB());
        }

        private void EndingBBButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndBB());
        }

        private void EndingBSButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndBS());
        }

        private void EndingCGButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndCG());
        }

        private void EndingCBButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndCB());
        }

        private void EndingCSButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndCS());
        }
    }
}