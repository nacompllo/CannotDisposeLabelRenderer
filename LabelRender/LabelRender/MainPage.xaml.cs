using LabelRender.ViewModels;
using System.ComponentModel;

namespace LabelRender
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPageBase
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
            btnAdd.Clicked += BtnAdd_Clicked;
        }

        private void BtnAdd_Clicked(object sender, System.EventArgs e)
        {
            var cars = ((MainPageViewModel)BindingContext).CarsList;
            collectionViewCars.ScrollTo(cars.Count);
        }
    }
}