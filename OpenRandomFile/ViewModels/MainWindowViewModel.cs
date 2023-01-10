using Prism.Mvvm;
using System.ComponentModel;

namespace OpenRandomFile.ViewModels
{
    public class MainWindowViewModel : BindableBase, INotifyPropertyChanged
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
