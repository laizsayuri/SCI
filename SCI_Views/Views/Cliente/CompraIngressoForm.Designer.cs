namespace SCI_Views.Views
{
	partial class CompraIngressoForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTipoIngresso = new System.Windows.Forms.ComboBox();
            this.textBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNumeroCartao = new System.Windows.Forms.TextBox();
            this.textBoxNomeCartao = new System.Windows.Forms.TextBox();
            this.textBoxValidadeCartao = new System.Windows.Forms.TextBox();
            this.textBoxCodSegurancaCartao = new System.Windows.Forms.TextBox();
            this.buttonBoleto = new System.Windows.Forms.Button();
            this.buttonCartão = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEvento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comprar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(311, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forma de Pagamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Ingresso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuário do Ingresso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(14, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cartão de Crédito";
            // 
            // comboBoxTipoIngresso
            // 
            this.comboBoxTipoIngresso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
            this.comboBoxTipoIngresso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoIngresso.FormattingEnabled = true;
            this.comboBoxTipoIngresso.Location = new System.Drawing.Point(132, 85);
            this.comboBoxTipoIngresso.Name = "comboBoxTipoIngresso";
            this.comboBoxTipoIngresso.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTipoIngresso.TabIndex = 5;
            // 
            // textBoxNomeUsuario
            // 
            this.textBoxNomeUsuario.Enabled = false;
            this.textBoxNomeUsuario.Location = new System.Drawing.Point(132, 130);
            this.textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            this.textBoxNomeUsuario.Size = new System.Drawing.Size(511, 23);
            this.textBoxNomeUsuario.TabIndex = 6;
            // 
            // textBoxNumeroCartao
            // 
            this.textBoxNumeroCartao.Location = new System.Drawing.Point(135, 221);
            this.textBoxNumeroCartao.Name = "textBoxNumeroCartao";
            this.textBoxNumeroCartao.PlaceholderText = "Número do Cartão";
            this.textBoxNumeroCartao.Size = new System.Drawing.Size(352, 23);
            this.textBoxNumeroCartao.TabIndex = 7;
            // 
            // textBoxNomeCartao
            // 
            this.textBoxNomeCartao.Location = new System.Drawing.Point(135, 263);
            this.textBoxNomeCartao.Name = "textBoxNomeCartao";
            this.textBoxNomeCartao.PlaceholderText = "Nome no Cartão";
            this.textBoxNomeCartao.Size = new System.Drawing.Size(352, 23);
            this.textBoxNomeCartao.TabIndex = 8;
            // 
            // textBoxValidadeCartao
            // 
            this.textBoxValidadeCartao.Location = new System.Drawing.Point(506, 221);
            this.textBoxValidadeCartao.Name = "textBoxValidadeCartao";
            this.textBoxValidadeCartao.PlaceholderText = "Validade";
            this.textBoxValidadeCartao.Size = new System.Drawing.Size(140, 23);
            this.textBoxValidadeCartao.TabIndex = 9;
            // 
            // textBoxCodSegurancaCartao
            // 
            this.textBoxCodSegurancaCartao.Location = new System.Drawing.Point(506, 263);
            this.textBoxCodSegurancaCartao.Name = "textBoxCodSegurancaCartao";
            this.textBoxCodSegurancaCartao.PlaceholderText = "Segurança";
            this.textBoxCodSegurancaCartao.Size = new System.Drawing.Size(140, 23);
            this.textBoxCodSegurancaCartao.TabIndex = 10;
            // 
            // buttonBoleto
            // 
            this.buttonBoleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
            this.buttonBoleto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBoleto.Location = new System.Drawing.Point(30, 312);
            this.buttonBoleto.Name = "buttonBoleto";
            this.buttonBoleto.Size = new System.Drawing.Size(75, 23);
            this.buttonBoleto.TabIndex = 11;
            this.buttonBoleto.Text = "Boleto";
            this.buttonBoleto.UseVisualStyleBackColor = false;
            this.buttonBoleto.Click += new System.EventHandler(this.buttonBoleto_Click);
            // 
            // buttonCartão
            // 
            this.buttonCartão.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
            this.buttonCartão.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCartão.Location = new System.Drawing.Point(680, 240);
            this.buttonCartão.Name = "buttonCartão";
            this.buttonCartão.Size = new System.Drawing.Size(75, 23);
            this.buttonCartão.TabIndex = 12;
            this.buttonCartão.Text = "Comprar";
            this.buttonCartão.UseVisualStyleBackColor = false;
            this.buttonCartão.Click += new System.EventHandler(this.buttonCartão_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Evento";
            // 
            // textBoxEvento
            // 
            this.textBoxEvento.Enabled = false;
            this.textBoxEvento.Location = new System.Drawing.Point(132, 42);
            this.textBoxEvento.Name = "textBoxEvento";
            this.textBoxEvento.Size = new System.Drawing.Size(511, 23);
            this.textBoxEvento.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxEvento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxTipoIngresso);
            this.panel1.Controls.Add(this.textBoxNomeUsuario);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 167);
            this.panel1.TabIndex = 15;
            // 
            // CompraIngressoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(774, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCartão);
            this.Controls.Add(this.buttonBoleto);
            this.Controls.Add(this.textBoxCodSegurancaCartao);
            this.Controls.Add(this.textBoxValidadeCartao);
            this.Controls.Add(this.textBoxNomeCartao);
            this.Controls.Add(this.textBoxNumeroCartao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CompraIngressoForm";
            this.Text = "Comprar Ingresso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxTipoIngresso;
		private System.Windows.Forms.TextBox textBoxNomeUsuario;
		private System.Windows.Forms.TextBox textBoxNumeroCartao;
		private System.Windows.Forms.TextBox textBoxNomeCartao;
		private System.Windows.Forms.TextBox textBoxValidadeCartao;
		private System.Windows.Forms.TextBox textBoxCodSegurancaCartao;
		private System.Windows.Forms.Button buttonBoleto;
		private System.Windows.Forms.Button buttonCartão;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxEvento;
		private System.Windows.Forms.Panel panel1;
	}
}