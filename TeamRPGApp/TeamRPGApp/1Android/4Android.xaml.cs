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
	public partial class Android4 : ContentPage
	{
		public Android4()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    private void Android4TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new _1Android.Android5());
    }
}
}