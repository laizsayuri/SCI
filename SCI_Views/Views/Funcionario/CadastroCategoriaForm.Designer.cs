namespace SCI_Views.Views
{
	partial class CadastroCategoriaForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxNome = new System.Windows.Forms.TextBox();
			this.buttonSalvar = new System.Windows.Forms.Button();
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(165, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastrar Categoria";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome";
			// 
			// textBoxNome
			// 
			this.textBoxNome.Location = new System.Drawing.Point(113, 64);
			this.textBoxNome.Name = "textBoxNome";
			this.textBoxNome.Size = new System.Drawing.Size(281, 23);
			this.textBoxNome.TabIndex = 4;
			// 
			// buttonSalvar
			// 
			this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonSalvar.Location = new System.Drawing.Point(338, 131);
			this.buttonSalvar.Name = "buttonSalvar";
			this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
			this.buttonSalvar.TabIndex = 7;
			this.buttonSalvar.Text = "Salvar";
			this.buttonSalvar.UseVisualStyleBackColor = false;
			this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCancelar.Location = new System.Drawing.Point(257, 131);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
			this.buttonCancelar.TabIndex = 8;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = false;
			this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
			// 
			// CadastroCategoriaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.ClientSize = new System.Drawing.Size(425, 171);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonSalvar);
			this.Controls.Add(this.textBoxNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CadastroCategoriaForm";
			this.Text = "Cadastrar Categoria";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNome;
		private System.Windows.Forms.Button buttonSalvar;
		private System.Windows.Forms.Button buttonCancelar;

		#endregion
	}
}
