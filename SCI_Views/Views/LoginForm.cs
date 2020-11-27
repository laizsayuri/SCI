using SCI_Controllers.Controllers;
using SCI_Models.Models;
using System;

namespace SCI_Views.Views
{
	public partial class LoginForm : FormBase
	{
		private readonly FuncionarioController funcionarioController;
		private readonly ClienteController clienteController;

		public LoginForm()
		{
			funcionarioController = new FuncionarioController();
			clienteController = new ClienteController();
			InitializeComponent();
		}

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
			if (textBoxEmail.VerificaSeEstaVazio() || textBoxSenha.VerificaSeEstaVazio())
			{
				Helper.ShowErro("Preencha os campos para prosseguir!");
				return;
			}

			Funcionario funcionario = funcionarioController.GetByEmailSenha(textBoxEmail.Text, textBoxSenha.Text);

			if (funcionario != null && funcionario.Admin)
			{
				MudarForm(new AdminMenuForm());
				return;
			}
			else if (funcionario != null && !funcionario.Admin)
			{
				MudarForm(new FuncionarioMenuForm(funcionario));
				return;
			}

			Cliente cliente = clienteController.GetByEmailSenha(textBoxEmail.Text, textBoxSenha.Text);

			if (cliente != null)
			{
				MudarForm(new ClienteMenuForm(cliente));
				return;
			}

			Helper.ShowErro("Email ou senha inválidos!");
		}

        private void buttonCadastro_Click_1(object sender, EventArgs e)
        {
			Abrir(new CadastroClienteForm(new Cliente()));
		}
    }
}
