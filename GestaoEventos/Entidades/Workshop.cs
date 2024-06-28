namespace GestaoEventos.Entidades;

public class Workshop : Evento
{    
    public Palestrante Palestrante { get; set; }
    public string Tema { get; set; }


    public Workshop(string nome, DateTime data, string local, int capacidadeMaxima, string tema)
        : base(nome, data, local, capacidadeMaxima)
    {
        Tema = tema;
    }

    public override void Iniciar()
    {
        Console.WriteLine($"Workshop de {Nome} iniciado.");
    }

    public override void Pausar()
    {
        Console.WriteLine($"Workshop de {Nome} pausado.");
    }

    public override void Concluir()
    {
        Console.WriteLine($"Workshop de {Nome} concluído.");
    }

    public override void Cancelar()
    {
        Console.WriteLine($"Workshop de {Nome} cancelado.");
    }
}
