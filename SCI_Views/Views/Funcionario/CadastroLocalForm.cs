using SCI_Controllers;
using SCI_Controllers.Controllers;
using SCI_Models.Models;
using System;
using System.Collections.Generic;

namespace SCI_Views.Views
{
	public partial class CadastroLocalForm : FormBase
	{
		private readonly LocalController localController;

		public CadastroLocalForm()
		{
			localController = new LocalController();
			InitializeComponent();
			PrepararFormulario();
		}

		public void PrepararFormulario()
		{
			List<string> estados = Helper.GetEstados();
			foreach (string estado in estados)
				comboBoxEstado.Items.Add(estado);

			comboBoxEstado.SelectedIndex = 0;
		}

		public bool VerificarCampos()
		{
			if (textBoxCidade.VerificaSeEstaVazio())
				return false;

			if (textBoxEndereco.VerificaSeEstaVazio())
				return false;

			if (comboBoxEstado.SelectedIndex == -1)
				return false;

			return true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonSalvar_Click(object sender, EventArgs e)
		{
			if (!VerificarCampos())
			{
				Helper.ShowErro("Preencha todos os campos!");
				return;
			}

			Local local = new Local();
			local.Cidade = textBoxCidade.Text;
			local.Endereco = textBoxEndereco.Text;
			local.Estado = comboBoxEstado.SelectedItem.ToString();

			RetornoOperacao retorno = localController.Save(local);

			if (retorno.Sucesso)
			{
				Helper.ShowSucesso("Novo local cadastrado!");
				Sucesso = true;
				Close();
			}
			else
				Helper.ShowErro(retorno.Menssagem);
		}
	}
}
