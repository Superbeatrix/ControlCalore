using System.Collections.Generic;

namespace TCC.Models.ViewModel
{
    public class UsuarioHome
    {
        public decimal CaloriasHoje { get; set; }

        public decimal CaloriasOntem { get; set; }

        public decimal LimiteDiario { get; set; }

        public decimal LimiteSemanal { get; set; }

        public List<AlimentoConsumido> AlimentosConsumidosHoje { get; set; }
    }
}
