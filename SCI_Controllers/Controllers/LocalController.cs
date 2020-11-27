using SCI_Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCI_Controllers.Controllers
{
	public class LocalController
	{
		private readonly sciContext db;

		public LocalController()
		{
			db = new sciContext();
		}

		public void Save(Local local)
		{
			db.Locals.Add(local);

			db.SaveChanges();
		}

		public void Edit(Local local)
		{
			Local entidadeSalva = db.Locals.FirstOrDefault(e => e.Codlocal == local.Codlocal);
			if (entidadeSalva != null)
			{
				entidadeSalva.Endereco = local.Endereco;
				entidadeSalva.Cidade = local.Cidade;
				entidadeSalva.Estado = local.Estado;

				db.SaveChanges();
			}
		}

		public Local GetById(int CodLocal)
		{
			Local entidade = db.Locals.FirstOrDefault(e => e.Codlocal == CodLocal);

			return entidade;
		}

		public List<Local> GetAll()
		{
			return db.Locals.ToList();
		}

		public void Remove(int CodLocal)
		{
			Local entidadeSalva = db.Locals.FirstOrDefault(e => e.Codlocal == CodLocal);
			if (entidadeSalva != null)
			{
				db.Locals.Remove(entidadeSalva);

				db.SaveChanges();
			}
		}
	}
}