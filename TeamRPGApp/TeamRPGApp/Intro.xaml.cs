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
	public partial class Intro : ContentPage
	{
		public Intro ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this , false);
		}
        private void ChoiceA_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChoiceA());
        }
        private void ChoiceB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChoiceB());
        }
    }
}