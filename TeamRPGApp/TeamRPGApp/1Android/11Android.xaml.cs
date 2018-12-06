using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamRPGApp._1Android
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Android11 : ContentPage
	{
		public Android11 ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    private void Android11TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Choice3A());
    }
}
}