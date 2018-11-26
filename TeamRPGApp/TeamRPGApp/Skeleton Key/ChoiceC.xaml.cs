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
	public partial class ChoiceC : ContentPage
	{
		public ChoiceC ()
		{
			InitializeComponent ();
		}

        private void ChoiceCG_Clicked(object sender, EventArgs e)
        {
            Globals.Score = Globals.Score + 3;
            Navigation.PushAsync(new Choice2C());
        }

        private void ChoiceCB_Clicked(object sender, EventArgs e)
        {
            Globals.Score = Globals.Score + 1;
            Navigation.PushAsync(new Choice2C());
        }
    }
}