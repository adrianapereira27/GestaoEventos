namespace GestaoEventos.Entidades;

public class Palestrante : Participante
{
    public override string Participar()
    {
        return $"{Nome} está palestrando no evento.";
    }
}
