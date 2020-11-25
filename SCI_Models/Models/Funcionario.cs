using System;
using System.Collections.Generic;
using System.Collections;

#nullable disable

namespace SCI_Models.Models
{
    public partial class Funcionario
    {
        public int Codfuncionario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public bool Admin { get; set; }
    }
}
