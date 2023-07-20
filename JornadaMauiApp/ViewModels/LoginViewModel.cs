using System.Runtime.CompilerServices;

namespace JornadaMauiApp.ViewModels;

public class LoginViewModel : ViewModelBase
{
    public LoginViewModel()
    {
        Title = "Iniciar Sesion";
		LoginCommand = new(async()=> await LoginAsync(), 
			() => !String.IsNullOrWhiteSpace(UserName) && !String.IsNullOrWhiteSpace(Password));
    }

	private string password;

	public string Password
	{
		get => password;
			
		set => SetProperty(ref password, value, LoginCommand.ChangeCanExecute);
	}

	private string userName;

	public string UserName
	{
		get => userName;
		set => SetProperty(ref userName, value, LoginCommand.ChangeCanExecute);
	}

    public Command	LoginCommand { get; set; }

	private async Task LoginAsync()
	{
		if(!IsBusy)
		{
			IsBusy = true;

			UserName = string.Empty; 
			Password = string.Empty;

			UserCredentials userCredentials = new(userName, password);

			await Task.Delay(3000);

			Application.Current.MainPage = new AppShell();

			IsBusy=false;
		}
	}
}
