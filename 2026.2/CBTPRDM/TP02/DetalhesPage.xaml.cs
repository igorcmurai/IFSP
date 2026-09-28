// TP02 - CBTPRDM
// Igor Cerqueira Murai - CB3033295
// Gustavo Cerqueira Murai - CB3033261

using System.Collections.ObjectModel;
using TarefasApp.Models;

namespace TarefasApp;

public partial class DetalhesPage : ContentPage
{
    private readonly Tarefa _tarefa;
    private readonly ObservableCollection<Tarefa> _tarefas;

    public DetalhesPage(
        Tarefa tarefa,
        ObservableCollection<Tarefa> tarefas)
    {
        InitializeComponent();

        _tarefa = tarefa;
        _tarefas = tarefas;

        BindingContext = _tarefa;
    }

    private async void VoltarButton_Clicked(
        object? sender,
        EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void EditarButton_Clicked(
        object? sender,
        EventArgs e)
    {
        await Navigation.PushModalAsync(
            new EditarPage(_tarefa));
    }

    private async void ExcluirButton_Clicked(
        object? sender,
        EventArgs e)
    {
        bool confirmar = await DisplayAlertAsync(
            "Confirmar exclusão",
            $"Deseja realmente excluir a tarefa \"{_tarefa.Titulo}\"?",
            "Excluir",
            "Cancelar");

        if (confirmar)
        {
            _tarefas.Remove(_tarefa);

            await Navigation.PopAsync();
        }
    }
}