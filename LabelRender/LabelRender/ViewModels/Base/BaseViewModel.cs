using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LabelRender.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private double _smallFontSize;

        public double SmallFontSize
        {
            get => _smallFontSize;
            set
            {
                _smallFontSize = value;
                RaiseOnPropertyChanged();
            }
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
