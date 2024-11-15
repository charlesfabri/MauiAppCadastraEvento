using System.Windows.Input;

namespace MauiAppCadastraEvento.Views;

public partial class TelaCadastroEvento : ContentPage
{
    public Evento Evento { get; set; }
    public ICommand CadastrarEventoCommand { get; }

    public TelaCadastroEvento()
    {
        InitializeComponent();
        Evento = new Evento();
        BindingContext = this;

        CadastrarEventoCommand = new Command(CadastrarEvento);
    }

    private async void CadastrarEvento()
    {
        await Navigation.PushAsync(new TelaResumoEvento(Evento));
    }
}



