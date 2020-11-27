using SCI_Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCI_Controllers.Controllers
{
	public class CategoriaController
	{
		private readonly sciContext db;

		public CategoriaController()
		{
			db = new sciContext();
		}

		public RetornoOperacao Save(Categoria categoria)
		{
			if (db.Categorias.Any(c => c.Nome == categoria.Nome))
				return new RetornoOperacao(false, "Essa categoria já se encontra salva no banco de dados!");

			db.Categorias.Add(categoria);

			db.SaveChanges();
			return new RetornoOperacao();
		}

		public List<Categoria> GetAll()
		{
			return db.Categorias.ToList();
		}
	}
}