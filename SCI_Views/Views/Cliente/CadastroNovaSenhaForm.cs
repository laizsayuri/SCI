using SCI_Controllers.Controllers;
using SCI_Models.Models;
using System;

namespace SCI_Views.Views
{
	public partial class CadastroNovaSenhaForm : FormBase
	{		
		private Cliente cliente;		
		private readonly ClienteController clienteController;

		public CadastroNovaSenhaForm(Cliente cliente)
		{
			this.cliente = cliente;
			clienteController = new ClienteController();
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(textBoxNovaSenha.VerificaSeEstaVazio())
			{
				Helper.ShowErro("Insira a nova senha!");
				return;
			}

			cliente.Senha = textBoxNovaSenha.Text;
			clienteController.EditSenha(cliente);

			Helper.ShowSucesso("Senha alterada com Sucesso!");
			Sucesso = true;
			Close();
		}
	}
}