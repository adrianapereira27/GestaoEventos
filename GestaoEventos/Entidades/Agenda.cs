using GestaoEventos.Enumeradores;

namespace GestaoEventos.Entidades;

public class Agenda 
{
    public Participante Participante { get; set; }
    public Enum TipoEvento { get; set; }       

    public void Agendar(string nome, TipoEvento tipoEvento) {       

    }
}
