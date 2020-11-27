using SCI_Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCI_Controllers.Controllers
{
	public class ClienteController
	{
		private readonly sciContext db;

		public ClienteController()
		{
			db = new sciContext();
		}

		public void Save(Cliente cliente)
		{
			cliente.Senha = cliente.Senha.ToMD5();

			db.Clientes.Add(cliente);

			db.SaveChanges();
		}

		public void Edit(Cliente cliente)
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

		public Cliente GetById(int CodCliente)
		{
			Cliente entidade = db.Clientes.FirstOrDefault(e => e.Codcliente == CodCliente);

			return entidade;
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
				db.Clientes.Remove(entidadeSalva);

				db.SaveChanges();
			}
		}
	}
}