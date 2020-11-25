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
60  SCI_Controllers / Controllers / PagamentoBoletoController.cs
@@ -0,0 + 1,60 @@
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
