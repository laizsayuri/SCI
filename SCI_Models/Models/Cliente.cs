using System;
using System.Collections.Generic;

#nullable disable

namespace SCI_Models.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Ingressos = new HashSet<Ingresso>();
        }

        public int Codcliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Datanascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Ingresso> Ingressos { get; set; }
    }
}
