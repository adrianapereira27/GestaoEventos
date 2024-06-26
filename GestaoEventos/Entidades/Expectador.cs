namespace GestaoEventos.Entidades;

public class Expectador : Participante
{
    public override string Participar()
    {
        return $"{Nome} está assistindo ao evento.";
    }
}
