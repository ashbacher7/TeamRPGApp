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
		}
        private void ChoiceAG_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndAG());
        }
        private void ChoiceAS_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndAS());
        }
        private void ChoiceAB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndA());
        }
    }
}