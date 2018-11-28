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
	public partial class EndCS : ContentPage
	{
		public EndCS ()
		{
			InitializeComponent ();
            Globals.SKSelfishEndShow = true;
            Globals.ViewEndButtonShow = true;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void CStoTitle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}