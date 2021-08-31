using System;
using System.Collections.Generic;
using GoodMoodUI.ViewModels;
using Xamarin.Forms;

namespace GoodMoodUI.Views
{
    public partial class GoodMoodMainPage : ContentPage
    {
        public GoodMoodMainPage()
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel();
        }
    }
}
