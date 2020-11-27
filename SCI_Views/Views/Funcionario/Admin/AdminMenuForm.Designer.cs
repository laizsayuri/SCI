namespace SCI_Views.Views
{
	partial class AdminMenuForm
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
			this.buttonFuncionarios = new System.Windows.Forms.Button();
			this.labelHello = new System.Windows.Forms.Label();
			this.buttonClientes = new System.Windows.Forms.Button();
			this.buttonEventos = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonFuncionarios
			// 
			this.buttonFuncionarios.Location = new System.Drawing.Point(41, 51);
			this.buttonFuncionarios.Name = "buttonFuncionarios";
			this.buttonFuncionarios.Size = new System.Drawing.Size(150, 23);
			this.buttonFuncionarios.TabIndex = 0;
			this.buttonFuncionarios.Text = "Gerenciar Funcionários";
			this.buttonFuncionarios.UseVisualStyleBackColor = true;
			// 
			// labelHello
			// 
			this.labelHello.AutoSize = true;
			this.labelHello.Location = new System.Drawing.Point(13, 13);
			this.labelHello.Name = "labelHello";
			this.labelHello.Size = new System.Drawing.Size(115, 15);
			this.labelHello.TabIndex = 1;
			this.labelHello.Text = "Bem vindo, Admin...";
			// 
			// buttonClientes
			// 
			this.buttonClientes.Location = new System.Drawing.Point(41, 96);
			this.buttonClientes.Name = "buttonClientes";
			this.buttonClientes.Size = new System.Drawing.Size(150, 23);
			this.buttonClientes.TabIndex = 2;
			this.buttonClientes.Text = "Gerenciar Clientes";
			this.buttonClientes.UseVisualStyleBackColor = true;
			// 
			// buttonEventos
			// 
			this.buttonEventos.Location = new System.Drawing.Point(41, 141);
			this.buttonEventos.Name = "buttonEventos";
			this.buttonEventos.Size = new System.Drawing.Size(150, 23);
			this.buttonEventos.TabIndex = 3;
			this.buttonEventos.Text = "Gerenciar Eventos";
			this.buttonEventos.UseVisualStyleBackColor = true;
			// 
			// AdminMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 191);
			this.Controls.Add(this.buttonEventos);
			this.Controls.Add(this.buttonClientes);
			this.Controls.Add(this.labelHello);
			this.Controls.Add(this.buttonFuncionarios);
			this.Name = "AdminMenuForm";
			this.Text = "Menu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonFuncionarios;
		private System.Windows.Forms.Label labelHello;
		private System.Windows.Forms.Button buttonClientes;
		private System.Windows.Forms.Button buttonEventos;
	}
}