namespace SCI_Views.Views
{
	partial class GerenciaEventosForm
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dgCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgArtista = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgData = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgLiberado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgValorIngresso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgNumeroIngressos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonCadastrar = new System.Windows.Forms.Button();
			this.buttonEditar = new System.Windows.Forms.Button();
			this.buttonRemover = new System.Windows.Forms.Button();
			this.buttonIngressos = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
			this.labelTitle.Location = new System.Drawing.Point(372, 5);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(60, 20);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Eventos";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCod,
            this.dgNome,
            this.dgCategoria,
            this.dgLocal,
            this.dgArtista,
            this.dgData,
            this.dgLiberado,
            this.dgValorIngresso,
            this.dgNumeroIngressos,
            this.dgDescricao});
			this.dataGridView1.Location = new System.Drawing.Point(13, 28);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(600, 410);
			this.dataGridView1.TabIndex = 1;
			// 
			// dgCod
			// 
			this.dgCod.HeaderText = "Cod";
			this.dgCod.Name = "dgCod";
			this.dgCod.Visible = false;
			// 
			// dgNome
			// 
			this.dgNome.FillWeight = 161.5799F;
			this.dgNome.HeaderText = "Nome";
			this.dgNome.Name = "dgNome";
			this.dgNome.Width = 65;
			// 
			// dgCategoria
			// 
			this.dgCategoria.FillWeight = 139.5202F;
			this.dgCategoria.HeaderText = "Categoria";
			this.dgCategoria.Name = "dgCategoria";
			this.dgCategoria.Width = 83;
			// 
			// dgLocal
			// 
			this.dgLocal.FillWeight = 120.9851F;
			this.dgLocal.HeaderText = "Local";
			this.dgLocal.Name = "dgLocal";
			this.dgLocal.Width = 60;
			// 
			// dgArtista
			// 
			this.dgArtista.FillWeight = 105.463F;
			this.dgArtista.HeaderText = "Artista";
			this.dgArtista.Name = "dgArtista";
			this.dgArtista.Width = 66;
			// 
			// dgData
			// 
			this.dgData.FillWeight = 92.51806F;
			this.dgData.HeaderText = "Data";
			this.dgData.Name = "dgData";
			this.dgData.Width = 56;
			// 
			// dgLiberado
			// 
			this.dgLiberado.FillWeight = 81.67323F;
			this.dgLiberado.HeaderText = "Liberado";
			this.dgLiberado.Name = "dgLiberado";
			this.dgLiberado.Width = 78;
			// 
			// dgValorIngresso
			// 
			this.dgValorIngresso.FillWeight = 72.83327F;
			this.dgValorIngresso.HeaderText = "Valor Ingresso";
			this.dgValorIngresso.Name = "dgValorIngresso";
			this.dgValorIngresso.Width = 97;
			// 
			// dgNumeroIngressos
			// 
			this.dgNumeroIngressos.FillWeight = 65.61888F;
			this.dgNumeroIngressos.HeaderText = "Qtd Ingressos";
			this.dgNumeroIngressos.Name = "dgNumeroIngressos";
			this.dgNumeroIngressos.Width = 96;
			// 
			// dgDescricao
			// 
			this.dgDescricao.FillWeight = 59.8084F;
			this.dgDescricao.HeaderText = "Descrição";
			this.dgDescricao.Name = "dgDescricao";
			this.dgDescricao.Width = 83;
			// 
			// Nome
			// 
			this.Nome.HeaderText = "Nome";
			this.Nome.Name = "Nome";
			// 
			// Categoria
			// 
			this.Categoria.HeaderText = "Categoria";
			this.Categoria.Name = "Categoria";
			// 
			// Local
			// 
			this.Local.HeaderText = "Local";
			this.Local.Name = "Local";
			// 
			// Data
			// 
			this.Data.HeaderText = "Data";
			this.Data.Name = "Data";
			// 
			// Artista
			// 
			this.Artista.HeaderText = "Artista";
			this.Artista.Name = "Artista";
			// 
			// buttonCadastrar
			// 
			this.buttonCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCadastrar.Location = new System.Drawing.Point(646, 28);
			this.buttonCadastrar.Name = "buttonCadastrar";
			this.buttonCadastrar.Size = new System.Drawing.Size(125, 23);
			this.buttonCadastrar.TabIndex = 2;
			this.buttonCadastrar.Text = "Cadastrar Evento";
			this.buttonCadastrar.UseVisualStyleBackColor = false;
			this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
			// 
			// buttonEditar
			// 
			this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonEditar.Location = new System.Drawing.Point(668, 364);
			this.buttonEditar.Name = "buttonEditar";
			this.buttonEditar.Size = new System.Drawing.Size(75, 23);
			this.buttonEditar.TabIndex = 3;
			this.buttonEditar.Text = "Editar";
			this.buttonEditar.UseVisualStyleBackColor = false;
			this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
			// 
			// buttonRemover
			// 
			this.buttonRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonRemover.Location = new System.Drawing.Point(668, 402);
			this.buttonRemover.Name = "buttonRemover";
			this.buttonRemover.Size = new System.Drawing.Size(75, 23);
			this.buttonRemover.TabIndex = 4;
			this.buttonRemover.Text = "Remover";
			this.buttonRemover.UseVisualStyleBackColor = false;
			this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
			// 
			// buttonIngressos
			// 
			this.buttonIngressos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonIngressos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonIngressos.Location = new System.Drawing.Point(646, 324);
			this.buttonIngressos.Name = "buttonIngressos";
			this.buttonIngressos.Size = new System.Drawing.Size(125, 23);
			this.buttonIngressos.TabIndex = 5;
			this.buttonIngressos.Text = "Gerar Ingressos";
			this.buttonIngressos.UseVisualStyleBackColor = false;
			this.buttonIngressos.Click += new System.EventHandler(this.button1_Click);
			// 
			// GerenciaEventosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonIngressos);
			this.Controls.Add(this.buttonRemover);
			this.Controls.Add(this.buttonEditar);
			this.Controls.Add(this.buttonCadastrar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.labelTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "GerenciaEventosForm";
			this.Text = "Eventos";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
		private System.Windows.Forms.DataGridViewTextBoxColumn Local;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data;
		private System.Windows.Forms.DataGridViewTextBoxColumn Artista;
		private System.Windows.Forms.Button buttonCadastrar;
		private System.Windows.Forms.Button buttonEditar;
		private System.Windows.Forms.Button buttonRemover;
		private System.Windows.Forms.Button buttonIngressos;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgCod;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgCategoria;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgLocal;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgArtista;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgData;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgLiberado;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgValorIngresso;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgNumeroIngressos;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgDescricao;
	}
}