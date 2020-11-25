using SCI_Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCI_Controllers.Controllers
{
    public class FuncionarioController
    {
        private readonly sciContext db;

        public FuncionarioController()
        {
            db = new sciContext();
        }

        public void Save(Funcionario funcionario)
        {
            db.Funcionarios.Add(funcionario);
            db.SaveChanges();
        }

        public void Edit(Funcionario funcionario)
        {
            Funcionario entidadeSalva = db.Funcionarios.FirstOrDefault(e => e.Codfuncionario == funcionario.Codfuncionario);
            if(entidadeSalva != null)
            {
                entidadeSalva.Nome = funcionario.Nome;
                entidadeSalva.Cpf = funcionario.Cpf;
                entidadeSalva.Email = funcionario.Email;

                db.SaveChanges();
            }
        }

        public void EditSenha(Funcionario funcionario)
        {
            Funcionario entidadeSalva = db.Funcionarios.FirstOrDefault(e => e.Codfuncionario == funcionario.Codfuncionario);
            if(entidadeSalva != null)
            {
                entidadeSalva.Senha = funcionario.Senha;

                db.SaveChanges();
            }

        }

        public Funcionario GetById(int CodFuncionario)
        {
            Funcionario entidade = db.Funcionarios.FirstOrDefault(e => e.Codfuncionario == CodFuncionario);
            
            return entidade;
        }

        public List<Funcionario> GetAll()
        {
            return db.Funcionarios.ToList();
        }

        public void Remove(int CodFuncionario)
        {
            Funcionario entidadeSalva = db.Funcionarios.FirstOrDefault(e => e.Codfuncionario == CodFuncionario);
            if(entidadeSalva != null)
            {
                db.Funcionarios.Remove(entidadeSalva);

                db.SaveChanges();
            }
        }
    }
}
