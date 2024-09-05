namespace ProbandoEnNetMaui.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private async void btnRegistrarse_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistrarseView());
    }
}