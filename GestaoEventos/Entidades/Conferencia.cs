namespace GestaoEventos.Entidades;

public class Conferencia : Evento
{
    public string TituloPrincipal { get; set; }

    public Conferencia(string nome, DateTime data, string local, int capacidadeMaxima, string tituloPrincipal)
        : base(nome, data, local, capacidadeMaxima)
    {
        TituloPrincipal = tituloPrincipal;
    }

    public override void Iniciar()
    {
        Console.WriteLine($"Conferência de {Nome} iniciada.");
    }

    public override void Pausar()
    {
        Console.WriteLine($"Conferência de {Nome} pausada.");
    }

    public override void Concluir()
    {
        Console.WriteLine($"Conferência de {Nome} concluída.");
    }

    public override void Cancelar()
    {
        Console.WriteLine($"Conferência de {Nome} cancelada.");
    }
}
