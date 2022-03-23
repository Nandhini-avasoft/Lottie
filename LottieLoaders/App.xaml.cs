using LottieLoaders.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LottieLoaders
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Application.Current.MainPage = new CreateLottieScreen();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
