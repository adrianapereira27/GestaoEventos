namespace GestaoEventos.Entidades;

public class Palestrante : Participante
{
    public string Biografia { get; set; }

    
    public Palestrante(string nome, string email, string biografia)
        : base(nome, email)
    {
        Biografia = biografia;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Palestrante: {Nome}, Email: {Email}, Biografia: {Biografia}");
    }

    public override string Participar()
    {
        return $"{Nome} está palestrando no evento.";
    }
}
