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
			this.textBoxValor = new System.Windows.Forms.TextBox();
			this.textBoxQuantidade = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonLiberarVenda = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonSalvar
			// 
			this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonSalvar.Location = new System.Drawing.Point(397, 185);
			this.buttonSalvar.Name = "buttonSalvar";
			this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
			this.buttonSalvar.TabIndex = 2;
			this.buttonSalvar.Text = "Salvar";
			this.buttonSalvar.UseVisualStyleBackColor = false;
			this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCancelar.Location = new System.Drawing.Point(316, 185);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
			this.buttonCancelar.TabIndex = 3;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = false;
			this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
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
			// textBoxValor
			// 
			this.textBoxValor.Location = new System.Drawing.Point(139, 68);
			this.textBoxValor.Name = "textBoxValor";
			this.textBoxValor.Size = new System.Drawing.Size(333, 23);
			this.textBoxValor.TabIndex = 10;
			// 
			// textBoxQuantidade
			// 
			this.textBoxQuantidade.Location = new System.Drawing.Point(139, 113);
			this.textBoxQuantidade.Name = "textBoxQuantidade";
			this.textBoxQuantidade.Size = new System.Drawing.Size(333, 23);
			this.textBoxQuantidade.TabIndex = 11;
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
			// buttonLiberarVenda
			// 
			this.buttonLiberarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonLiberarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonLiberarVenda.Location = new System.Drawing.Point(15, 185);
			this.buttonLiberarVenda.Name = "buttonLiberarVenda";
			this.buttonLiberarVenda.Size = new System.Drawing.Size(125, 23);
			this.buttonLiberarVenda.TabIndex = 17;
			this.buttonLiberarVenda.Text = "Liberar Venda";
			this.buttonLiberarVenda.UseVisualStyleBackColor = false;
			this.buttonLiberarVenda.Click += new System.EventHandler(this.buttonLiberarBenda_Click);
			// 
			// buttonOk
			// 
			this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonOk.Location = new System.Drawing.Point(397, 185);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 18;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = false;
			this.buttonOk.Visible = false;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// CadastroIngressosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.ClientSize = new System.Drawing.Size(487, 227);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonLiberarVenda);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxQuantidade);
			this.Controls.Add(this.textBoxValor);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonSalvar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
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
		private System.Windows.Forms.TextBox textBoxValor;		
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonLiberarVenda;
		private System.Windows.Forms.TextBox textBoxQuantidade;
		private System.Windows.Forms.Button buttonOk;
	}
}
