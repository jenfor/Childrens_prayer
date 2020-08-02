using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;

namespace App1
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);

            base.Dispatcher.BeginInvokeOnMainThread(() =>
            {
                App.Current.MainPage = new NavigationPage(new MainPage());
            });
        } 
    }
}
