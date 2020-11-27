using System.Windows.Forms;

namespace SCI_Views
{
	public class FormBase : Form
	{
		public bool Sucesso;

		public bool AbrirEVerificarSucesso(FormBase formFilho)
		{
			formFilho.ShowDialog();

			return formFilho.Sucesso;
		}

		public void AbrirEVerificarFecharForm(FormBase formFilho)
		{
			formFilho.ShowDialog();

			if (formFilho.Sucesso)
				Close();
		}

		public void MudarForm(FormBase formNovo)
		{
			Hide();
			formNovo.ShowDialog();
			Close();
		}

		public void Abrir(FormBase formFilho)
		{
			formFilho.Show();
		}

		public void ConfirmarSaida(object sender, FormClosingEventArgs e)
		{
			Form form = (Form)sender;

			if (form.ActiveControl.Text != "Editar Cliente")
				e.Cancel = !Helper.ShowConfirmacao("Deseja realmente finalizar a Aplicação?");
		}
	}
}