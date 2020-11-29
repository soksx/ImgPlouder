using System;
using ImgPlouder.Common.Resources.ResourceDictionaries;
using ImgPlouder.Common.Views;
using Xamarin.Forms;

namespace ImgPlouder.Common.Helpers
{
    public static class ThemeHelper
    {
        public static void InitializeAppTheme()
        {
            App.Current.Resources = App.Current.RequestedTheme switch
            {
                OSAppTheme.Dark => new DarkTheme(),
                _ => new LightTheme()
            };
        }
    }
}
