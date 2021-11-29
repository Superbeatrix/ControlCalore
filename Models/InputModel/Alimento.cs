namespace TCC.Models.InputModel
{
    public class Alimento
    {
        public long AlimentoId { get; set; }

        public string Nome { get; set; }

        public decimal Caloria { get; set; }

        public string Tipo { get; set; }

        public string Imagem { get; set; }

        public bool Ativo { get; set; }
    }
}
