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
	public partial class Android6 : ContentPage
	{
		public Android6 ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    private void Android6TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new _1Android.Android7());
    }
}
}