namespace SCI_Views.Views
{
	partial class ClienteMenuForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonCadastrar = new System.Windows.Forms.Button();
			this.buttonRemover = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxLocal = new System.Windows.Forms.ComboBox();
			this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
			this.dgEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgArtista = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgData = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dgEvento,
			this.dgArtista,
			this.dgData,
			this.dgLocal,
			this.dgCategoria,
			this.dgValor});
			this.dataGridView1.Location = new System.Drawing.Point(13, 169);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(741, 352);
			this.dataGridView1.TabIndex = 1;
			// 
			// buttonCadastrar
			// 
			this.buttonCadastrar.Location = new System.Drawing.Point(796, 12);
			this.buttonCadastrar.Name = "buttonCadastrar";
			this.buttonCadastrar.Size = new System.Drawing.Size(140, 23);
			this.buttonCadastrar.TabIndex = 2;
			this.buttonCadastrar.Text = "Editar Cliente";
			this.buttonCadastrar.UseVisualStyleBackColor = true;
			// 
			// buttonRemover
			// 
			this.buttonRemover.Location = new System.Drawing.Point(786, 498);
			this.buttonRemover.Name = "buttonRemover";
			this.buttonRemover.Size = new System.Drawing.Size(150, 23);
			this.buttonRemover.TabIndex = 4;
			this.buttonRemover.Text = "Comprar Ingresso";
			this.buttonRemover.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Categoria";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Local";
			// 
			// comboBoxLocal
			// 
			this.comboBoxLocal.FormattingEnabled = true;
			this.comboBoxLocal.Location = new System.Drawing.Point(93, 91);
			this.comboBoxLocal.Name = "comboBoxLocal";
			this.comboBoxLocal.Size = new System.Drawing.Size(661, 23);
			this.comboBoxLocal.TabIndex = 7;
			// 
			// comboBoxCategoria
			// 
			this.comboBoxCategoria.FormattingEnabled = true;
			this.comboBoxCategoria.Location = new System.Drawing.Point(93, 52);
			this.comboBoxCategoria.Name = "comboBoxCategoria";
			this.comboBoxCategoria.Size = new System.Drawing.Size(661, 23);
			this.comboBoxCategoria.TabIndex = 8;
			// 
			// dgEvento
			// 
			this.dgEvento.HeaderText = "Evento";
			this.dgEvento.Name = "dgEvento";
			// 
			// dgArtista
			// 
			this.dgArtista.HeaderText = "Artista";
			this.dgArtista.Name = "dgArtista";
			// 
			// dgData
			// 
			this.dgData.HeaderText = "Data";
			this.dgData.Name = "dgData";
			// 
			// dgLocal
			// 
			this.dgLocal.HeaderText = "Local";
			this.dgLocal.Name = "dgLocal";
			// 
			// dgCategoria
			// 
			this.dgCategoria.HeaderText = "Categoria";
			this.dgCategoria.Name = "dgCategoria";
			// 
			// dgValor
			// 
			this.dgValor.HeaderText = "Valor";
			this.dgValor.Name = "dgValor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(393, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 25);
			this.label3.TabIndex = 9;
			this.label3.Text = "Encontre seu Evento";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(419, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "Próximos Eventos";
			// 
			// ClienteMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 533);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxCategoria);
			this.Controls.Add(this.comboBoxLocal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonRemover);
			this.Controls.Add(this.buttonCadastrar);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ClienteMenuForm";
			this.Text = "Menu";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonCadastrar;
		private System.Windows.Forms.Button buttonRemover;

		#endregion

		private System.Windows.Forms.DataGridViewTextBoxColumn dgEvento;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgArtista;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgData;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgLocal;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgCategoria;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgValor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxLocal;
		private System.Windows.Forms.ComboBox comboBoxCategoria;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}