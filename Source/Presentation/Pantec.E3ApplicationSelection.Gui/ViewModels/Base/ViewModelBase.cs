using Pantec.E3Wrapper.ApplicationSelection.Gui.Views.Interfaces;
using System.ComponentModel;

namespace Pantec.E3Wrapper.ApplicationSelection.Gui.ViewModels.Base
{
    /// <inheritdoc />
    /// <summary>
    /// Base class for ViewModels
    /// </summary>
    /// <typeparam name="TViewType"></typeparam>
    public class ViewModelBase<TViewType> : INotifyPropertyChanged where TViewType : IDialogView
    {
        private readonly TViewType _view;

        public event PropertyChangedEventHandler PropertyChanged;

        public TViewType View => _view;

        public ViewModelBase(TViewType view)
        {
            _view = view;
            _view.DataContext = this;
        }

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
