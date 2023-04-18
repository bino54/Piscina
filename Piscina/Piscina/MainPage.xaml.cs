namespace Piscina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        /*
        private void OnCounterClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new AboutPage(), true);
        }
        */

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Lógica de validação do login
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (IsValidLogin(username, password))
            {
                // Redirecionar para a próxima página
                // Exemplo:
                Navigation.PushAsync(new VisualTurma());
            }
            else
            {
                // Exibir mensagem de erro de login
                DisplayAlert("Erro", "Usuário ou senha inválidos", "OK");
            }
        }

        private bool IsValidLogin(string username, string password)
        {
            // Lógica de validação do login
            return username == "usuario" && password == "senha";
        }

        private void OnLabelTapped(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignIn());
        }

    }
}