using SCI_Controllers.Controllers;
using SCI_Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SCI_Views.Views
{
	public partial class ClienteMenuForm : FormBase
	{
		private readonly EventoController eventoController;
		private readonly LocalController localController;
		private readonly CategoriaController categoriaController;
		private Cliente cliente;
		private List<Local> locais;
		private List<Categoria> categorias;
		private List<Evento> eventos;

		public ClienteMenuForm(Cliente cliente)
		{
			localController = new LocalController();
			categoriaController = new CategoriaController();
			eventoController = new EventoController();
			this.cliente = cliente;
			locais = new List<Local>();
			categorias = new List<Categoria>();
			categorias = new List<Categoria>();
			InitializeComponent();
			PrepararFiltros();
			PrepararDataGrid();
		}

		public void PrepararFiltros()
		{
			locais = localController.GetAll();
			categorias = categoriaController.GetAll();
			eventos = eventoController.GetAll().Where(e => e.Liberado).ToList();

			comboBoxLocal.Items.Clear();
			comboBoxCategoria.Items.Clear();

			comboBoxLocal.Items.Add("Selecione um local...");
			comboBoxLocal.SelectedIndex = 0;
			comboBoxCategoria.Items.Add("Selecione uma categoria...");
			comboBoxCategoria.SelectedIndex = 0;

			foreach (var local in locais)
				comboBoxLocal.Items.Add(local.ToString());

			foreach (var categoria in categorias)
				comboBoxCategoria.Items.Add(categoria.Nome);
		}

		public void PrepararDataGrid()
		{
			List<Evento> eventosFiltrados = new List<Evento>(eventos);
			dataGridView1.Rows.Clear();

			if (comboBoxCategoria.SelectedIndex != 0)
				eventosFiltrados = eventos.Where(e => e.CodcategoriaNavigation.Nome == comboBoxCategoria.SelectedItem.ToString()).ToList();

			if (comboBoxLocal.SelectedIndex != 0)
				eventosFiltrados = eventos.Where(e => e.CodlocalNavigation.ToString() == comboBoxLocal.SelectedItem.ToString()).ToList();

			foreach (var evento in eventosFiltrados)
			{
				dataGridView1.Rows.Add(new object[] {
					evento.Codevento,
					evento.Nome,
					evento.Artista,
					evento.Data.ToString("dd/MM/yyyy"),
					evento.CodlocalNavigation.ToString(),
					evento.CodcategoriaNavigation.Nome,
					$"{evento.Valoringresso:#.##} R$"
				});
			}

			dataGridView1.ClearSelection();
		}

		private void buttonEditar_Click(object sender, EventArgs e)
		{
			if (AbrirEVerificarSucesso(new CadastroClienteForm(cliente)))
			{
				MudarForm(new LoginForm());
			}
		}

		private void buttonRemover_Click(object sender, EventArgs e)
		{

			if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
			{
				int codEvento = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
				Evento evento = eventos.First(e => e.Codevento == codEvento);

				if (!eventoController.VerificarIngressoDisponivel(evento))
				{
					Helper.ShowErro("Não há mais ingresso disponível para esse evento!");
					return;
				}

				Abrir(new CompraIngressoForm(cliente, evento));
			}
			else
			{
				Helper.ShowErro("Selecione um evento para comprar o Ingresso!");
			}
		}

		private void comboBoxCategoria_SelectionChangeCommitted(object sender, EventArgs e)
		{
			PrepararDataGrid();
		}

		private void comboBoxLocal_SelectionChangeCommitted(object sender, EventArgs e)
		{
			PrepararDataGrid();
		}

		private void ClienteMenuForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			ConfirmarSaida(sender, e);
		}
	}
}