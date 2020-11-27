using System;
using System.Collections.Generic;
using System.Text;

namespace SCI_Controllers
{
	public class RetornoOperacao
	{
		public bool Sucesso { get; set; }

		public string Menssagem { get; set; }

		public RetornoOperacao()
		{
			Sucesso = true;
		}

		public RetornoOperacao(bool success, string menssagem)
		{
			Sucesso = success;
			Menssagem = menssagem;
		}
	}
}