using PiClock_Admin.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PiClock_Admin.ViewModels
{
    class DbConnectionViewModel : BaseViewModel
    {
        #region ICommands
        #region ICommand {SwitchView}
        RelayCommand _switchView;
        public ICommand SwitchView
        {
            get
            {
                if (_switchView == null)
                    _switchView = new RelayCommand(param => SwitchViewExecute(param), param => CanSwitchViewExecute());
                return _switchView;
            }
        }

        void SwitchViewExecute(object param)
        {
            PageSwitcher.ChangeView(param);
        }

        bool CanSwitchViewExecute()
        { return true; }
        #endregion ICommand {SwitchView}
        #region ICommand {UpdateSettings}
        RelayCommand _updateSettings;
        public ICommand UpdateSettings
        {
            get
            {
                if (_updateSettings == null)
                    _updateSettings = new RelayCommand(param => UpdateSettingsExecute(param), param => CanUpdateSettingsExecute());
                return _updateSettings;
            }
        }

        void UpdateSettingsExecute(object param)
        {
            PageSwitcher.ChangeView(param);
        }

        bool CanUpdateSettingsExecute()
        { return true; }
        #endregion ICommand {UpdateSettings}
        #endregion
    }
}
