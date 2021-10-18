using System.ComponentModel;
using Xamarin.Forms;
using TestBug.ViewModels;

namespace TestBug.Views
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
