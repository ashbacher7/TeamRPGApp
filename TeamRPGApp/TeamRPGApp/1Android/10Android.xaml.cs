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
	public partial class Android10 : ContentPage
	{
		public Android10 ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    private void Android10TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new _1Android.Android11());
    }
}
}