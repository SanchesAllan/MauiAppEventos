using MauiAppEventos.Models;

namespace MauiAppEventos.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();

            ResumoLabel.Text = $" Nome do Evento: {evento.Nome}\n\n" +
                               $" Início: {evento.DataInicio:dd/MM/yyyy}\n" +
                               $" Término: {evento.DataTermino:dd/MM/yyyy}\n" +
                               $" Duração: {evento.DuracaoEmDias} dias\n\n" +
                               $" Participantes: {evento.NumeroParticipantes}\n" +
                               $" Local: {evento.Local}\n\n" +
                               $" Custo por Participante: R$ {evento.CustoPorParticipante:F2}\n" +
                               $" Custo Total: R$ {evento.CustoTotal:F2}";
        }
    }
}