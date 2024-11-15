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
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {


            Evento ev = new Evento()
            {               


            };

            await Navigation.PushAsync(new TelaResumoEvento(ev)
            {
                BindingContext = ev
            });

        }
        catch (Exception)
        {

            throw;
        }


    }


}



