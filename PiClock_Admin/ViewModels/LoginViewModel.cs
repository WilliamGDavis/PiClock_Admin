using PiClock_Admin.Helpers;
using System.Windows.Input;

namespace PiClock_Admin.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        #region ICommands
        #region ICommand {Login}
        RelayCommand _login;
        public ICommand Login
        {
            get
            {
                if (_login == null)
                    _login = new RelayCommand(param => LoginExecute(param), param => CanLoginExecute());
                return _login;
            }
        }

        void LoginExecute(object param)
        {
            PageSwitcher.ChangeView(param);
        }

        bool CanLoginExecute()
        { return true; }
        #endregion ICommand {Login}
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
        #endregion ICommands
    }
}
