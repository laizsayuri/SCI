using System;
using System.Collections.Generic;
using System.Collections;

#nullable disable

namespace SCI_Models.Models
{
    public partial class Pagamentocartao
    {
        public int Codpagamento { get; set; }
        public int Codingresso { get; set; }
        public decimal Valorapagar { get; set; }
        public string Nometitular { get; set; }
        public string Numerocartao { get; set; }
        public string Datavalidade { get; set; }
        public string Codseguranca { get; set; }
        public BitArray Transacaoaprovada { get; set; }

        public virtual Ingresso CodingressoNavigation { get; set; }
    }
}
