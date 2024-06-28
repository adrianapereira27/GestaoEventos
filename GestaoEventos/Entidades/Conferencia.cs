using GestaoEventos.Enumeradores;

namespace GestaoEventos.Entidades;

public class Conferencia : Evento
{
    public string TituloPrincipal { get; set; }    

    public Conferencia(string nome, DateTime data, string local, int capacidadeMaxima, string tituloPrincipal)
        : base(nome, data, local, capacidadeMaxima)
    {
        TituloPrincipal = tituloPrincipal;
        Status = Status.Cadastrado;
    }

    public override void Iniciar()
    {
        Console.WriteLine($"Conferência de {Nome} iniciada.");
        Status = Status.Iniciado;
    }

    public override void Pausar()
    {
        Console.WriteLine($"Conferência de {Nome} pausada.");
        Status = Status.Pausado;
    }

    public override void Concluir()
    {
        Console.WriteLine($"Conferência de {Nome} concluída.");
        Status = Status.Concluido;
    }

    public override void Cancelar()
    {
        Console.WriteLine($"Conferência de {Nome} cancelada.");
        Status = Status.Cancelado;
    }
}
