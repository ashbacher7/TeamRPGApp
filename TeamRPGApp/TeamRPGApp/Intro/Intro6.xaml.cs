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
	public partial class Intro6 : ContentPage
	{
		public Intro6 ()
		{
			InitializeComponent ();
		}
        private void Intro6TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IntroChoice());
        }
    }
}