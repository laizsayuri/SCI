namespace SCI_Views.Views
{
	partial class CadastroLocalForm
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxCidade = new System.Windows.Forms.TextBox();
			this.textBoxEndereco = new System.Windows.Forms.TextBox();
			this.comboBoxEstado = new System.Windows.Forms.ComboBox();
			this.buttonSalvar = new System.Windows.Forms.Button();
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(169, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastrar Local";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cidade";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Estado";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Endereço";
			// 
			// textBoxCidade
			// 
			this.textBoxCidade.Location = new System.Drawing.Point(113, 64);
			this.textBoxCidade.Name = "textBoxCidade";
			this.textBoxCidade.Size = new System.Drawing.Size(281, 23);
			this.textBoxCidade.TabIndex = 4;
			// 
			// textBoxEndereco
			// 
			this.textBoxEndereco.Location = new System.Drawing.Point(113, 149);
			this.textBoxEndereco.Name = "textBoxEndereco";
			this.textBoxEndereco.Size = new System.Drawing.Size(281, 23);
			this.textBoxEndereco.TabIndex = 6;
			// 
			// comboBoxEstado
			// 
			this.comboBoxEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEstado.FormattingEnabled = true;
			this.comboBoxEstado.Location = new System.Drawing.Point(113, 107);
			this.comboBoxEstado.Name = "comboBoxEstado";
			this.comboBoxEstado.Size = new System.Drawing.Size(281, 23);
			this.comboBoxEstado.TabIndex = 5;
			// 
			// buttonSalvar
			// 
			this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonSalvar.Location = new System.Drawing.Point(338, 210);
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
			this.buttonCancelar.Location = new System.Drawing.Point(257, 210);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
			this.buttonCancelar.TabIndex = 8;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = false;
			this.buttonCancelar.Click += new System.EventHandler(this.button2_Click);
			// 
			// CadastroLocalForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.ClientSize = new System.Drawing.Size(425, 245);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonSalvar);
			this.Controls.Add(this.comboBoxEstado);
			this.Controls.Add(this.textBoxEndereco);
			this.Controls.Add(this.textBoxCidade);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CadastroLocalForm";
			this.Text = "Cadastrar Local";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCidade;
		private System.Windows.Forms.TextBox textBoxEndereco;
		private System.Windows.Forms.ComboBox comboBoxEstado;
		private System.Windows.Forms.Button buttonSalvar;
		private System.Windows.Forms.Button buttonCancelar;
	}
}
