namespace SCI_Views.Views
{
	partial class CadastroFuncionarioForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonSalvar = new System.Windows.Forms.Button();
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxNome = new System.Windows.Forms.TextBox();
			this.textBoxArtista = new System.Windows.Forms.TextBox();
			this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonSalvar
			// 
			this.buttonSalvar.Location = new System.Drawing.Point(396, 205);
			this.buttonSalvar.Name = "buttonSalvar";
			this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
			this.buttonSalvar.TabIndex = 2;
			this.buttonSalvar.Text = "Salvar";
			this.buttonSalvar.UseVisualStyleBackColor = true;
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.Location = new System.Drawing.Point(315, 205);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
			this.buttonCancelar.TabIndex = 3;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "CPF";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "E-mail";
			// 
			// textBoxNome
			// 
			this.textBoxNome.Location = new System.Drawing.Point(136, 51);
			this.textBoxNome.Name = "textBoxNome";
			this.textBoxNome.Size = new System.Drawing.Size(333, 23);
			this.textBoxNome.TabIndex = 10;
			// 
			// textBoxArtista
			// 
			this.textBoxArtista.Location = new System.Drawing.Point(136, 96);
			this.textBoxArtista.Name = "textBoxArtista";
			this.textBoxArtista.Size = new System.Drawing.Size(333, 23);
			this.textBoxArtista.TabIndex = 11;
			// 
			// comboBoxCategoria
			// 
			this.comboBoxCategoria.FormattingEnabled = true;
			this.comboBoxCategoria.Location = new System.Drawing.Point(136, 140);
			this.comboBoxCategoria.Name = "comboBoxCategoria";
			this.comboBoxCategoria.Size = new System.Drawing.Size(333, 23);
			this.comboBoxCategoria.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(186, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 15);
			this.label7.TabIndex = 16;
			this.label7.Text = "Cadastrar Funcionário";
			// 
			// CadastroFuncionarioForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 241);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBoxCategoria);
			this.Controls.Add(this.textBoxArtista);
			this.Controls.Add(this.textBoxNome);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonSalvar);
			this.Name = "CadastroFuncionarioForm";
			this.Text = "Cadastrar Funcionário";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonSalvar;
		private System.Windows.Forms.Button buttonCancelar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxNome;
		private System.Windows.Forms.TextBox textBoxArtista;
		private System.Windows.Forms.ComboBox comboBoxCategoria;
		private System.Windows.Forms.Label label7;
	}
}