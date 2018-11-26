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
            
		}

        private void ABtoTitle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}