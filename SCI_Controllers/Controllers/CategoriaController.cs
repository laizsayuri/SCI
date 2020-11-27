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

		public void Save(Categoria categoria)
		{
			db.Categorias.Add(categoria);

			db.SaveChanges();
		}

		public void Edit(Categoria categoria)
		{
			Categoria entidadeSalva = db.Categorias.FirstOrDefault(e => e.Codcategoria == categoria.Codcategoria);
			if (entidadeSalva != null)
			{
				entidadeSalva.Nome = categoria.Nome;

				db.SaveChanges();
			}
		}

		public Categoria GetById(int CodCategoria)
		{
			Categoria entidade = db.Categorias.FirstOrDefault(e => e.Codcategoria == CodCategoria);

			return entidade;
		}

		public List<Categoria> GetAll()
		{
			return db.Categorias.ToList();
		}

		public void Remove(int CodCategoria)
		{
			Categoria entidadeSalva = db.Categorias.FirstOrDefault(e => e.Codcategoria == CodCategoria);
			if (entidadeSalva != null)
			{
				db.Categorias.Remove(entidadeSalva);

				db.SaveChanges();
			}
		}
	}
}