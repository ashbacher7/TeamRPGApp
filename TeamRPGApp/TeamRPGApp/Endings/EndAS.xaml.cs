﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamRPGApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EndAS : ContentPage
	{
		public EndAS ()
		{
			InitializeComponent ();
		}

        private void AStoTitle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}