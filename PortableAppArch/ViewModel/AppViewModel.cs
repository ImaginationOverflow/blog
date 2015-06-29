using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Model;

namespace ViewModel
{
    public class AppViewModel : ViewModelBase
    {
        private readonly IToastNotificationService _toastNotificationService;

        public AppViewModel(IToastNotificationService toastNotificationService)
        {
            _toastNotificationService = toastNotificationService;
        }


        /// <summary>
        /// The <see cref="CurrentToast" /> property's name.
        /// </summary>
        public const string CurrentToastPropertyName = "CurrentToast";

        private int _currToast;

        /// <summary>
        /// Sets and gets the CurrentToast property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public int CurrentToast
        {
            get
            {
                return _currToast;
            }

            set
            {
                if (_currToast == value)
                {
                    return;
                }

                _currToast = value;
                RaisePropertyChanged(CurrentToastPropertyName);
            }
        }

        private ICommand _showToastCommand;

        /// <summary>
        /// Gets the ShowToastCommand.
        /// </summary>
        public ICommand ShowToastCommand
        {
            get
            {
                return _showToastCommand
                    ?? (_showToastCommand = new RelayCommand(
                                          () =>
                                          {
                                              _toastNotificationService.ShowToast(string.Format("This is the toast {0}", ++CurrentToast));
                                          }));
            }
        }
    }
}
