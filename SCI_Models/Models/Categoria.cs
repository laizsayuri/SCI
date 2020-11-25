using System;
using System.Collections.Generic;

#nullable disable

namespace SCI_Models.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Eventos = new HashSet<Evento>();
        }

        public int Codcategoria { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Evento> Eventos { get; set; }
    }
}
