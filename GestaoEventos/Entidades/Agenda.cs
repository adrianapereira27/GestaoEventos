using GestaoEventos.Enumeradores;

namespace GestaoEventos.Entidades;

public class Agenda 
{
    public DateTime Horario { get; set; }
    public Participante Participante { get; private set; }    
    
    private List<Evento> eventos;

    public Agenda(Participante participante, DateTime horario)
    {
        Horario = horario;
        Participante = participante;
        eventos = new List<Evento>();        
    }

    private bool VerificarConflitoDeHorario(DateTime horario)
    {
        if (horario == this.Horario)
        {
            return false;
        }
        return true;
    }

    public void AdicionarEvento(Evento evento)
    {
        if (VerificarConflitoDeHorario(evento.DataHora))
        {
            Console.WriteLine("Já existe um evento neste horário!");            
        }
        else
        {
            eventos.Add(evento);
        }       
    }

    public void RemoverEvento(Evento evento)
    {
        eventos.Remove(evento);
    }

    public void MostrarAgenda()
    {
        Console.WriteLine($"Agenda do {Participante.TipoParticipante} {Participante.Nome}:");
        foreach (var evento in eventos)
        {
            evento.Iniciar(); // Polimorfismo
        }
    }
        
}
