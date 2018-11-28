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
	public partial class Choice3A : ContentPage
	{
		public Choice3A ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void ChoiceAG_Clicked(object sender, EventArgs e)
        {
            Globals.Score = Globals.Score + 3;
            if (Globals.Score <= 4)
            {
                Navigation.PushAsync(new EndA());
            }
            if (Globals.Score >= 8)
            {
                Navigation.PushAsync(new EndAG());
            }
            if (Globals.Score >= 5 && Globals.Score <= 7)
            {
                Navigation.PushAsync(new EndAS());
            }
        }
        private void ChoiceAS_Clicked(object sender, EventArgs e)
        {
            Globals.Score = Globals.Score + 2;
            if (Globals.Score <= 4)
            {
                Navigation.PushAsync(new EndA());
            }
            if (Globals.Score >= 8)
            {
                Navigation.PushAsync(new EndAG());
            }
            if (Globals.Score >= 5 && Globals.Score <= 7)
            {
                Navigation.PushAsync(new EndAS());
            }
        }
    }
}