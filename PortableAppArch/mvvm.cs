class View : Activity
{
	SomeViewModel viewmodel = ...;

	public void OnCreate(..)
	{
		someLabel.Text.BindTo( () => viewmodel.SomeTextProperty)
	}
	
	
	public void OnButtonClicked(...)
	{
		viewmodel.BeginActionCommand.Execute(null);
	}
}

class SomeViewModel : INotifyPropertyChanged {
	
	private string _someText;
	public string SomeTextProperty
	{
		get {return _someText;}
		set{
			if(value == _someText)
				return;
			
			_someText = value;
			NotifyPropertyChanged();
		}
	}

	private SomeModel _model = ...;
	
	private ICommand _beginActionCommand;
	public ICommand BeginActionCommand {
		get {
			return _beginActionCommand ?? (_beginActionCommand = new RelayCommand(
			async () => {
				await _model.DoStuff();
				SomeTextProperty = ...;
			}));
		}
	}
}

#region INotifyPropertyChanged 
	public event PropertyChangedEventHandler PropertyChanged;
	
	private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {
		if (PropertyChanged != null) {
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
#endregion
