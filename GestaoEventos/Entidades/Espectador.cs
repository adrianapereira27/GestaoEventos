using GestaoEventos.Enumeradores;

namespace GestaoEventos.Entidades;

public class Espectador : Participante
{
    public bool VIP { get; set; }

    public Espectador(string nome, string email, bool vip)
        : base(nome, email)
    {
        VIP = vip;
        TipoParticipante = TipoParticipante.Espectador;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Expectador: {Nome}, Email: {Email}, VIP: {VIP}");
    }

    public override string Participar()
    {
        return $"{Nome} está assistindo ao evento.";
    }
}
