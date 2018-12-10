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
	public partial class EndA : ContentPage
	{
		public EndA ()
		{
			InitializeComponent ();
            Globals.AndroidBadEndShow = true;
            Globals.ViewEndButtonShow = true;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void EndABTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Endings.EndAB1());
        }
    }
}