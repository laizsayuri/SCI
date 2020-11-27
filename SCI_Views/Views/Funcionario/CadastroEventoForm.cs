using SCI_Controllers;
using SCI_Controllers.Controllers;
using SCI_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCI_Views.Views
{
	public partial class CadastroEventoForm : FormBase
	{
		private readonly EventoController eventoController;
		private readonly CategoriaController categoriaController;
		private readonly LocalController localController;
		private Evento evento;
		private List<Categoria> categorias;
		private List<Local> locais;

		public CadastroEventoForm(Evento evento)
		{
			this.evento = evento;
			eventoController = new EventoController();
			categoriaController = new CategoriaController();
			localController = new LocalController();
			InitializeComponent();
			PrepararFormulario();
		}

		public void PrepararFormulario()
		{
			if (evento.Codevento != 0)
			{
				buttonCadastroCategoria.Visible = false;
				buttonCadastroLocal.Visible = false;
			}

			LimpaCategorias();
			LimpaLocais();

			textBoxNome.Text = evento.Nome;
			textBoxArtista.Text = evento.Artista;
			dateTimePickerData.Value = (evento.Data == DateTime.MinValue ? DateTime.Now : evento.Data);
			textBoxDescricao.Text = evento.Descricao;
		}

		public bool VerificarCampos()
		{
			if (textBoxNome.VerificaSeEstaVazio())
				return false;

			if (textBoxArtista.VerificaSeEstaVazio())
				return false;

			if (textBoxDescricao.VerificaSeEstaVazio())
				return false;

			if (comboBoxLocal.SelectedIndex == -1)
				return false;

			if (comboBoxLocal.SelectedIndex == -1)
				return false;

			return true;
		}

		private void LimpaCategorias(bool setLast = false)
		{
			categorias = categoriaController.GetAll();
			comboBoxCategoria.Items.Clear();

			foreach (Categoria categoria in categorias)
				comboBoxCategoria.Items.Add($"{categoria.Codcategoria} - {categoria.Nome}");

			if (categorias.Any())
				comboBoxCategoria.SelectedIndex = 0;

			if (evento.Codcategoria != 0)
				comboBoxCategoria.SelectedIndex = comboBoxCategoria.FindStringExact($"{evento.Codcategoria} - {evento.CodcategoriaNavigation.Nome}");

			if (setLast)
				comboBoxCategoria.SelectedIndex = comboBoxCategoria.Items.Count - 1;
		}

		private void LimpaLocais(bool setLast = false)
		{
			locais = localController.GetAll();
			comboBoxLocal.Items.Clear();			

			foreach (Local local in locais)
				comboBoxLocal.Items.Add($"{local.Codlocal} - {local}");

			if (locais.Any())
				comboBoxLocal.SelectedIndex = 0;

			if (evento.Codlocal != 0)
				comboBoxLocal.SelectedIndex = comboBoxLocal.FindStringExact($"{evento.Codlocal} - {evento.CodlocalNavigation}");

			if (setLast)
				comboBoxLocal.SelectedIndex = comboBoxLocal.Items.Count - 1;
		}

		private void buttonCadastroCategoria_Click(object sender, EventArgs e)
		{
			if (AbrirEVerificarSucesso(new CadastroCategoriaForm()))
				LimpaCategorias(true);
		}

		private void buttonCadastroLocal_Click(object sender, EventArgs e)
		{
			if (AbrirEVerificarSucesso(new CadastroLocalForm()))
				LimpaLocais(true);
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

			evento.Nome = textBoxNome.Text;
			evento.Artista = textBoxArtista.Text;
			evento.Descricao = textBoxDescricao.Text;
			evento.Data = dateTimePickerData.Value;
			evento.Codcategoria = Convert.ToInt32(comboBoxCategoria.SelectedItem.ToString().Split("-").First().Trim());
			evento.Codlocal = Convert.ToInt32(comboBoxLocal.SelectedItem.ToString().Split("-").First().Trim());

			RetornoOperacao retorno;

			if (evento.Codevento == 0)
				retorno = eventoController.Save(evento);
			else
				retorno = eventoController.Edit(evento);

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
