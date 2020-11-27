using SCI_Controllers;
using SCI_Controllers.Controllers;
using SCI_Models.Models;
using System;

namespace SCI_Views.Views
{
	public partial class CadastroIngressosForm : FormBase
	{
		public Evento evento;
		private readonly EventoController eventoController;

		public CadastroIngressosForm(Evento evento)
		{
			this.evento = evento;
			eventoController = new EventoController();
			InitializeComponent();
			PrepararFormulario();
		}

		public void PrepararFormulario()
		{			
			if (evento.Liberado)
			{
				buttonOk.Visible = true;
				buttonCancelar.Visible = false;
				buttonSalvar.Visible = false;
				buttonLiberarVenda.Visible = false;
				textBoxQuantidade.Enabled = false;
				textBoxValor.Enabled = false;
			} else if (evento.Numeroingressos == 0 || evento.Valoringresso == 0)
				buttonLiberarVenda.Visible = false;

			textBoxQuantidade.Text = evento.Numeroingressos == 0 ? null : evento.Numeroingressos.ToString();
			textBoxValor.Text = evento.Valoringresso == 0 ? null : evento.Valoringresso.ToString();
		}

		public bool VerificarCampos()
		{
			if (textBoxQuantidade.VerificaSeEstaVazio() || textBoxValor.VerificaSeEstaVazio())
				return false;

			try
			{
				int quantidade = Convert.ToInt32(textBoxQuantidade.Text);
				decimal valor = Convert.ToDecimal(textBoxValor.Text);

				if (quantidade <= 0 || valor <= 0)
					return false;
			}
			catch
			{
				return false;
			}

			return true;
		}

		private void buttonLiberarBenda_Click(object sender, EventArgs e)
		{
			bool liberar = Helper.ShowConfirmacao("Deseja liberar a venda dos ingressos?");
			if (liberar)
			{
				eventoController.EditLiberarIngressos(evento.Codevento);
				Helper.ShowSucesso("Ingressos liberados para venda!");
				Sucesso = true;
				Close();
			}
		}

		private void buttonCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonSalvar_Click(object sender, EventArgs e)
		{
			if (!VerificarCampos())
			{
				Helper.ShowErro("Preencha os campos corretamente para prosseguir!");
				return;
			}

			evento.Numeroingressos = Convert.ToInt32(textBoxQuantidade.Text);
			evento.Valoringresso = Convert.ToDecimal(textBoxValor.Text);

			eventoController.EditValoreQuantidadeIngressos(evento);

			bool liberar = Helper.ShowConfirmacao("Deseja já liberar a venda dos ingressos?");
			if (liberar)
				eventoController.EditLiberarIngressos(evento.Codevento);

			Helper.ShowSucesso("Ingressos definidos com sucesso!");
			Sucesso = true;
			Close();			
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
