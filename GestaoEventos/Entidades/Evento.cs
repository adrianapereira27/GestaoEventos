namespace GestaoEventos.Entidades;

public class Evento
{
    public string Nome { get; set; }
    public DateTime Data { get; set; }
    public string Local { get; set; }
    public int CapacidadeMaxima { get; set; }
    public string Status { get; set; }
    public List<Workshop> Workshops { get; set; }
    public List<Conferencia> Conferencias { get; set; }

    public void Iniciar()
    {
        Status = "Iniciado";
    }

    public void Pausar()
    {
        Status = "Pausado";
    }

    public void Concluir() {
        Status = "Concluído";
    }

    public void Cancelar() {
        Status = "Cancelado";
    }

    public void Cadastrar()
    {
    }
}
