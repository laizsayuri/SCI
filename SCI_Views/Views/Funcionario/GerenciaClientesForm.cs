using SCI_Controllers.Controllers;
using SCI_Models.Models;
using System.Collections.Generic;

namespace SCI_Views.Views
{
	public partial class GerenciaClientesForm : FormBase
	{
		public List<Cliente> Clientes;
		public ClienteController clienteController;

		public GerenciaClientesForm()
		{
			clienteController = new ClienteController();
			InitializeComponent();
			PrepararDataGrid();
		}

		public void PrepararDataGrid()
		{
			List<Cliente> clientes = clienteController.GetAll();
			dataGridView1.Rows.Clear();

			foreach (var cliente in clientes)
				dataGridView1.Rows.Add(new object[] { cliente.Nome, cliente.Cpf, cliente.Datanascimento.ToString("dd/MM/yyyy"), cliente.Telefone, cliente.Email });

			dataGridView1.ClearSelection();
		}
	}
}
