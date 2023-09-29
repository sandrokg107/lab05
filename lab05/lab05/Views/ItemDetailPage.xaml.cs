using lab05.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace lab05.Views
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