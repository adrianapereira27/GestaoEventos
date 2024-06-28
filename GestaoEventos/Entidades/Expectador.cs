namespace GestaoEventos.Entidades;

public class Expectador : Participante
{
    public bool VIP { get; set; }

    public Expectador(string nome, string email, bool vip)
        : base(nome, email)
    {
        VIP = vip;
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
