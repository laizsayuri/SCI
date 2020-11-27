using SCI_Models.Models;
using System;
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
			if (ingresso.Pagamentoboletos.Any())
			{
				ingresso.Pagamentoboletos.First().Numeroboleto = Helper.GerarNumeroBoleto();
				ingresso.Pagamentoboletos.First().Datavencimento = DateTime.Now.AddDays(7);
			}

			if (ingresso.Pagamentocartaos.Any())
			{
				ingresso.Pagamentocartaos.First().Transacaoaprovada = true;
				ingresso.Pagamentocartaos.First().Nometitular = ingresso.Pagamentocartaos.First().Nometitular.ToMD5();
				ingresso.Pagamentocartaos.First().Numerocartao = ingresso.Pagamentocartaos.First().Numerocartao.ToMD5();
				ingresso.Pagamentocartaos.First().Datavalidade = ingresso.Pagamentocartaos.First().Datavalidade.ToMD5();
				ingresso.Pagamentocartaos.First().Codseguranca = ingresso.Pagamentocartaos.First().Codseguranca.ToMD5();
			}

			db.Ingressos.Add(ingresso);

			db.SaveChanges();
		}

		public void RemoveByCodCliente(int CodCliente)
		{
			List<Ingresso> ingressos = db.Ingressos.Where(i => i.Codcliente == CodCliente).ToList();

			RemovePagamentos(ingressos);
			db.Ingressos.RemoveRange(ingressos);

			db.SaveChanges();
		}

		public void RemoveByCodEvento(int CodEvento)
		{
			List<Ingresso> ingressos = db.Ingressos.Where(i => i.Codevento == CodEvento).ToList();

			RemovePagamentos(ingressos);
			db.Ingressos.RemoveRange(ingressos);

			db.SaveChanges();
		}

		public void RemovePagamentos(List<Ingresso> ingressos)
		{
			List<PagamentoBoleto> pagamentoBoletos = new List<PagamentoBoleto>();
			List<PagamentoCartao> pagamentoCartaos = new List<PagamentoCartao>();

			foreach (Ingresso ingresso in ingressos)
			{
				pagamentoBoletos.AddRange(db.Pagamentoboletos.Where(p => p.Codingresso == ingresso.Codingresso).ToList());
				pagamentoCartaos.AddRange(db.Pagamentocartaos.Where(p => p.Codingresso == ingresso.Codingresso).ToList());
			}

			db.Pagamentoboletos.RemoveRange(pagamentoBoletos);
			db.Pagamentocartaos.RemoveRange(pagamentoCartaos);
			db.SaveChanges();
		}
	}
}