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
			this.dgCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgArtista = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgData = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonEditar = new System.Windows.Forms.Button();
			this.buttonRemover = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxLocal = new System.Windows.Forms.ComboBox();
			this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCod,
            this.dgEvento,
            this.dgArtista,
            this.dgData,
            this.dgLocal,
            this.dgCategoria,
            this.dgValor});
			this.dataGridView1.Location = new System.Drawing.Point(13, 169);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(741, 352);
			this.dataGridView1.TabIndex = 1;
			// 
			// dgCod
			// 
			this.dgCod.HeaderText = "dgCod";
			this.dgCod.Name = "dgCod";
			this.dgCod.Visible = false;
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
			// buttonEditar
			// 
			this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonEditar.Location = new System.Drawing.Point(796, 12);
			this.buttonEditar.Name = "buttonEditar";
			this.buttonEditar.Size = new System.Drawing.Size(140, 23);
			this.buttonEditar.TabIndex = 2;
			this.buttonEditar.Text = "Editar Cliente";
			this.buttonEditar.UseVisualStyleBackColor = false;
			this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
			// 
			// buttonRemover
			// 
			this.buttonRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonRemover.Location = new System.Drawing.Point(786, 498);
			this.buttonRemover.Name = "buttonRemover";
			this.buttonRemover.Size = new System.Drawing.Size(150, 23);
			this.buttonRemover.TabIndex = 4;
			this.buttonRemover.Text = "Comprar Ingresso";
			this.buttonRemover.UseVisualStyleBackColor = false;
			this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.label1.Location = new System.Drawing.Point(21, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Categoria";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.label2.Location = new System.Drawing.Point(21, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Local";
			// 
			// comboBoxLocal
			// 
			this.comboBoxLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.comboBoxLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLocal.FormattingEnabled = true;
			this.comboBoxLocal.Location = new System.Drawing.Point(103, 53);
			this.comboBoxLocal.Name = "comboBoxLocal";
			this.comboBoxLocal.Size = new System.Drawing.Size(582, 23);
			this.comboBoxLocal.TabIndex = 7;
			this.comboBoxLocal.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLocal_SelectionChangeCommitted);
			// 
			// comboBoxCategoria
			// 
			this.comboBoxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCategoria.FormattingEnabled = true;
			this.comboBoxCategoria.Location = new System.Drawing.Point(103, 16);
			this.comboBoxCategoria.Name = "comboBoxCategoria";
			this.comboBoxCategoria.Size = new System.Drawing.Size(582, 23);
			this.comboBoxCategoria.TabIndex = 8;
			this.comboBoxCategoria.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCategoria_SelectionChangeCommitted);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
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
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(413, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "Próximos Eventos";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.comboBoxCategoria);
			this.panel1.Controls.Add(this.comboBoxLocal);
			this.panel1.Location = new System.Drawing.Point(13, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(741, 91);
			this.panel1.TabIndex = 11;
			// 
			// ClienteMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
			this.ClientSize = new System.Drawing.Size(948, 535);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonRemover);
			this.Controls.Add(this.buttonEditar);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ClienteMenuForm";
			this.Text = "Menu";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClienteMenuForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonEditar;
		private System.Windows.Forms.Button buttonRemover;

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxLocal;
		private System.Windows.Forms.ComboBox comboBoxCategoria;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgCod;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgEvento;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgArtista;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgData;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgLocal;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgCategoria;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgValor;
		private System.Windows.Forms.Panel panel1;
	}
}