namespace SCI_Views.Views
{
	partial class GerenciaFuncionariosForm
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
			this.dgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonCadastrar = new System.Windows.Forms.Button();
			this.buttonEditar = new System.Windows.Forms.Button();
			this.buttonRemover = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
			this.labelTitle.Location = new System.Drawing.Point(330, 5);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(92, 20);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Funcionários";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCod,
            this.dgNome,
            this.dgEmail,
            this.dgCpf});
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
			// buttonCadastrar
			// 
			this.buttonCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
			this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCadastrar.Location = new System.Drawing.Point(638, 28);
			this.buttonCadastrar.Name = "buttonCadastrar";
			this.buttonCadastrar.Size = new System.Drawing.Size(140, 23);
			this.buttonCadastrar.TabIndex = 2;
			this.buttonCadastrar.Text = "Cadastrar Funcionário";
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
			// GerenciaFuncionariosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonRemover);
			this.Controls.Add(this.buttonEditar);
			this.Controls.Add(this.buttonCadastrar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.labelTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "GerenciaFuncionariosForm";
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

		private System.Windows.Forms.DataGridViewTextBoxColumn dgCod;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgCpf;
	}
}