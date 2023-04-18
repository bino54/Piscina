using Piscina.Models;

namespace Piscina;

public partial class SignIn : ContentPage
{
    Usuario user;

	public SignIn()
	{
		InitializeComponent();
	}

    private void InserirUtilizador(object sender, EventArgs e)
    {
        // Lógica de validação do login
        int nif = int.Parse(NifEntry.Text);
        string password = PasswordEntry.Text;
        string nome = NomeEntry.Text;

        user = new Usuario(nif, password, nome);

        DisplayAlert("Usuario Adicionado", user.Nif.ToString(), "OK");

        Navigation.PushAsync(new MainPage());
    }




}