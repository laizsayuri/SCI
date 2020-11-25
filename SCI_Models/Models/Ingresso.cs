using System;
using System.Collections.Generic;
using System.Collections;

#nullable disable

namespace SCI_Models.Models
{
    public partial class Ingresso
    {
        public Ingresso()
        {
            Pagamentoboletos = new HashSet<PagamentoBoleto>();
            Pagamentocartaos = new HashSet<PagamentoCartao>();
        }

        public int Codingresso { get; set; }
        public int Codevento { get; set; }
        public int Codcliente { get; set; }
        public bool Valorinteiro { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; }
        public virtual Evento CodeventoNavigation { get; set; }
        public virtual ICollection<PagamentoBoleto> Pagamentoboletos { get; set; }
        public virtual ICollection<PagamentoCartao> Pagamentocartaos { get; set; }
    }
}
