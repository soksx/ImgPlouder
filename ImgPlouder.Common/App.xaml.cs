using System;
using System.Collections.Generic;

using ImgPlouder.Common.Helpers;
using ImgPlouder.Common.Core.Presentation.Views;

using Xamarin.Forms;

namespace ImgPlouder.Common
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
#if DEBUG
            HotReloader.Current.Run(this);
#endif
            ThemeHelper.InitializeAppTheme();
            Application.Current.RequestedThemeChanged += (s, a) =>
            {
                ThemeHelper.InitializeAppTheme();
            };
            MainPage = new NavigationPage(new MainPage());
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
