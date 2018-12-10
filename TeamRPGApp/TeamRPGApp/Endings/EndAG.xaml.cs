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
	public partial class EndAG : ContentPage
	{
		public EndAG ()
		{
			InitializeComponent ();
            Globals.AndroidGoodEndShow = true;
            Globals.ViewEndButtonShow = true;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void EndAGTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Endings.EndAG1());
        }
    }
}