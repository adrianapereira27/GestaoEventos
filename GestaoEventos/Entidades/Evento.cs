using GestaoEventos.Enumeradores;

namespace GestaoEventos.Entidades;

public abstract class Evento
{
    public string Nome { get; set; }
    public DateTime Data { get; set; }
    public string Local { get; set; }
    public int CapacidadeMaxima { get; set; }
    public Status Status { get; set; }
    
    private List<Participante> participantes;

    private List<Atividade> atividades;

    public Evento(string nome, DateTime data, string local, int capacidadeMaxima)
    {
        Nome = nome;
        Data = data;
        Local = local;
        CapacidadeMaxima = capacidadeMaxima;
        participantes = new List<Participante>();
        atividades = new List<Atividade>();
    }

    public void AdicionarParticipante(Participante participante)
    {
        if (participantes.Count < CapacidadeMaxima)
        {
            participantes.Add(participante);
        }
        else
        {
            Console.WriteLine("Capacidade máxima atingida.");
        }
    }

    public void RemoverParticipante(Participante participante)
    {
        participantes.Remove(participante);
    }

    public List<Participante> GetParticipantes()
    {
        return new List<Participante>(participantes);
    }

    public void AdicionarAtividade(Atividade atividade)
    {
        atividades.Add(atividade);
    }

    public void RemoverAtividade(Atividade atividade)
    {
        atividades.Remove(atividade);
    }

    public List<Atividade> GetAtividades()
    {
        return new List<Atividade>(atividades);
    }

    public abstract void Iniciar();
    public abstract void Pausar();
    public abstract void Concluir();
    public abstract void Cancelar();
}
