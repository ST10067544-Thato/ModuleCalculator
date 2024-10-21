using ModuleCalculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModuleCalculator.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand CalculateModuleHoursViewCommand { get; set; }
        public RelayCommand ModuleHoursViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public ModuleHoursViewModel ModuleHoursVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            ModuleHoursVM = new ModuleHoursViewModel();
            CurrentView = HomeVM; //This is the default view when the app launches.

            //This is for when the 1st radio button is pressed, it must show the home page
            HomeViewCommand = new RelayCommand(o => 
            { 
                CurrentView = HomeVM;
            });

            //This is for when the 2nd radio button is pressed, it must show the calculation page
            ModuleHoursViewCommand = new RelayCommand(o =>
            {
                CurrentView = ModuleHoursVM;
            });
        }
    }
}
