using System;
using System.Collections.Generic;

#nullable disable

namespace SCI_Models.Models
{
    public partial class Local
    {
        public Local()
        {
            Eventos = new HashSet<Evento>();
        }

        public int Codlocal { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Evento> Eventos { get; set; }

        public override string ToString()
        {
            return $"{Endereco}. {Cidade}/{Estado}";
        }
    }
}
