using SCI_Controllers.Controllers;
using SCI_Models.Models;
using System;
using System.Collections.Generic;

namespace SCI_Views.Views
{
	public partial class GerenciaEventosForm : FormBase
	{
		private readonly EventoController eventoController;

		public GerenciaEventosForm()
		{
			eventoController = new EventoController();
			InitializeComponent();
			PrepararDataGrid();
		}

		public void PrepararDataGrid()
		{
			List<Evento> eventos = eventoController.GetAll();
			dataGridView1.Rows.Clear();

			foreach (var evento in eventos)
				dataGridView1.Rows.Add(new object[] {
					evento.Codevento,
					evento.Nome,
					evento.CodcategoriaNavigation.Nome,
					evento.CodlocalNavigation.ToString(),
					evento.Artista,
					evento.Data.ToString("dd/MM/yyyy"),
					(evento.Liberado ? "Sim" : "Não"),
					(evento.Valoringresso == 0 ? "0.00 R$" : $"{evento.Valoringresso:#.##} R$"),
					evento.Numeroingressos,
					evento.Descricao
				});

			dataGridView1.ClearSelection();
		}

		private void buttonCadastrar_Click(object sender, EventArgs e)
		{
			if (AbrirEVerificarSucesso(new CadastroEventoForm(new Evento())))
				PrepararDataGrid();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
			{
				int codEvento = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
				Evento evento = eventoController.GetByCod(codEvento);

				if (AbrirEVerificarSucesso(new CadastroIngressosForm(evento)))
					PrepararDataGrid();
			}
			else
			{
				Helper.ShowErro("Selecione um evento para gerar ingressos!");
			}
		}

		private void buttonEditar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
			{
				int codEvento = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
				Evento evento = eventoController.GetByCod(codEvento);

				if (AbrirEVerificarSucesso(new CadastroEventoForm(evento)))
					PrepararDataGrid();
			}
			else
			{
				Helper.ShowErro("Selecione um evento para editar!");
			}
		}

		private void buttonRemover_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
			{
				if (Helper.ShowConfirmacao("Deseja realmente remover o evento?"))
				{
					int codEvento = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
					eventoController.Remove(codEvento);
					PrepararDataGrid();
					Helper.ShowSucesso("Evento removido!");
				}
			}
			else
			{
				Helper.ShowErro("Selecione um evento para remover!");
			}
		}
	}
}
