﻿using System;

using TestVersion1_1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestVersion1_1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
