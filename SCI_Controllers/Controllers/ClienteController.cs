using SCI_Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCI_Controllers.Controllers
{
	public class ClienteController
	{
		private readonly sciContext db;
		private readonly IngressoController ingressoController;

		public ClienteController()
		{
			ingressoController = new IngressoController();
			db = new sciContext();
		}

		public RetornoOperacao Save(Cliente cliente)
		{
			if (db.Clientes.Any(e => e.Email == cliente.Email) || db.Funcionarios.Any(e => e.Email == cliente.Email))
				return new RetornoOperacao(false, "O email já está sendo usado!");

			cliente.Senha = cliente.Senha.ToMD5();
			db.Clientes.Add(cliente);

			db.SaveChanges();
			return new RetornoOperacao(true, "Cliente criado com sucesso!");
		}

		public RetornoOperacao Edit(Cliente cliente)
		{
			Cliente entidadeSalva = db.Clientes.FirstOrDefault(e => e.Codcliente == cliente.Codcliente);
			if (entidadeSalva != null)
			{
				entidadeSalva.Nome = cliente.Nome;
				entidadeSalva.Cpf = cliente.Cpf;
				entidadeSalva.Datanascimento = cliente.Datanascimento;
				entidadeSalva.Telefone = cliente.Telefone;
				entidadeSalva.Email = cliente.Email;

				db.SaveChanges();
			}

			return new RetornoOperacao(true, "Cliente editado com Sucesso!");
		}

		public void EditSenha(Cliente cliente)
		{
			Cliente entidadeSalva = db.Clientes.FirstOrDefault(e => e.Codcliente == cliente.Codcliente);
			if (entidadeSalva != null)
			{
				entidadeSalva.Senha = cliente.Senha.ToMD5();

				db.SaveChanges();
			}
		}

		public Cliente GetByEmailSenha(string email, string senha)
		{
			Cliente entidade = db.Clientes.FirstOrDefault(e => e.Email == email && e.Senha == senha.ToMD5());

			return entidade;
		}

		public List<Cliente> GetAll()
		{
			return db.Clientes.ToList();
		}

		public void Remove(int CodCliente)
		{
			Cliente entidadeSalva = db.Clientes.FirstOrDefault(e => e.Codcliente == CodCliente);
			if (entidadeSalva != null)
			{
				ingressoController.RemoveByCodCliente(CodCliente);
				db.Clientes.Remove(entidadeSalva);

				db.SaveChanges();
			}
		}
	}
}