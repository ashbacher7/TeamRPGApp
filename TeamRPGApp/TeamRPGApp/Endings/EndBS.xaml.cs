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
	public partial class EndBS : ContentPage
	{
		public EndBS ()
		{
			InitializeComponent ();
            Globals.CRSelfishEndShow = true;
            Globals.ViewEndButtonShow = true;
        }

        private void BStoTitle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}