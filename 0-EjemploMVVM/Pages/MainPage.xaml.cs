using _0_EjemploMVVM.Models;
using _0_EjemploMVVM.PageModels;

namespace _0_EjemploMVVM.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}