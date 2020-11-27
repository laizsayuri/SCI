using System;
using System.Collections.Generic;

#nullable disable

namespace SCI_Models.Models
{
    public partial class Evento
    {
        public Evento()
        {
            Ingressos = new HashSet<Ingresso>();
        }

        public int Codevento { get; set; }
        public int Codcategoria { get; set; }
        public int Codlocal { get; set; }
        public string Nome { get; set; }
        public string Artista { get; set; }
        public DateTime Data { get; set; }
        public decimal Valoringresso { get; set; }
        public int Numeroingressos { get; set; }
        public string Descricao { get; set; }
        public bool Liberado { get; set; }

        public virtual Categoria CodcategoriaNavigation { get; set; }
        public virtual Local CodlocalNavigation { get; set; }
        public virtual ICollection<Ingresso> Ingressos { get; set; }
    }
}
