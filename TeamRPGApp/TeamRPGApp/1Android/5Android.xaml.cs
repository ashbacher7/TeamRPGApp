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
	public partial class Android5 : ContentPage
	{
		public Android5 ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    private void Android5TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new _1Android.Android6());
    }
}
}