using PiClock_Admin.ViewModels;
using PiClock_Admin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PiClock_Admin.Helpers
{
    class PageSwitcher : BaseViewModel
    {
        #region Singleton
        private static PageSwitcher _instance;
        private PageSwitcher() { }
        public static PageSwitcher Instance
        {
            get { return _instance ?? (_instance = new PageSwitcher()); }
        }
        #endregion

        #region Properties and Members
        private Dictionary<string, UserControl> _views;
        private Dictionary<string, UserControl> Views
        {
            get
            {
                if (_views == null)
                    _views = new Dictionary<string, UserControl>()
                    {
                        { "LoginView", Instance.LoginView },
                        { "DbConnectionView", Instance.DbConnectionView },
                        { "HomeView", Instance.HomeView },
                        { "EmployeeConfigurationView", Instance.EmployeeConfigurationView },
                        { "ApplicationSettingsView", Instance.ApplicationSettingsView },
                        { "ReportsView", Instance.ReportsView },
                        { "JobConfigurationView", Instance.JobConfigurationView }
                    };
                return _views;
            }
        }

        private UserControl _currentView;
        public UserControl CurrentView
        {
            get
            {
                if (_currentView == null)
                    _currentView = LoginView;
                return _currentView;
            }
            set
            {
                if (_currentView != value)
                    _currentView = value;
                RaisePropertyChanged("CurrentView");
            }
        }

        private UserControl _loginView;
        private UserControl LoginView
        {
            get
            {
                if (_loginView == null)
                    _loginView = new LoginView();
                return _loginView;
            }
        }

        private UserControl _dbConnectionView;
        private UserControl DbConnectionView
        {
            get
            {
                if (_dbConnectionView == null)
                    _dbConnectionView = new DbConnectionView();
                return _dbConnectionView;
            }
        }

        private UserControl _homeView;
        private UserControl HomeView
        {
            get
            {
                if (_homeView == null)
                    _homeView = new HomeView();
                return _homeView;
            }
        }

        private UserControl _employeeConfigurationView;
        public UserControl EmployeeConfigurationView
        {
            get
            {
                if (_employeeConfigurationView == null)
                    _employeeConfigurationView = new EmployeeConfigurationView();
                return _employeeConfigurationView;
            }
        }

        private UserControl _applicationSettingsView;
        public UserControl ApplicationSettingsView
        {
            get
            {
                if (_applicationSettingsView == null)
                    _applicationSettingsView = new ApplicationSettingsView();
                return _applicationSettingsView;
            }
        }

        private UserControl _reportsView;
        public UserControl ReportsView
        {
            get
            {
                if (_reportsView == null)
                    _reportsView = new ReportsView();
                return _reportsView;
            }
        }

        private UserControl _jobConfigurationView;
        public UserControl JobConfigurationView
        {
            get
            {
                if (_jobConfigurationView == null)
                    _jobConfigurationView = new JobConfigurationView();
                return _jobConfigurationView;
            }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Change the View, typically done from the ViewModel page (using an ICommand)
        /// </summary>
        /// <param name="requestedView">Passed in by the RelayCommand</param>
        public void ChangeView(object requestedView)
        {
            string newView = requestedView.ToString();

            //Throw an error if the View is not in the Views dictionary
            if (!Views.ContainsKey(newView))
                throw new KeyNotFoundException(string.Format("{0} is not a valid View", newView));

            //Update the CurrentView
            CurrentView = Views[newView];
        }
        #endregion Methods
    }
}
