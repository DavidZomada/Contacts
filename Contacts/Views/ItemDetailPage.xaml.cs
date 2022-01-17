using System.ComponentModel;
using Xamarin.Forms;
using Contacts.ViewModels;

namespace Contacts.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
