using System.ComponentModel;
using System.Runtime.CompilerServices;
using MauiAppEventos.Models;

namespace MauiAppEventos.ViewModels
{
    public class EventoViewModel : INotifyPropertyChanged
    {
        public Evento Evento { get; set; } = new Evento();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string nome = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nome));
        }
    }
}