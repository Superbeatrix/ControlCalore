using System;

namespace TCC.Models.InputModel
{
    public class UsuarioAlimento
    {
        public long UsuarioAlimentoId { get; set; }

        public long UsuarioId { get; set; }

        public long AlimentoId { get; set; }

        public string Observacao { get; set; }

        public DateTime DataConsumo { get; set; }

        public int Quantidade { get; set; }

        public bool Ativo { get; set; }
    }
}
