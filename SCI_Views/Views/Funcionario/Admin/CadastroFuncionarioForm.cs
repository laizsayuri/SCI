using SCI_Controllers;
using SCI_Controllers.Controllers;
using SCI_Models.Models;
using System;

namespace SCI_Views.Views
{
	public partial class CadastroFuncionarioForm : FormBase
	{
		private Funcionario funcionario;
		private readonly FuncionarioController funcionarioController;

		public CadastroFuncionarioForm(Funcionario funcionario)
		{
			funcionarioController = new FuncionarioController();
			this.funcionario = funcionario;
			InitializeComponent();
			PrepararFormulario();
		}

		public void PrepararFormulario()
		{
			textBoxNome.Text = funcionario.Nome;
			textBoxEmail.Text = funcionario.Email;
			textBoxCpf.Text = funcionario.Cpf;
		}

		public bool VerificarCampos()
		{
			if (textBoxNome.VerificaSeEstaVazio())
				return false;

			if (textBoxEmail.VerificaSeEstaVazio())
				return false;

			if (textBoxCpf.VerificaSeEstaVazio())
				return false;

			return true;
		}

		private void buttonCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonSalvar_Click(object sender, EventArgs e)
		{
			if (!VerificarCampos())
			{
				Helper.ShowErro("Preencha os campos para prosseguir!");
				return;
			}

			funcionario.Nome = textBoxNome.Text;
			funcionario.Cpf = textBoxCpf.Text;			
			funcionario.Email = textBoxEmail.Text;

			RetornoOperacao retorno;

			if (funcionario.Codfuncionario == 0)
				retorno = funcionarioController.Save(funcionario);
			else
				retorno = funcionarioController.Edit(funcionario);

			if (retorno.Sucesso)
			{
				Helper.ShowSucesso(retorno.Menssagem);
				Sucesso = true;
				Close();
			}
			else
				Helper.ShowErro(retorno.Menssagem);
		}
	}
}