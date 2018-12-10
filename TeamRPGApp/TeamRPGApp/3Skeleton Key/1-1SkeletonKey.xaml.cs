using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamRPGApp._3Skeleton_Key
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkeletonKey1 : ContentPage
    {
        public SkeletonKey1()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void SK1TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChoiceC());
        }
    }
}