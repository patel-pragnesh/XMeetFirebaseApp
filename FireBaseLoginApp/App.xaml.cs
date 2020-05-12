﻿using System;
using FireBaseLoginApp.Admin.Views;
using FireBaseLoginApp.Views.Login;
using FireBaseLoginApp.Views.UI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FireBaseLoginApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
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
