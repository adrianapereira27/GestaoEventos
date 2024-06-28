using GestaoEventos.Enumeradores;

namespace GestaoEventos.Entidades;

public class Agenda 
{
    public Participante Participante { get; private set; }    
    private List<Evento> eventos;

    public Agenda(Participante participante)
    {
        Participante = participante;
        eventos = new List<Evento>();
    }

    public void AdicionarEvento(Evento evento)
    {
        eventos.Add(evento);
    }

    public void RemoverEvento(Evento evento)
    {
        eventos.Remove(evento);
    }

    public void MostrarAgenda()
    {
        Console.WriteLine($"Agenda de {Participante.Nome}:");
        foreach (var evento in eventos)
        {
            evento.Iniciar(); // Polimorfismo
        }
    }
        
}
