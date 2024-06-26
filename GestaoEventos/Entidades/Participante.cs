namespace GestaoEventos.Entidades;

public abstract class Participante
{
    public string Nome { get; set; }

    public void Cadastrar()
    {

    }

    public abstract string Participar();    
}

