namespace SCI_Views.Views
{
	partial class CadastroIngressosForm
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
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxNome = new System.Windows.Forms.TextBox();
			this.textBoxArtista = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonSalvar
			// 
			this.buttonSalvar.Location = new System.Drawing.Point(397, 185);
			this.buttonSalvar.Name = "buttonSalvar";
			this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
			this.buttonSalvar.TabIndex = 2;
			this.buttonSalvar.Text = "Salvar";
			this.buttonSalvar.UseVisualStyleBackColor = true;
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.Location = new System.Drawing.Point(316, 185);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
			this.buttonCancelar.TabIndex = 3;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Valor do Ingresso";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Quantidade";
			// 
			// textBoxNome
			// 
			this.textBoxNome.Location = new System.Drawing.Point(139, 68);
			this.textBoxNome.Name = "textBoxNome";
			this.textBoxNome.Size = new System.Drawing.Size(333, 23);
			this.textBoxNome.TabIndex = 10;
			// 
			// textBoxArtista
			// 
			this.textBoxArtista.Location = new System.Drawing.Point(139, 113);
			this.textBoxArtista.Name = "textBoxArtista";
			this.textBoxArtista.Size = new System.Drawing.Size(333, 23);
			this.textBoxArtista.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(209, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 15);
			this.label7.TabIndex = 16;
			this.label7.Text = "Gerar Ingressos";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 185);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 23);
			this.button1.TabIndex = 17;
			this.button1.Text = "Liberar Venda";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// CadastroIngressosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 227);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxArtista);
			this.Controls.Add(this.textBoxNome);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonSalvar);
			this.Name = "CadastroIngressosForm";
			this.Text = "Gerar Ingressos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonSalvar;
		private System.Windows.Forms.Button buttonCancelar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxNome;
		private System.Windows.Forms.TextBox textBoxArtista;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
	}
}