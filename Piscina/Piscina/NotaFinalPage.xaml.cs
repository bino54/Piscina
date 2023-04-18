using Piscina.Models;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace Piscina;

public partial class NotaFinalPage : ContentPage
{
	private Categoria c1;
	public NotaFinalPage()
	{
		InitializeComponent();
	}

	public NotaFinalPage(Object recebido)
    {
        InitializeComponent ();

		c1 = (Categoria) recebido;

		listObjetivos.ItemsSource = c1.Objetivos;

    }

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Objetivo objeto)
        {

            await Navigation.PushAsync(new AvaliacaoPage(objeto));
        }

    }



}