using SCI_Controllers.Controllers;
using SCI_Models.Models;
using System;
using System.Collections.Generic;

namespace SCI_Views.Views
{
	public partial class GerenciaFuncionariosForm : FormBase
	{
		private FuncionarioController funcionarioController;

		public GerenciaFuncionariosForm()
		{
			funcionarioController = new FuncionarioController();
			InitializeComponent();
			PrepararDataGrid();
		}

		public void PrepararDataGrid()
		{
			List<Funcionario> funcionarios = funcionarioController.GetAll();
			dataGridView1.Rows.Clear();

			foreach (var funcionario in funcionarios)
				dataGridView1.Rows.Add(new object[] { funcionario.Codfuncionario, funcionario.Nome, funcionario.Email, funcionario.Cpf });

			dataGridView1.ClearSelection();
		}

		private void buttonCadastrar_Click(object sender, System.EventArgs e)
		{
			if (AbrirEVerificarSucesso(new CadastroFuncionarioForm(new Funcionario())))
				PrepararDataGrid();
		}

		private void buttonEditar_Click(object sender, System.EventArgs e)
		{

			if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
			{
				int codFuncionario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
				Funcionario funcionario = funcionarioController.GetByCod(codFuncionario);

				if (AbrirEVerificarSucesso(new CadastroFuncionarioForm(funcionario)))
					PrepararDataGrid();
			}
			else
			{
				Helper.ShowErro("Selecione um funcionário para editar!");
			}
		}

		private void buttonRemover_Click(object sender, System.EventArgs e)
		{
			if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
			{
				if (Helper.ShowConfirmacao("Deseja realmente remover o funcionário?"))
				{
					int codFuncionario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
					funcionarioController.Remove(codFuncionario);
					PrepararDataGrid();
					Helper.ShowSucesso("Funcionário removido!");
				}
			}
			else
			{
				Helper.ShowErro("Selecione um funcionário para remover!");
			}
		}
	}
}