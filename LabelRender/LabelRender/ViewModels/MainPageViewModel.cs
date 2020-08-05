using LabelRender.Models;
using LabelRender.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace LabelRender.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<Car> _carsList = new ObservableCollection<Car>();

        public ObservableCollection<Car> CarsList
        {
            get => _carsList;
            set
            {
                _carsList = value;
                RaiseOnPropertyChanged();
            }
        }

        public ICommand AddCarCommand => new Command(AddCar);

        private void AddCar()
        {
            CarsList.Add(new Car { Model = $"Car {CarsList.Count}" });
        }
    }
}