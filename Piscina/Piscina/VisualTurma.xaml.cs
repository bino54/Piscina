using Piscina.Models;

namespace Piscina;

public partial class VisualTurma : ContentPage
{
	public VisualTurma()
	{
		InitializeComponent();

        Objetivo ob1 = new Objetivo("Dominio da Respiracao(inspiração/expiração) automatizado");
        List<Objetivo> l1 = new List<Objetivo> { ob1 };
        Categoria c1 = new Categoria("Respiração", l1);

        Objetivo ob2 = new Objetivo("Tem um correto alinhamento lateral e horizontal nas diversas ações motoras. Posição Hidrodinâmica Fundamental");
        List<Objetivo> l2 = new List<Objetivo> { ob2 };
        Categoria c2 = new Categoria("Alinhamento", l2);

        Objetivo ob3 = new Objetivo("Executa batimento de pernas dorsal associado ao movimento alternado de braços/inspiração");
        Objetivo ob4 = new Objetivo("Entrada correta dos membros superiores");
        Objetivo ob5 = new Objetivo("Entrada corretamente a pernada");
        Objetivo ob6 = new Objetivo("Execução de movimentos propulsivos de pernas e braços continuo( nado continuo)");
        List<Objetivo> l3 = new List<Objetivo> { ob3, ob4, ob5, ob6 };
        Categoria c3 = new Categoria("Costas", l3);

        Objetivo ob7 = new Objetivo("Boa postura nos varios planos");
        Objetivo ob8 = new Objetivo("Entrada correta dos membros superiores coordenado com respiração bilateral");
        Objetivo ob9 = new Objetivo("Executa corretamente a pernada");
        Objetivo ob10 = new Objetivo("Execução de movimentos propulsivos de pernas e braços continuo( nado continuo)");
        List<Objetivo> l4 = new List<Objetivo> { ob7, ob8, ob9, ob10 };
        Categoria c4 = new Categoria("Crol", l4);

        Objetivo ob11 = new Objetivo("Da parede, com deslize, com batimento dos pés,de cabeça (inicio do ensino da partida de Crol)");
        List<Objetivo> l5 = new List<Objetivo> { ob11 };
        Categoria c5 = new Categoria("Saltos", l5);

        Objetivo ob12 = new Objetivo("Não corre no cais da piscina, toma banho antes de entrar, arruma o seu material, brinca com segurança");
        List<Objetivo> l6 = new List<Objetivo> { ob12 };
        Categoria c6 = new Categoria("Segurança e higiene", l6);

        Objetivo ob13 = new Objetivo("Espirito de sociabilização e desportivo. Respeita as regras da aula, os colegas e o Professor. É participante na aula");
        List<Objetivo> l7 = new List<Objetivo> { ob13 };
        Categoria c7 = new Categoria("Socio Efetivo", l7);


        List<Categoria> lc1 = new List<Categoria> { c1, c2, c3, c4, c5, c6, c7 };
        FichaAvaliacao f1 = new FichaAvaliacao(lc1);

        Aluno a1 = new Aluno(1000, "Ricardo Rio");
        Aluno a2 = new Aluno(2000, "Manuel Fereira");
        Aluno a3 = new Aluno(3000, "Miguel Oliveira");
        Aluno a4 = new Aluno(4000, "Fernando Daniel");
        Avaliado av1 = new Avaliado(1000, "Ricardo Rio", lc1);
        Avaliado av2 = new Avaliado(2000, "Manuel Fereira", lc1);
        Avaliado av3 = new Avaliado(3000, "Miguel Oliveira", lc1);
        Avaliado av4 = new Avaliado(4000, "Fernando Daniel", lc1);
        List<Aluno> b1 = new List<Aluno>() { a1, a2, a3, a4 };
        List<Avaliado> listav1 = new List<Avaliado>() { av1, av2, av3, av4 };
        Turma turmaA = new Turma("Turma A   ", DateTime.Now, listav1, f1);
        Turma turmaB = new Turma("Turma B   ", DateTime.Now);

        //Avaliacao avaliacao_turmaA = new Avaliacao(listav1 , turmaA,f1);
        List<Turma> turmas = new List<Turma> { turmaA, turmaB };
        Usuario u1 = new Usuario(1000, "senha", "Bernardo", turmas);

        this.BindingContext = u1;
    }

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Turma objetoSelecionado)
        {

            await Navigation.PushAsync(new SelecionarPage(objetoSelecionado));
        }

    }
}