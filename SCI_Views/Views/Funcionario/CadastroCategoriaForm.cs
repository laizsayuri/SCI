using SCI_Controllers;
using SCI_Controllers.Controllers;
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
	public partial class CadastroCategoriaForm : FormBase
	{
		private readonly CategoriaController categoriaController;

		public CadastroCategoriaForm()
		{
			categoriaController = new CategoriaController();
			InitializeComponent();
		}

		private void buttonCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonSalvar_Click(object sender, EventArgs e)
		{
			if (textBoxNome.VerificaSeEstaVazio())
			{
				Helper.ShowErro("Preencha todos os campos!");
				return;
			}

			Categoria categoria = new Categoria();			
			categoria.Nome = textBoxNome.Text;

			RetornoOperacao retorno = categoriaController.Save(categoria);

			if (retorno.Sucesso)
			{
				Helper.ShowSucesso("Nova categoria cadastrada!");
				Sucesso = true;
				Close();
			}
			else
				Helper.ShowErro(retorno.Menssagem);
		}
	}
}