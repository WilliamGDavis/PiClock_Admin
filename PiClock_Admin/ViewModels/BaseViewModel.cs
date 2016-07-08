using PiClock_Admin.Classes;
using PiClock_Admin.Helpers;
using PiClock_Admin.Models;
using System.Collections.Generic;

namespace PiClock_Admin.ViewModels
{
    class BaseViewModel : BaseClass
    {
        public PageSwitcher PageSwitcher
        {
            get { return PageSwitcher.Instance; }
        }
    }
}
