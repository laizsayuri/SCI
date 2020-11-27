using System;
using System.Windows.Forms;

namespace SCI_Views.Views
{
	public partial class AdminMenuForm : FormBase
	{		
		public AdminMenuForm()
		{			
			InitializeComponent();
		}

		private void buttonFuncionarios_Click(object sender, EventArgs e)
		{
			Abrir(new GerenciaFuncionariosForm());
		}

		private void buttonClientes_Click(object sender, EventArgs e)
		{
			Abrir(new GerenciaClientesForm());
		}

		private void buttonEventos_Click(object sender, EventArgs e)
		{
			Abrir(new GerenciaEventosForm());
		}

		private void AdminMenuForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			ConfirmarSaida(sender, e);
		}
	}
}