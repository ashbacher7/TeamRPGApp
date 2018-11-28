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
	public partial class Choice2A : ContentPage
	{
		public Choice2A ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void ChoiceAB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Choice3A());
            Globals.Score = Globals.Score + 1;
        }
        private void ChoiceAS_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Choice3A());
            Globals.Score = Globals.Score + 2;
        }
    }
}