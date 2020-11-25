using SCI_Models.Models;
using System.Collections.Generic;
using System.Linq;


namespace SCI_Controllers.Controllers
{
    public class PagamentoCartaoController
    {
		private readonly sciContext db;

		public PagamentoCartaoController()
		{
			db = new sciContext();
		}

		public void Save(PagamentoCartao pagamentoCartao)
		{
			db.Pagamentocartaos.Add(pagamentoCartao);

			db.SaveChanges();
		}

		public void Edit(PagamentoCartao pagamentoCartao)
        {
			PagamentoCartao entidadeSalva = db.Pagamentocartaos.FirstOrDefault(e => e.Codpagamento == pagamentoCartao.Codpagamento);
			if (entidadeSalva != null)
			{
				entidadeSalva.Codingresso = pagamentoCartao.Codingresso;
				entidadeSalva.Valorapagar = pagamentoCartao.Valorapagar;
				entidadeSalva.Nometitular = pagamentoCartao.Nometitular;
				entidadeSalva.Numerocartao = pagamentoCartao.Numerocartao;
				entidadeSalva.Datavalidade = pagamentoCartao.Datavalidade;
				entidadeSalva.Codseguranca = pagamentoCartao.Codseguranca;
				entidadeSalva.Transacaoaprovada = pagamentoCartao.Transacaoaprovada;

				db.SaveChanges();
			}
		}

		public PagamentoCartao GetById(int CodPagamento)
		{
			PagamentoCartao entidade = db.Pagamentocartaos.FirstOrDefault(e => e.Codpagamento == CodPagamento);

			return entidade;
		}

		public List<PagamentoCartao> GetAll()
		{
			return db.Pagamentocartaos.ToList();
		}

		public void Remove(int CodPagamento)
		{
			PagamentoCartao entidadeSalva = db.Pagamentocartaos.FirstOrDefault(e => e.Codpagamento == CodPagamento);
			if (entidadeSalva != null)
			{
				db.Pagamentocartaos.Remove(entidadeSalva);

				db.SaveChanges();
			}
		}
	}
}
			