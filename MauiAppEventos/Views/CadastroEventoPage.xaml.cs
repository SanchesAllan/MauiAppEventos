using MauiAppEventos.Models;
using MauiAppEventos.ViewModels;

namespace MauiAppEventos.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        public CadastroEventoPage()
        {
            InitializeComponent();
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            var vm = BindingContext as EventoViewModel;
            if (vm == null)
                return;

            var hoje = DateTime.Today;

            if (vm.Evento.DataInicio < hoje)
            {
                await DisplayAlert("Erro", "A data de início não pode ser anterior a hoje.", "OK");
                return;
            }

            if (vm.Evento.DataTermino < vm.Evento.DataInicio)
            {
                await DisplayAlert("Erro", "A data de término não pode ser anterior à data de início.", "OK");
                return;
            }

            await Navigation.PushAsync(new ResumoEventoPage(vm.Evento));
        }
    }
}