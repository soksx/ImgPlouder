using System;
using System.Collections.Generic;
using System.Diagnostics;
using Plugin.Media;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ImgPlouder.Common.Core.Presentation.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        //protected async void fImageZone_Focused(System.Object sender, System.EventArgs e)
        //{
        //    await CrossMedia.Current.Initialize();

        //    if (!CrossMedia.Current.IsPickPhotoSupported)
        //    {
        //        await DisplayAlert("Not Supported!", "Your device does not currently support this funcionality", "OK");
        //        return;
        //    }
        //    var selectedImageFile = await CrossMedia.Current.PickPhotoAsync();
        //    if (selectedImageFile == null) return;
        //    bUpload.IsEnabled = !(lTap4Select.IsVisible = false);
        //    iSelectedImage.Source = ImageSource.FromStream(() => selectedImageFile.GetStream());
        //}
    }
}
