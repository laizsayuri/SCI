using SCI_Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SCI_Views.Views
{
	public partial class FuncionarioMenuForm : FormBase
	{
		public Funcionario funcionario;

		public FuncionarioMenuForm(Funcionario funcionario)
		{
			this.funcionario = funcionario;
			InitializeComponent();
			labelHello.Text = labelHello.Text.Replace("Funcionário", funcionario.Nome);
		}

		private void buttonClientes_Click(object sender, EventArgs e)
		{
			Abrir(new GerenciaClientesForm());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Abrir(new GerenciaEventosForm());
		}

		private void FuncionarioMenuForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			ConfirmarSaida(sender, e);
		}
	}
}