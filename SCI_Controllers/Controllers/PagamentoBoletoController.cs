using SCI_Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCI_Controllers.Controllers
{
	public class PagamentoBoletoController
	{
		private readonly sciContext db;

		public PagamentoBoletoController()
		{
			db = new sciContext();
		}

		public void Save(PagamentoBoleto pagamentoBoleto)
		{
			db.Pagamentoboletos.Add(pagamentoBoleto);

			db.SaveChanges();
		}

		public void Edit(PagamentoBoleto pagamentoBoleto)
		{
			PagamentoBoleto entidadeSalva = db.Pagamentoboletos.FirstOrDefault(e => e.Codpagamento == pagamentoBoleto.Codpagamento);
			if (entidadeSalva != null)
			{
				entidadeSalva.Codingresso = pagamentoBoleto.Codingresso;
				entidadeSalva.Valorapagar = pagamentoBoleto.Valorapagar;
				entidadeSalva.Numeroboleto = pagamentoBoleto.Numeroboleto;
				entidadeSalva.Datavencimento = pagamentoBoleto.Datavencimento;

				db.SaveChanges();
			}
		}

		public PagamentoBoleto GetById(int CodPagamento)
		{
			PagamentoBoleto entidade = db.Pagamentoboletos.FirstOrDefault(e => e.Codpagamento == CodPagamento);

			return entidade;
		}

		public List<PagamentoBoleto> GetAll()
		{
			return db.Pagamentoboletos.ToList();
		}

		public void Remove(int CodPagamento)
		{
			PagamentoBoleto entidadeSalva = db.Pagamentoboletos.FirstOrDefault(e => e.Codpagamento == CodPagamento);
			if (entidadeSalva != null)
			{
				db.Pagamentoboletos.Remove(entidadeSalva);

				db.SaveChanges();
			}
		}
	}
}