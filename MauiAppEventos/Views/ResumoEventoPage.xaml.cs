using MauiAppEventos.Models;

namespace MauiAppEventos.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();

            ResumoLabel.Text = $" Nome do Evento: {evento.Nome}\n\n" +
                               $" In�cio: {evento.DataInicio:dd/MM/yyyy}\n" +
                               $" T�rmino: {evento.DataTermino:dd/MM/yyyy}\n" +
                               $" Dura��o: {evento.DuracaoEmDias} dias\n\n" +
                               $" Participantes: {evento.NumeroParticipantes}\n" +
                               $" Local: {evento.Local}\n\n" +
                               $" Custo por Participante: R$ {evento.CustoPorParticipante:F2}\n" +
                               $" Custo Total: R$ {evento.CustoTotal:F2}";
        }
    }
}