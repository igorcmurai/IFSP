// TP02 - CBTPRDM
// Igor Cerqueira Murai - CB3033295
// Gustavo Cerqueira Murai - CB3033261

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TarefasApp.Models;

public class Tarefa : INotifyPropertyChanged
{
    private string _titulo = string.Empty;
    private string _descricao = string.Empty;
    private DateTime _dataCriacao = DateTime.Today;
    private string _prioridade = "Média";

    public string Titulo
    {
        get => _titulo;

        set
        {
            if (_titulo != value)
            {
                _titulo = value;
                OnPropertyChanged();
            }
        }
    }

    public string Descricao
    {
        get => _descricao;

        set
        {
            if (_descricao != value)
            {
                _descricao = value;
                OnPropertyChanged();
            }
        }
    }

    public DateTime DataCriacao
    {
        get => _dataCriacao;

        set
        {
            if (_dataCriacao != value)
            {
                _dataCriacao = value;
                OnPropertyChanged();
            }
        }
    }

    public string Prioridade
    {
        get => _prioridade;

        set
        {
            if (_prioridade != value)
            {
                _prioridade = value;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(
            this,
            new PropertyChangedEventArgs(propertyName));
    }
}