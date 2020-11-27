using System;
using System.Collections.Generic;


#nullable disable

namespace SCI_Models.Models
{
    public partial class PagamentoCartao
    {
        public int Codpagamento { get; set; }
        public int Codingresso { get; set; }
        public decimal Valorapagar { get; set; }
        public string Nometitular { get; set; }
        public string Numerocartao { get; set; }
        public string Datavalidade { get; set; }
        public string Codseguranca { get; set; }
        public bool Transacaoaprovada { get; set; }

        public virtual Ingresso CodingressoNavigation { get; set; }
    }
}
