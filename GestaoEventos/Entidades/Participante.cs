using GestaoEventos.Enumeradores;

namespace GestaoEventos.Entidades;

public abstract class Participante
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public TipoParticipante TipoParticipante { get; set; }

    public Participante(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public abstract string Participar();

    public abstract void ExibirInformacoes();
}

