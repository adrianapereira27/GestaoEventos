
using GestaoEventos.Entidades;

class Program
{
    static void Main(string[] args)
    {
        // Criando Participantes
        Palestrante palestrante1 = new Palestrante("Dr. João Silva", "joao.silva@example.com", "Especialista em Inteligência Artificial");
        Espectador espectador1 = new Espectador("Ana Santos", "ana.santos@example.com", true);
        Espectador espectador2 = new Espectador("Carlos Souza", "carlos.souza@example.com", false);

        // Criando Eventos
        Workshop workshop = new Workshop("Machine Learning", new DateTime(2024, 07, 01, 09, 00, 00), "Auditório 1", 30, "Introdução ao Machine Learning");
        Conferencia conferencia = new Conferencia("Tecnologia", new DateTime(2024, 07, 05, 11, 00, 00), "Centro de Convenções", 100, "O Futuro da Tecnologia");
        Conferencia conferencia2 = new Conferencia("Teste Automatizado", new DateTime(2024, 07, 05, 09, 00, 00), "Auditório 2", 50, "O Futuro dos Testes");

        // Criando Atividades
        Atividade atividade1 = new Atividade("Aula Prática de ML", workshop);
        Atividade atividade2 = new Atividade("Palestra sobre IA", conferencia);
        Atividade atividade3 = new Atividade("Mesa Redonda de Tecnologia", conferencia2);

        // Adicionando Atividades aos Eventos
        workshop.AdicionarAtividade(atividade1);
        conferencia.AdicionarAtividade(atividade2);
        conferencia.AdicionarAtividade(atividade3);
        conferencia2.AdicionarAtividade(atividade1);

        // Inscrevendo Participantes nos Eventos
        workshop.AdicionarParticipante(palestrante1);
        workshop.AdicionarParticipante(espectador1);

        conferencia.AdicionarParticipante(palestrante1);
        conferencia.AdicionarParticipante(espectador1);
        conferencia.AdicionarParticipante(espectador2);

        conferencia2.AdicionarParticipante(palestrante1);
        conferencia2.AdicionarParticipante(espectador1);

        // Criando Agendas
        Agenda agendaPalestrante1 = new Agenda(palestrante1, new DateTime(2024, 07, 01, 09, 00, 00));
        agendaPalestrante1.AdicionarEvento(workshop);
        agendaPalestrante1.AdicionarEvento(conferencia);

        Agenda agendaEspectador1 = new Agenda(espectador1, new DateTime(2024, 07, 01, 11, 00, 00));
        agendaEspectador1.AdicionarEvento(workshop);
        agendaEspectador1.AdicionarEvento(conferencia);
        
        Agenda agendaEspectador2 = new Agenda(espectador2, new DateTime(2024, 07, 01, 14, 00, 00));
        agendaEspectador2.AdicionarEvento(conferencia);
        agendaEspectador2.AdicionarEvento(conferencia2);

        // Exibindo Agendas
        agendaPalestrante1.MostrarAgenda();
        Console.WriteLine();
        agendaEspectador1.MostrarAgenda();
        Console.WriteLine();
        agendaEspectador2.MostrarAgenda();
        Console.WriteLine();

        // Avaliando Atividades
        atividade1.Avaliar(espectador1, 5);
        atividade2.Avaliar(espectador1, 4);
        atividade3.Avaliar(espectador2, 5);
        
        // Exibindo Informações das Atividades
        atividade1.ExibirInformacoes();
        Console.WriteLine();
        atividade2.ExibirInformacoes();
        Console.WriteLine();
        atividade3.ExibirInformacoes();

        
        Console.ReadLine();
    }
}
