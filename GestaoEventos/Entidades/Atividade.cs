namespace GestaoEventos.Entidades
{
    public class Atividade
    {
        public string Nome { get; set; }
        public DateTime Horario { get; set; }

        private Dictionary<Participante, int> avaliacoes;

        public Atividade(string nome, DateTime horario)
        {
            Nome = nome;
            Horario = horario;
            avaliacoes = new Dictionary<Participante, int>();
        }

        public void Avaliar(Participante participante, int nota)
        {
            if (avaliacoes.ContainsKey(participante))
            {
                avaliacoes[participante] = nota;
            }
            else
            {
                avaliacoes.Add(participante, nota);
            }
        }

        private double MediaAvaliacoes()
        {
            if (avaliacoes.Count == 0) return 0;

            double total = 0;
            foreach (var nota in avaliacoes.Values)
            {
                total += nota;
            }
            return total / avaliacoes.Count;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Atividade: {Nome}, Horário: {Horario}");
            Console.WriteLine($"Média de Avaliações: {MediaAvaliacoes()}");
        }
    }
}
