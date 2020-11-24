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
            Pagamentoboletos = new HashSet<Pagamentoboleto>();
            Pagamentocartaos = new HashSet<Pagamentocartao>();
        }

        public int Codingresso { get; set; }
        public int Codevento { get; set; }
        public int Codcliente { get; set; }
        public BitArray Valorinteiro { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; }
        public virtual Evento CodeventoNavigation { get; set; }
        public virtual ICollection<Pagamentoboleto> Pagamentoboletos { get; set; }
        public virtual ICollection<Pagamentocartao> Pagamentocartaos { get; set; }
    }
}
