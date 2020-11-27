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

		public RetornoOperacao Save(Funcionario funcionario)
		{
			if (db.Clientes.Any(e => e.Email == funcionario.Email) || db.Funcionarios.Any(e => e.Email == funcionario.Email))
				return new RetornoOperacao(false, "O email já está sendo usado!");

			string senha = Helper.GerarSenha();
			funcionario.Senha = senha.ToMD5();
			db.Funcionarios.Add(funcionario);

			db.SaveChanges();
			return new RetornoOperacao(true, $"Funcionário criado com sucesso! Senha gerada: {senha}");
		}

		public RetornoOperacao Edit(Funcionario funcionario)
		{
			Funcionario entidadeSalva = db.Funcionarios.FirstOrDefault(e => e.Codfuncionario == funcionario.Codfuncionario);
			if (entidadeSalva != null)
			{
				entidadeSalva.Nome = funcionario.Nome;
				entidadeSalva.Email = funcionario.Email;
				entidadeSalva.Cpf = funcionario.Cpf;

				db.SaveChanges();
			}

			return new RetornoOperacao(true, "Funcionário editado com Sucesso!");
		}

		public Funcionario GetByCod(int CodFuncionario)
		{
			Funcionario entidade = db.Funcionarios.FirstOrDefault(e => e.Codfuncionario == CodFuncionario);

			return entidade;
		}

		public Funcionario GetByEmailSenha(string email, string senha)
		{
			Funcionario entidade = db.Funcionarios.FirstOrDefault(e => e.Email == email && e.Senha == senha.ToMD5());

			return entidade;
		}

		public List<Funcionario> GetAll()
		{
			return db.Funcionarios.Where(f => !f.Admin).ToList();
		}

		public void Remove(int CodFuncionario)
		{
			Funcionario entidadeSalva = db.Funcionarios.FirstOrDefault(e => e.Codfuncionario == CodFuncionario);
			if (entidadeSalva != null)
			{
				db.Funcionarios.Remove(entidadeSalva);

				db.SaveChanges();
			}
		}
	}
}