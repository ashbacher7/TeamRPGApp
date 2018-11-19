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
	public partial class ChoiceB : ContentPage
	{
		public ChoiceB ()
		{
			InitializeComponent ();
		}
        private void ChoiceAB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Choice2B());
        }
        private void ChoiceBB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Choice2B());
        }

        private void ChoiceB3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Choice2B());
        }
    }
}