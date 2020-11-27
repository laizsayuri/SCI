using SCI_Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCI_Controllers.Controllers
{
	public class IngressoController
	{
		private readonly sciContext db;

		public IngressoController()
		{
			db = new sciContext();
		}

		public void Save(Ingresso ingresso)
		{
			db.Ingressos.Add(ingresso);

			db.SaveChanges();
		}

		public void Edit(Ingresso ingresso)
		{
			Ingresso entidadeSalva = db.Ingressos.FirstOrDefault(e => e.Codingresso == ingresso.Codingresso);
			if (entidadeSalva != null)
			{
				entidadeSalva.Codevento = ingresso.Codevento;
				entidadeSalva.Codcliente = ingresso.Codcliente;
				entidadeSalva.Valorinteiro = ingresso.Valorinteiro;

				db.SaveChanges();
			}
		}

		public Ingresso GetById(int CodIngresso)
		{
			Ingresso entidade = db.Ingressos.FirstOrDefault(e => e.Codingresso == CodIngresso);

			return entidade;
		}

		public List<Ingresso> GetAll()
		{
			return db.Ingressos.ToList();
		}

		public void Remove(int CodIngresso)
		{
			Ingresso entidadeSalva = db.Ingressos.FirstOrDefault(e => e.Codingresso == CodIngresso);
			if (entidadeSalva != null)
			{
				db.Ingressos.Remove(entidadeSalva);

				db.SaveChanges();
			}
		}
	}
}