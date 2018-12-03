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
	public partial class Choice3C : ContentPage
	{
		public Choice3C ()
		{
			InitializeComponent ();
		}

        private void ChoiceCG_Clicked(object sender, EventArgs e)
        {
            Globals.Score = Globals.Score + 3;
            if (Globals.Score <= 4)
            {
                Navigation.PushAsync(new EndCB());
            }
            if (Globals.Score >= 8)
            {
                Navigation.PushAsync(new EndCG());
            }
            if (Globals.Score >= 5 && Globals.Score <= 7)
            {
                Navigation.PushAsync(new EndCS());
            }
        }

        private void ChoiceCS_Clicked(object sender, EventArgs e)
        {
            Globals.Score = Globals.Score + 2;
            if (Globals.Score <= 4)
            {
                Navigation.PushAsync(new EndCB());
            }
            if (Globals.Score >= 8)
            {
                Navigation.PushAsync(new EndCG());
            }
            if (Globals.Score >= 5 && Globals.Score <= 7)
            {
                Navigation.PushAsync(new EndCS());
            }
        }
    }
}