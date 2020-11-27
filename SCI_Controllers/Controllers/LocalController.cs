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

		public RetornoOperacao Save(Local local)
		{
			if (db.Locals.Any(l => l.Cidade == local.Cidade && l.Estado == local.Estado && l.Endereco == local.Endereco))
				return new RetornoOperacao(false, "Esse local já se encontra cadastro no banco de dados!");

			db.Locals.Add(local);

			db.SaveChanges();
			return new RetornoOperacao();
		}

		public List<Local> GetAll()
		{
			return db.Locals.ToList();
		}
	}
}