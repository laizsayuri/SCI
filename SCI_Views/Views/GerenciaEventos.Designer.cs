namespace SCI_Views.Views
{
    partial class GerenciaEventos
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
            this.dgNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgArtista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgData = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            //
            // labelTitle
            //
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(48, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Eventos";
            //
            // dataGridView1
            //
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgNome,
            this.dgCategoria,
            this.dgLocal,
            this.dgArtista,
            this.dgData,
            this.dgValorIngresso,
            this.dgNumeroIngressos,
            this.dgLiberado,
            this.dgDescricao});
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(600, 410);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Gerar Ingressos";
            this.button1.UseVisualStyleBackColor = true;
            //
            // dgNome
            //
            this.dgNome.HeaderText = "Nome";
            this.dgNome.Name = "dgNome";
            //
            // dgCategoria
            //
            this.dgCategoria.HeaderText = "Categoria";
            this.dgCategoria.Name = "dgCategoria";
            //
            // dgLocal
            //
            this.dgLocal.HeaderText = "Local";
            this.dgLocal.Name = "dgLocal";
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
            // dgValorIngresso
            //
            this.dgValorIngresso.HeaderText = "Valor Ingresso";
            this.dgValorIngresso.Name = "dgValorIngresso";
            //
            // dgNumeroIngressos
            //
            this.dgNumeroIngressos.HeaderText = "Qtd Ingressos";
            this.dgNumeroIngressos.Name = "dgNumeroIngressos";
            //
            // dgDescricao
            //
            this.dgDescricao.HeaderText = "Descrição";
            this.dgDescricao.Name = "dgDescricao";
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
            this.buttonCadastrar.Location = new System.Drawing.Point(646, 28);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(125, 23);
            this.buttonCadastrar.TabIndex = 2;
            this.buttonCadastrar.Text = "Cadastrar Evento";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            //
            // buttonEditar
            //
            this.buttonEditar.Location = new System.Drawing.Point(668, 364);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            //
            // buttonRemover
            //
            this.buttonRemover.Location = new System.Drawing.Point(668, 402);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 4;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            //
            // GerenciaEventos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTitle);
            this.Name = "GerenciaEventos";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgArtista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgLiberado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgValorIngresso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNumeroIngressos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescricao;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button button1;
    }
}

