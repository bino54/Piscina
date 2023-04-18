using Piscina.Models;

namespace Piscina;

public partial class VisualAlunos : ContentPage
{
    private Turma turmaXD;
	public VisualAlunos()
	{
		InitializeComponent();

    }

    public VisualAlunos(object recebido)
    {
        InitializeComponent();
        turmaXD = (Turma)recebido;
        this.BindingContext = turmaXD;

    }

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Avaliado objetoSelecionado)
        {

            await Navigation.PushAsync(new AvaliadoPage(objetoSelecionado));
        }

    }
}