using System;
using Xamarin.Essentials;

namespace VirtualArt.prism.Views{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BtnMusica_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://webvirtualart.wixsite.com/virtualart", BrowserLaunchMode.SystemPreferred);
        }
    }
}
