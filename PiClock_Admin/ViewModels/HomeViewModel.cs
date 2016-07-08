using PiClock_Admin.Helpers;
using System.Windows.Controls;
using System.Windows.Input;

namespace PiClock_Admin.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        private UserControl _currentHomeView;
        public UserControl CurrentHomeView
        {
            get { return _currentHomeView; }
            set
            {
                if (_currentHomeView != value)
                    _currentHomeView = value;
                RaisePropertyChanged("CurrentHomeView");
            }
        }
        
        #region ICommands
        #region ICommand {ChangeView}
        RelayCommand _changeHomeView;
        public ICommand ChangeHomeView
        {
            get
            {
                if (_changeHomeView == null)
                    _changeHomeView = new RelayCommand(param => ChangeHomeViewExecute(param), param => CanChangeHomeViewExecute());
                return _changeHomeView;
            }
        }

        void ChangeHomeViewExecute(object param)
        {
            if (param.ToString() == "EmployeeConfigurationView")
                CurrentHomeView = PageSwitcher.EmployeeConfigurationView;
            if (param.ToString() == "JobConfigurationView")
                CurrentHomeView = PageSwitcher.JobConfigurationView;
            if (param.ToString() == "ApplicationSettingsView")
                CurrentHomeView = PageSwitcher.ApplicationSettingsView;
            if (param.ToString() == "ReportsView")
                CurrentHomeView = PageSwitcher.ReportsView;
        }

        bool CanChangeHomeViewExecute()
        { return true; }
        #endregion ICommand {ChangeView}
        #region ICommand {Logout}
        RelayCommand _logOut;
        public ICommand LogOut
        {
            get
            {
                if (_logOut == null)
                    _logOut = new RelayCommand(param => LogOutExecute(param), param => CanLogOutExecute());
                return _logOut;
            }
        }

        void LogOutExecute(object param)
        { PageSwitcher.ChangeView(param); }

        bool CanLogOutExecute()
        { return true; }
        #endregion ICommand {Logout}
        #endregion ICommands
    }
}
