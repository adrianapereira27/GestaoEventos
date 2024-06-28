
using GestaoEventos.Entidades;

class Program
{
    static void Main(string[] args)
    {
        // Criando Participantes
        Palestrante palestrante1 = new Palestrante("Dr. João Silva", "joao.silva@example.com", "Especialista em Inteligência Artificial");
        Espectador expectador1 = new Espectador("Ana Santos", "ana.santos@example.com", true);
        Espectador expectador2 = new Espectador("Carlos Souza", "carlos.souza@example.com", false);

        // Criando Eventos
        Workshop workshop = new Workshop("Machine Learning", new DateTime(2024, 07, 01), "Auditório 1", 30, "Introdução ao Machine Learning");
        Conferencia conferencia = new Conferencia("Tecnologia", new DateTime(2024, 07, 05), "Centro de Convenções", 100, "O Futuro da Tecnologia");

        // Criando Atividades
        Atividade atividade1 = new Atividade("Aula Prática de ML", new DateTime(2024, 07, 01, 09, 00, 00));
        Atividade atividade2 = new Atividade("Palestra sobre IA", new DateTime(2024, 07, 05, 10, 00, 00));
        Atividade atividade3 = new Atividade("Mesa Redonda de Tecnologia", new DateTime(2024, 07, 05, 14, 00, 00));

        // Adicionando Atividades aos Eventos
        workshop.AdicionarAtividade(atividade1);
        conferencia.AdicionarAtividade(atividade2);
        conferencia.AdicionarAtividade(atividade3);

        // Inscrevendo Participantes nos Eventos
        workshop.AdicionarParticipante(palestrante1);
        workshop.AdicionarParticipante(expectador1);

        conferencia.AdicionarParticipante(palestrante1);
        conferencia.AdicionarParticipante(expectador1);
        conferencia.AdicionarParticipante(expectador2);

        // Criando Agendas
        Agenda agendaPalestrante1 = new Agenda(palestrante1);
        agendaPalestrante1.AdicionarEvento(workshop);
        agendaPalestrante1.AdicionarEvento(conferencia);

        Agenda agendaExpectador1 = new Agenda(expectador1);
        agendaExpectador1.AdicionarEvento(workshop);
        agendaExpectador1.AdicionarEvento(conferencia);

        Agenda agendaExpectador2 = new Agenda(expectador2);
        agendaExpectador2.AdicionarEvento(conferencia);

        // Exibindo Agendas
        agendaPalestrante1.MostrarAgenda();
        Console.WriteLine();
        agendaExpectador1.MostrarAgenda();
        Console.WriteLine();
        agendaExpectador2.MostrarAgenda();
        Console.WriteLine();

        // Avaliando Atividades
        atividade1.Avaliar(expectador1, 5);
        atividade2.Avaliar(expectador1, 4);
        atividade3.Avaliar(expectador2, 5);
        
        // Exibindo Informações das Atividades
        atividade1.ExibirInformacoes();
        Console.WriteLine();
        atividade2.ExibirInformacoes();
        Console.WriteLine();
        atividade3.ExibirInformacoes();

        
        Console.ReadLine();
    }
}
