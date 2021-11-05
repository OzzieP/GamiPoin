using GamiPoin.ViewModels;

using System.ComponentModel;

using Xamarin.Forms;

namespace GamiPoin.Views
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