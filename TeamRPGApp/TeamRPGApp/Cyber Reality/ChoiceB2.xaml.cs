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
	public partial class Choice2B : ContentPage
	{
		public Choice2B ()
		{
			InitializeComponent ();
		}

        private void ChoiceB1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Choice3B());
            Globals.Score = Globals.Score + 1;
        }

        private void PathB2B_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Choice3B());
            Globals.Score = Globals.Score + 2;
        }

        private void PathB2C_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Choice3B());
        }
    }
}