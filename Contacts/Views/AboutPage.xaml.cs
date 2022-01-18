using System;
using System.ComponentModel;
using Contacts.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts.Views
{
    public partial class AboutPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public AboutPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
