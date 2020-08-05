using LabelRender.ViewModels.Base;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabelRender
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentPageBase : ContentPage
    {
        public ContentPageBase()
        {
            InitializeComponent();
            SizeChanged += BaseViewPage_SizeChanged;
        }

        private void BaseViewPage_SizeChanged(object sender, EventArgs e)
        {
            string visualState = Width > Height ? "Landscape" : "Portrait";
            var lastView = (BaseViewModel)Navigation.NavigationStack.Last().BindingContext;
            switch (visualState)
            {
                case "Landscape":
                    lastView.SmallFontSize = Width / 20;
                    break;
                case "Portrait":
                    lastView.SmallFontSize = Height / 40;
                    break;
            }
        }
    }
}