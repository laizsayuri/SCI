using SCI_Controllers.Controllers;
using SCI_Models.Models;
using System;

namespace SCI_Views.Views
{
	public partial class CompraIngressoForm : FormBase
	{
		private Evento evento;
		private Cliente cliente;
		private readonly IngressoController ingressoController;

		public CompraIngressoForm(Cliente cliente, Evento evento)
		{
			this.evento = evento;
			this.cliente = cliente;
			ingressoController = new IngressoController();
			InitializeComponent();
			PrepararFormulario();
		}

		public void PrepararFormulario()
		{
			textBoxEvento.Text = evento.Nome;
			textBoxNomeUsuario.Text = cliente.Nome;
			comboBoxTipoIngresso.Items.Add("Inteiro");
			comboBoxTipoIngresso.Items.Add("Meia-Entrada");
			comboBoxTipoIngresso.SelectedIndex = 0;
		}

		public bool VerificarCamposCartao()
		{
			if (textBoxCodSegurancaCartao.VerificaSeEstaVazio())
				return false;

			if (textBoxNomeCartao.VerificaSeEstaVazio())
				return false;

			if (textBoxNumeroCartao.VerificaSeEstaVazio())
				return false;

			if (textBoxValidadeCartao.VerificaSeEstaVazio())
				return false;

			return true;
		}

		private void buttonCartão_Click(object sender, EventArgs e)
		{
			if (!VerificarCamposCartao())
			{
				Helper.ShowErro("Preencha os campos sobre o cartão para prosseguir!");
				return;
			}

			Ingresso ingresso = GerarIngresso();

			PagamentoCartao pagamentoCartao = new PagamentoCartao();
			pagamentoCartao.Valorapagar = ingresso.Valorinteiro ? evento.Valoringresso : evento.Valoringresso / 2;
			pagamentoCartao.Nometitular = textBoxNomeCartao.Text;
			pagamentoCartao.Numerocartao = textBoxNumeroCartao.Text;
			pagamentoCartao.Codseguranca = textBoxCodSegurancaCartao.Text;
			pagamentoCartao.Datavalidade = textBoxValidadeCartao.Text;			

			ingresso.Pagamentocartaos.Add(pagamentoCartao);

			ingressoController.Save(ingresso);
			Helper.ShowSucesso("Compra efetuada com Sucesso!");
			Close();
		}

		public Ingresso GerarIngresso()
		{
			Ingresso ingresso = new Ingresso();
			ingresso.Codcliente = cliente.Codcliente;
			ingresso.Codevento = evento.Codevento;
			ingresso.Valorinteiro = comboBoxTipoIngresso.SelectedIndex == 0;
			
			return ingresso;
		}

		private void buttonBoleto_Click(object sender, EventArgs e)
		{
			Ingresso ingresso = GerarIngresso();

			PagamentoBoleto pagamentoBoleto = new PagamentoBoleto();
			pagamentoBoleto.Valorapagar = ingresso.Valorinteiro ? evento.Valoringresso : evento.Valoringresso / 2;

			ingresso.Pagamentoboletos.Add(pagamentoBoleto);

			ingressoController.Save(ingresso);
			Helper.ShowSucesso($"Boleto enviado para {cliente.Email}!");
			Close();
		}
	}
}