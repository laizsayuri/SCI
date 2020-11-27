using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SCI_Views
{
	public static class Helper
	{
		public static bool VerificaSeEstaVazio(this TextBox textBox) => string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text);

		public static void ShowSucesso(string menssagem) => MessageBox.Show(menssagem, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

		public static void ShowErro(string menssagem) => MessageBox.Show(menssagem, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

		public static bool ShowConfirmacao(string menssagem)
		{
			DialogResult result = MessageBox.Show(menssagem, "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			return DialogResult.Yes == result;
		}

		public static List<string> GetEstados()
		{
			List<string> estados = new List<string>();
			estados.Add("AC");
			estados.Add("AL");
			estados.Add("AP");
			estados.Add("AM");
			estados.Add("BA");
			estados.Add("CE");
			estados.Add("ES");
			estados.Add("GO");
			estados.Add("MA");
			estados.Add("MT");
			estados.Add("MS");
			estados.Add("MG");
			estados.Add("PA");
			estados.Add("PB");
			estados.Add("PR");
			estados.Add("PE");
			estados.Add("PI");
			estados.Add("RJ");
			estados.Add("RN");
			estados.Add("RS");
			estados.Add("RO");
			estados.Add("RR");
			estados.Add("SC");
			estados.Add("SP");
			estados.Add("SE");
			estados.Add("TO");
			estados.Add("DF");

			return estados;
		}
	}
}