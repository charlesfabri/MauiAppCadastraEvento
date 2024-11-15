namespace MauiAppCadastraEvento.Views;


public partial class TelaResumoEvento : ContentPage
{
	public TelaResumoEvento(Evento evento)
	{
		InitializeComponent();
        BindingContext = evento;
    }
}



