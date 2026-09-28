// TP02 - CBTPRDM
// Igor Cerqueira Murai - CB3033295
// Gustavo Cerqueira Murai - CB3033261

using TarefasApp.Models;

namespace TarefasApp;

public partial class EditarPage : ContentPage
{
    private readonly Tarefa _tarefa;

    public EditarPage(Tarefa tarefa)
    {
        InitializeComponent();

        _tarefa = tarefa;

        PrioridadePicker.ItemsSource = new List<string>
        {
            "Baixa",
            "Média",
            "Alta"
        };

        TituloEntry.Text = _tarefa.Titulo;
        DescricaoEditor.Text = _tarefa.Descricao;
        DataCriacaoPicker.Date = _tarefa.DataCriacao;
        PrioridadePicker.SelectedItem = _tarefa.Prioridade;
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

        _tarefa.Titulo = TituloEntry.Text.Trim();

        _tarefa.Descricao =
            DescricaoEditor.Text?.Trim() ?? string.Empty;

        _tarefa.DataCriacao =
            DataCriacaoPicker.Date ?? _tarefa.DataCriacao;

        _tarefa.Prioridade =
            PrioridadePicker.SelectedItem?.ToString() ?? "Média";

        await Navigation.PopModalAsync();
    }

    private async void CancelarButton_Clicked(
        object? sender,
        EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}