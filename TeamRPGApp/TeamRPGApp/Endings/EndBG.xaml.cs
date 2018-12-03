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
	public partial class EndB : ContentPage
	{
		public EndB ()
		{
			InitializeComponent ();
            Globals.CRGoodEndShow = true;
            Globals.ViewEndButtonShow = true;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BGtoTitle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}