using System;
using System.Collections.Generic;
using TestVersion1_1.ViewModels;
using TestVersion1_1.Views;
using Xamarin.Forms;

namespace TestVersion1_1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
