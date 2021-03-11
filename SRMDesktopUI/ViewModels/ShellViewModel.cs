using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace SRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private LoginViewModel _loinVM;
        public ShellViewModel(LoginViewModel loginVM)
        {
            _loinVM = loginVM;
            ActivateItem(_loinVM);
        }
    }
}
