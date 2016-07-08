using PiClock_Admin.Classes;

namespace PiClock_Admin.Models
{
    class LoginModel : BaseClass
    {
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                    _username = value;
                RaisePropertyChanged("Username");
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                    _password = value;
                RaisePropertyChanged("Password");
            }
        }
    }
}
