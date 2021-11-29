using System;

namespace TCC.Models.ViewModel
{
    public class AlimentoConsumido
    {
        public long AlimentoUsuarioId { get; set; }

        public string Nome { get; set; }

        public decimal Caloria { get; set; }

        public string Tipo { get; set; }

        public string Imagem { get; set; }

        public short Quantidade { get; set; }

        public string DataConsumo { get; set; }
    }
}
