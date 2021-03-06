﻿namespace SCI_Views.Views
{
	partial class CadastroEventoForm
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
			this.buttonCadastroCategoria = new System.Windows.Forms.Button();
			this.buttonCadastroLocal = new System.Windows.Forms.Button();
			this.buttonSalvar = new System.Windows.Forms.Button();
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxNome = new System.Windows.Forms.TextBox();
			this.textBoxArtista = new System.Windows.Forms.TextBox();
			this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
			this.comboBoxLocal = new System.Windows.Forms.ComboBox();
			this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
			this.textBoxDescricao = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonCadastroCategoria
			// 
			this.buttonCadastroCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonCadastroCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCadastroCategoria.Location = new System.Drawing.Point(9, 393);
			this.buttonCadastroCategoria.Name = "buttonCadastroCategoria";
			this.buttonCadastroCategoria.Size = new System.Drawing.Size(125, 23);
			this.buttonCadastroCategoria.TabIndex = 0;
			this.buttonCadastroCategoria.Text = "Cadastrar Categoria";
			this.buttonCadastroCategoria.UseVisualStyleBackColor = false;
			this.buttonCadastroCategoria.Click += new System.EventHandler(this.buttonCadastroCategoria_Click);
			// 
			// buttonCadastroLocal
			// 
			this.buttonCadastroLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonCadastroLocal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCadastroLocal.Location = new System.Drawing.Point(140, 393);
			this.buttonCadastroLocal.Name = "buttonCadastroLocal";
			this.buttonCadastroLocal.Size = new System.Drawing.Size(125, 23);
			this.buttonCadastroLocal.TabIndex = 1;
			this.buttonCadastroLocal.Text = "Cadastrar Local";
			this.buttonCadastroLocal.UseVisualStyleBackColor = false;
			this.buttonCadastroLocal.Click += new System.EventHandler(this.buttonCadastroLocal_Click);
			// 
			// buttonSalvar
			// 
			this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonSalvar.Location = new System.Drawing.Point(394, 393);
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
			this.buttonCancelar.Location = new System.Drawing.Point(313, 393);
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
			this.label1.Location = new System.Drawing.Point(12, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nome do Evento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Categoria";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Local";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Artista";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 230);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Data do Evento";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 271);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 15);
			this.label6.TabIndex = 9;
			this.label6.Text = "Descrição";
			// 
			// textBoxNome
			// 
			this.textBoxNome.Location = new System.Drawing.Point(136, 46);
			this.textBoxNome.Name = "textBoxNome";
			this.textBoxNome.Size = new System.Drawing.Size(333, 23);
			this.textBoxNome.TabIndex = 10;
			// 
			// textBoxArtista
			// 
			this.textBoxArtista.Location = new System.Drawing.Point(136, 91);
			this.textBoxArtista.Name = "textBoxArtista";
			this.textBoxArtista.Size = new System.Drawing.Size(333, 23);
			this.textBoxArtista.TabIndex = 11;
			// 
			// comboBoxCategoria
			// 
			this.comboBoxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCategoria.ForeColor = System.Drawing.SystemColors.WindowText;
			this.comboBoxCategoria.FormattingEnabled = true;
			this.comboBoxCategoria.Location = new System.Drawing.Point(136, 135);
			this.comboBoxCategoria.Name = "comboBoxCategoria";
			this.comboBoxCategoria.Size = new System.Drawing.Size(333, 23);
			this.comboBoxCategoria.TabIndex = 12;
			// 
			// comboBoxLocal
			// 
			this.comboBoxLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.comboBoxLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLocal.FormattingEnabled = true;
			this.comboBoxLocal.Location = new System.Drawing.Point(136, 181);
			this.comboBoxLocal.Name = "comboBoxLocal";
			this.comboBoxLocal.Size = new System.Drawing.Size(333, 23);
			this.comboBoxLocal.TabIndex = 13;
			// 
			// dateTimePickerData
			// 
			this.dateTimePickerData.Location = new System.Drawing.Point(136, 224);
			this.dateTimePickerData.Name = "dateTimePickerData";
			this.dateTimePickerData.Size = new System.Drawing.Size(333, 23);
			this.dateTimePickerData.TabIndex = 14;
			// 
			// textBoxDescricao
			// 
			this.textBoxDescricao.Location = new System.Drawing.Point(136, 271);
			this.textBoxDescricao.Multiline = true;
			this.textBoxDescricao.Name = "textBoxDescricao";
			this.textBoxDescricao.Size = new System.Drawing.Size(333, 95);
			this.textBoxDescricao.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(204, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 15);
			this.label7.TabIndex = 16;
			this.label7.Text = "Cadastrar Evento";
			// 
			// CadastroEventoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.ClientSize = new System.Drawing.Size(487, 431);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxDescricao);
			this.Controls.Add(this.dateTimePickerData);
			this.Controls.Add(this.comboBoxLocal);
			this.Controls.Add(this.comboBoxCategoria);
			this.Controls.Add(this.textBoxArtista);
			this.Controls.Add(this.textBoxNome);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonSalvar);
			this.Controls.Add(this.buttonCadastroLocal);
			this.Controls.Add(this.buttonCadastroCategoria);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CadastroEventoForm";
			this.Text = "Cadastrar Evento";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCadastroCategoria;
		private System.Windows.Forms.Button buttonCadastroLocal;
		private System.Windows.Forms.Button buttonSalvar;
		private System.Windows.Forms.Button buttonCancelar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxNome;
		private System.Windows.Forms.TextBox textBoxArtista;
		private System.Windows.Forms.ComboBox comboBoxCategoria;
		private System.Windows.Forms.ComboBox comboBoxLocal;
		private System.Windows.Forms.DateTimePicker dateTimePickerData;
		private System.Windows.Forms.TextBox textBoxDescricao;
		private System.Windows.Forms.Label label7;
	}
}