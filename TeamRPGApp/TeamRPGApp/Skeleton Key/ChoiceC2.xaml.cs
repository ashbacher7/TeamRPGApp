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
	public partial class Choice2C : ContentPage
	{
		public Choice2C ()
		{
			InitializeComponent ();
		}
        private void ChoiceCS_Clicked(object sender, EventArgs e)
        {
            Globals.Score = Globals.Score + 2;
            Navigation.PushAsync(new Choice3C());
        }
  private void ChoiceCB_Clicked(object sender, EventArgs e)
        {
            Globals.Score = Globals.Score + 1;
            Navigation.PushAsync(new Choice3C());
        }
    }
}