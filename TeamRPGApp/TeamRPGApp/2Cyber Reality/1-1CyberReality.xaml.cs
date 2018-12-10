using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamRPGApp._2Cyber_Reality
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CyberReality1 : ContentPage
    {
        public CyberReality1()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void CR1TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChoiceB());
        }
    }
}