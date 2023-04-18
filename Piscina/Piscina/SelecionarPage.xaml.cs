using Piscina.Models;

namespace Piscina;

public partial class SelecionarPage : ContentPage
{
    private Turma turma;
    public SelecionarPage()
    {
        InitializeComponent();
    }

    public SelecionarPage(object recebido)
    {
        InitializeComponent();
        this.turma = (Turma)recebido;
    }

    private void ButtonClick(object sender, System.EventArgs e)
    {
        Button button = (Button)sender;
        string buttonText = button.Text;

        // Identifica qual botão foi clicado com base no nome do bot�o
        switch (buttonText)
        {
            case "Avaliacao":
                Navigation.PushAsync(new AvaliacaoPage());
                // Logica para o botão 1
                break;
            case "Lista Alunos":
                Navigation.PushAsync(new VisualAlunos(this.turma));
                // Logica para o botão 2
                break;
            default:
                break;
        }
    }
}