// TP02 - CBTPRDM
// Igor Cerqueira Murai - CB3033295
// Gustavo Cerqueira Murai - CB3033261

using System.Collections.ObjectModel;
using TarefasApp.Models;

namespace TarefasApp;

public partial class AdicionarPage : ContentPage
{
    private readonly ObservableCollection<Tarefa> _tarefas;

    public AdicionarPage(ObservableCollection<Tarefa> tarefas)
    {
        InitializeComponent();

        _tarefas = tarefas;

        PrioridadePicker.ItemsSource = new List<string>
        {
            "Baixa",
            "Média",
            "Alta"
        };

        PrioridadePicker.SelectedIndex = 1;

        DataCriacaoPicker.Date = DateTime.Today;
    }

    private async void SalvarButton_Clicked(
        object? sender,
        EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TituloEntry.Text))
        {
            await DisplayAlertAsync(
                "Atenção",
                "Digite um título para a tarefa.",
                "OK");

            return;
        }

        Tarefa novaTarefa = new Tarefa
        {
            Titulo = TituloEntry.Text.Trim(),

            Descricao = DescricaoEditor.Text?.Trim()
                        ?? string.Empty,

            DataCriacao = DataCriacaoPicker.Date
                          ?? DateTime.Today,

            Prioridade = PrioridadePicker.SelectedItem?.ToString()
                         ?? "Média"
        };

        _tarefas.Add(novaTarefa);

        await Navigation.PopModalAsync();
    }

    private async void CancelarButton_Clicked(
        object? sender,
        EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}