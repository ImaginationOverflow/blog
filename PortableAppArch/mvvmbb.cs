private interface ICommand
{
	bool CanExecute([In] object parameter);
	void Execute([In] object parameter);
	event EventHandler<object> CanExecuteChanged;
}

public interface INotifyPropertyChanged
{
    event PropertyChangedEventHandler PropertyChanged;
}

public interface IToastNotificationService
{
	string ShowToast(string toast);
}

public class SomeViewModel
{
	private IToastNotificationService _toastNotficationService
	public SomeViewModel(IToastNotificationService toastNotficationService)
	{
		_toastNotficationService = toastNotficationService;
	}
	
	
	private ICommand _showToastCommand
	public ICommand ShowToastCommand
	{
		get
		{ 
			return _showToastCommand??
			new RelayCommand(()=>
			{
				_toastNotficationService.ShowToast("Toasttext");
			})
		}
	}
}