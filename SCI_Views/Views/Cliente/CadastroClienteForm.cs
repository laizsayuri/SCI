using SCI_Controllers;
using SCI_Controllers.Controllers;
using SCI_Models.Models;
using System;

namespace SCI_Views.Views
{
	public partial class CadastroClienteForm : FormBase
	{
		private readonly ClienteController clienteController;
		private Cliente cliente;

		public CadastroClienteForm(Cliente cliente)
		{
			clienteController = new ClienteController();
			this.cliente = cliente;
			InitializeComponent();
			PrepararFormulario();
		}

		public void PrepararFormulario()
		{
			if (cliente.Codcliente != 0)
			{
				buttonAlterarSenha.Visible = true;
				buttonExcluir.Visible = true;
				textBoxSenha.Visible = false;
				labelSenha.Visible = false;
			}

			textBoxNome.Text = cliente.Nome;
			textBoxCpf.Text = cliente.Cpf;
			textBoxEmail.Text = cliente.Email;
			dateTimePickerData.Value = (cliente.Datanascimento == DateTime.MinValue ? DateTime.Now : cliente.Datanascimento);
			textBoxTelefone.Text = cliente.Telefone;
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

			cliente.Nome = textBoxNome.Text;
			cliente.Cpf = textBoxCpf.Text;
			cliente.Datanascimento = dateTimePickerData.Value;
			cliente.Telefone = textBoxTelefone.Text;
			cliente.Email = textBoxEmail.Text;
			cliente.Senha = textBoxSenha.Text;

			RetornoOperacao retorno;

			if (cliente.Codcliente == 0)			
				retorno = clienteController.Save(cliente);			
			else
				retorno = clienteController.Edit(cliente);

			if (retorno.Sucesso)
			{
				Helper.ShowSucesso(retorno.Menssagem);
				Close();
			}
			else
				Helper.ShowErro(retorno.Menssagem);
		}

		public bool VerificarCampos()
		{
			if (textBoxNome.VerificaSeEstaVazio())
				return false;

			if (textBoxCpf.VerificaSeEstaVazio())				
				return false;

			if (textBoxTelefone.VerificaSeEstaVazio())				
				return false;

			if (cliente.Codcliente == 0 && textBoxSenha.VerificaSeEstaVazio())
				return false;

			return true;
		}

		private void buttonAlterarSenha_Click(object sender, EventArgs e)
		{
			AbrirEVerificarFecharForm(new CadastroNovaSenhaForm(cliente));
		}

		private void buttonExcluir_Click(object sender, EventArgs e)
		{
			if(Helper.ShowConfirmacao("Deseja realmente excluir seu cadastro?"))
			{
				clienteController.Remove(cliente.Codcliente);
				Helper.ShowSucesso("Cadastro removido. Até mais!");
				Sucesso = true;
				Close();				
			}
		}
	}
}
