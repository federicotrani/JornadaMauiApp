namespace JornadaMauiApp.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();
		BindingContext = loginViewModel;
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		edtPassword.IsPassword = !edtPassword.IsPassword;
		imgPassword.Source = ImageSource.FromFile(edtPassword.IsPassword ? "visibility" : "visibility_off" ); 
    }
}