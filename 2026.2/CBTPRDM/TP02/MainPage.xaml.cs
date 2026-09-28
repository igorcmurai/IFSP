// TP02 - CBTPRDM
// Igor Cerqueira Murai - CB3033295
// Gustavo Cerqueira Murai - CB3033261

using System.Collections.ObjectModel;
using TarefasApp.Models;

namespace TarefasApp;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Tarefa> Tarefas { get; set; }

    public MainPage()
    {
        InitializeComponent();

        Tarefas = new ObservableCollection<Tarefa>
        {
            new Tarefa
            {
                Titulo = "Estudar .NET MAUI",
                Descricao = "Revisar os conceitos de navegação entre páginas.",
                DataCriacao = DateTime.Today,
                Prioridade = "Alta"
            },

            new Tarefa
            {
                Titulo = "Fazer a TP02",
                Descricao = "Desenvolver a aplicação de lista de tarefas.",
                DataCriacao = DateTime.Today,
                Prioridade = "Alta"
            },

            new Tarefa
            {
                Titulo = "Revisar conteúdo",
                Descricao = "Revisar o código antes da entrega.",
                DataCriacao = DateTime.Today,
                Prioridade = "Média"
            }
        };

        ListaTarefas.ItemsSource = Tarefas;
    }

    private async void ListaTarefas_SelectionChanged(
        object? sender,
        SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count > 0 &&
            e.CurrentSelection[0] is Tarefa tarefaSelecionada)
        {
            ListaTarefas.SelectedItem = null;

            await Navigation.PushAsync(
                new DetalhesPage(tarefaSelecionada, Tarefas));
        }
    }

    private async void AdicionarButton_Clicked(
        object? sender,
        EventArgs e)
    {
        await Navigation.PushModalAsync(
            new AdicionarPage(Tarefas));
    }
}