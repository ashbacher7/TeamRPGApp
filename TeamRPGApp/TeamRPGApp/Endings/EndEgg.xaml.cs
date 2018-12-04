using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamRPGApp.Endings
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EndEgg : ContentPage
	{
		public EndEgg ()
		{
			InitializeComponent ();
		}
        private void EndEggTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}