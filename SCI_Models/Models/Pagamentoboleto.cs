using System;
using System.Collections.Generic;

#nullable disable

namespace SCI_Models.Models
{
    public partial class Pagamentoboleto
    {
        public int Codpagamento { get; set; }
        public int Codingresso { get; set; }
        public decimal Valorapagar { get; set; }
        public string Numeroboleto { get; set; }
        public DateTime Datavencimento { get; set; }

        public virtual Ingresso CodingressoNavigation { get; set; }
    }
}
