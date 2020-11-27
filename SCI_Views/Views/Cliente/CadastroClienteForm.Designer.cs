namespace SCI_Views.Views
{
	public partial class CadastroClienteForm : FormBase
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
			this.buttonAlterarSenha = new System.Windows.Forms.Button();
			this.buttonSalvar = new System.Windows.Forms.Button();
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxNome = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxCpf = new System.Windows.Forms.TextBox();
			this.textBoxTelefone = new System.Windows.Forms.TextBox();
			this.textBoxSenha = new System.Windows.Forms.TextBox();
			this.labelSenha = new System.Windows.Forms.Label();
			this.buttonExcluir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonAlterarSenha
			// 
			this.buttonAlterarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAlterarSenha.Location = new System.Drawing.Point(15, 360);
			this.buttonAlterarSenha.Name = "buttonAlterarSenha";
			this.buttonAlterarSenha.Size = new System.Drawing.Size(125, 23);
			this.buttonAlterarSenha.TabIndex = 18;
			this.buttonAlterarSenha.Text = "Alterar Senha";
			this.buttonAlterarSenha.UseVisualStyleBackColor = false;
			this.buttonAlterarSenha.Visible = false;
			this.buttonAlterarSenha.Click += new System.EventHandler(this.buttonAlterarSenha_Click);
			// 
			// buttonSalvar
			// 
			this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonSalvar.Location = new System.Drawing.Point(397, 392);
			this.buttonSalvar.Name = "buttonSalvar";
			this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
			this.buttonSalvar.TabIndex = 16;
			this.buttonSalvar.Text = "Salvar";
			this.buttonSalvar.UseVisualStyleBackColor = false;
			this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCancelar.Location = new System.Drawing.Point(316, 392);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
			this.buttonCancelar.TabIndex = 17;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = false;
			this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "CPF";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 210);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Telefone";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 259);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "E-mail";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 164);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Data Nascimento";
			// 
			// textBoxNome
			// 
			this.textBoxNome.Location = new System.Drawing.Point(139, 68);
			this.textBoxNome.Name = "textBoxNome";
			this.textBoxNome.Size = new System.Drawing.Size(333, 23);
			this.textBoxNome.TabIndex = 10;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(139, 256);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(333, 23);
			this.textBoxEmail.TabIndex = 14;
			// 
			// dateTimePickerData
			// 
			this.dateTimePickerData.Location = new System.Drawing.Point(139, 158);
			this.dateTimePickerData.Name = "dateTimePickerData";
			this.dateTimePickerData.Size = new System.Drawing.Size(333, 23);
			this.dateTimePickerData.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(198, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 15);
			this.label7.TabIndex = 16;
			this.label7.Text = "Cadastrar Cliente";
			// 
			// textBoxCpf
			// 
			this.textBoxCpf.Location = new System.Drawing.Point(139, 113);
			this.textBoxCpf.Name = "textBoxCpf";
			this.textBoxCpf.Size = new System.Drawing.Size(333, 23);
			this.textBoxCpf.TabIndex = 11;
			// 
			// textBoxTelefone
			// 
			this.textBoxTelefone.Location = new System.Drawing.Point(139, 207);
			this.textBoxTelefone.Name = "textBoxTelefone";
			this.textBoxTelefone.Size = new System.Drawing.Size(333, 23);
			this.textBoxTelefone.TabIndex = 13;
			// 
			// textBoxSenha
			// 
			this.textBoxSenha.Location = new System.Drawing.Point(139, 303);
			this.textBoxSenha.Name = "textBoxSenha";
			this.textBoxSenha.PasswordChar = '*';
			this.textBoxSenha.Size = new System.Drawing.Size(333, 23);
			this.textBoxSenha.TabIndex = 15;
			// 
			// labelSenha
			// 
			this.labelSenha.AutoSize = true;
			this.labelSenha.Location = new System.Drawing.Point(15, 306);
			this.labelSenha.Name = "labelSenha";
			this.labelSenha.Size = new System.Drawing.Size(39, 15);
			this.labelSenha.TabIndex = 19;
			this.labelSenha.Text = "Senha";
			// 
			// buttonExcluir
			// 
			this.buttonExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonExcluir.Location = new System.Drawing.Point(15, 392);
			this.buttonExcluir.Name = "buttonExcluir";
			this.buttonExcluir.Size = new System.Drawing.Size(150, 23);
			this.buttonExcluir.TabIndex = 19;
			this.buttonExcluir.Text = "Excluir meu Cadastro";
			this.buttonExcluir.UseVisualStyleBackColor = false;
			this.buttonExcluir.Visible = false;
			this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
			// 
			// CadastroClienteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.ClientSize = new System.Drawing.Size(487, 427);
			this.Controls.Add(this.buttonExcluir);
			this.Controls.Add(this.textBoxSenha);
			this.Controls.Add(this.labelSenha);
			this.Controls.Add(this.textBoxTelefone);
			this.Controls.Add(this.textBoxCpf);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dateTimePickerData);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxNome);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonSalvar);
			this.Controls.Add(this.buttonAlterarSenha);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CadastroClienteForm";
			this.Text = "Cadastrar Cliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAlterarSenha;
		private System.Windows.Forms.Button buttonSalvar;
		private System.Windows.Forms.Button buttonCancelar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxNome;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.DateTimePicker dateTimePickerData;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxCpf;
		private System.Windows.Forms.TextBox textBoxTelefone;
		private System.Windows.Forms.TextBox textBoxSenha;
		private System.Windows.Forms.Label labelSenha;
		private System.Windows.Forms.Button buttonExcluir;
	}
}
