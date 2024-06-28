using GestaoEventos.Enumeradores;

namespace GestaoEventos.Entidades;

public class Workshop : Evento
{    
    public Palestrante Palestrante { get; set; }
    public string Tema { get; set; }


    public Workshop(string nome, DateTime data, string local, int capacidadeMaxima, string tema)
        : base(nome, data, local, capacidadeMaxima)
    {
        Tema = tema;
        Status = Status.Cadastrado;
    }

    public override void Iniciar()
    {
        Console.WriteLine($"Workshop de {Nome} iniciado.");
        Status = Status.Iniciado;
    }

    public override void Pausar()
    {
        Console.WriteLine($"Workshop de {Nome} pausado.");
        Status = Status.Pausado;
    }

    public override void Concluir()
    {
        Console.WriteLine($"Workshop de {Nome} concluído.");
        Status = Status.Concluido;
    }

    public override void Cancelar()
    {
        Console.WriteLine($"Workshop de {Nome} cancelado.");
        Status = Status.Cancelado;
    }
}
