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
	public partial class ChoiceA : ContentPage
	{
		public ChoiceA ()
		{
			InitializeComponent ();
		}
        private void ChoiceAB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Choice2A());
        }
        private void ChoiceAG_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Choice2A());
        }
    }
}