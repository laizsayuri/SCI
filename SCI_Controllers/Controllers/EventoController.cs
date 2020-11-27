using SCI_Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCI_Controllers.Controllers
{
	public class EventoController
	{
		private sciContext db;
		private readonly LocalController localController;
		private readonly CategoriaController categoriaController;
		private readonly IngressoController ingressoController;

		public EventoController()
		{
			localController = new LocalController();
			categoriaController = new CategoriaController();
			ingressoController = new IngressoController();
			db = new sciContext();
		}

		public RetornoOperacao Save(Evento evento)
		{
			if (db.Eventos.Any(e => e.Artista == evento.Artista) && db.Eventos.Any(e => e.Data == evento.Data))
				return new RetornoOperacao(false, "Já existe um evento do mesmo artista na mesma data!");

			db.Eventos.Add(evento);
			db.SaveChanges();

			return new RetornoOperacao(true, "Evento cadastrado com sucesso!");
		}

		public RetornoOperacao Edit(Evento evento)
		{
			Evento entidadeSalva = db.Eventos.FirstOrDefault(e => e.Codevento == evento.Codevento);
			if (entidadeSalva != null)
			{
				entidadeSalva.Codcategoria = evento.Codcategoria;
				entidadeSalva.Codlocal = evento.Codlocal;
				entidadeSalva.Nome = evento.Nome;
				entidadeSalva.Artista = evento.Artista;
				entidadeSalva.Data = evento.Data;
				entidadeSalva.Descricao = evento.Descricao;

				db.SaveChanges();
			}

			return new RetornoOperacao(true, "Evento editado com Sucesso!");
		}

		public void EditValoreQuantidadeIngressos(Evento evento)
		{
			Evento entidadeSalva = db.Eventos.FirstOrDefault(e => e.Codevento == evento.Codevento);
			if (entidadeSalva != null)
			{
				entidadeSalva.Valoringresso = evento.Valoringresso;
				entidadeSalva.Numeroingressos = evento.Numeroingressos;

				db.SaveChanges();
			}
		}

		public void EditLiberarIngressos(int CodEvento)
		{
			Evento entidadeSalva = db.Eventos.FirstOrDefault(e => e.Codevento == CodEvento);
			if (entidadeSalva != null)
			{
				entidadeSalva.Liberado = true;

				db.SaveChanges();
			}
		}

		public Evento GetByCod(int CodEvento)
		{
			Evento entidade = db.Eventos.FirstOrDefault(e => e.Codevento == CodEvento);

			return entidade;
		}

		public List<Evento> GetAll()
		{
			db = new sciContext();
			List<Evento> eventos = db.Eventos.ToList();
			List<Local> locais = localController.GetAll();
			List<Categoria> categorias = categoriaController.GetAll();

			foreach (Evento evento in eventos)
			{
				evento.CodcategoriaNavigation = categorias.First(c => c.Codcategoria == evento.Codcategoria);
				evento.CodlocalNavigation = locais.First(c => c.Codlocal == evento.Codlocal);
			}

			return eventos;
		}

		public void Remove(int CodEvento)
		{
			Evento entidadeSalva = db.Eventos.FirstOrDefault(e => e.Codevento == CodEvento);
			if (entidadeSalva != null)
			{
				ingressoController.RemoveByCodEvento(CodEvento);
				db.Eventos.Remove(entidadeSalva);

				db.SaveChanges();
			}
		}

		public bool VerificarIngressoDisponivel(Evento evento)
		{
			int ingressosTotais = evento.Numeroingressos;
			int ingressosPagos = db.Ingressos.Count(i => i.Codevento == evento.Codevento);

			return (ingressosTotais - ingressosPagos) > 0;
		}
	}
}