namespace SCI_Views.Views
{
    partial class GerenciaFuncionarios
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.dgNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(75, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Funcionários";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgNome,
            this.dgEmail,
            this.dgCpf});
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(600, 410);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(638, 28);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(140, 23);
            this.buttonCadastrar.TabIndex = 2;
            this.buttonCadastrar.Text = "Cadastrar Funcionário";
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
            // dgNome
            // 
            this.dgNome.HeaderText = "Nome";
            this.dgNome.Name = "dgNome";
            // 
            // dgEmail
            // 
            this.dgEmail.HeaderText = "Email";
            this.dgEmail.Name = "dgEmail";
            // 
            // dgCpf
            // 
            this.dgCpf.HeaderText = "CPF";
            this.dgCpf.Name = "dgCpf";
            // 
            // GerenciaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTitle);
            this.Name = "GerenciaFuncionarios";
            this.Text = "Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonRemover;

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dgNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCpf;
    }
}