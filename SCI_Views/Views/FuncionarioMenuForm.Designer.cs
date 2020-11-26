namespace SCI_Views.Views
{
	partial class FuncionarioMenuForm
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
			this.labelHello = new System.Windows.Forms.Label();
			this.buttonClientes = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelHello
			// 
			this.labelHello.AutoSize = true;
			this.labelHello.Location = new System.Drawing.Point(13, 13);
			this.labelHello.Name = "labelHello";
			this.labelHello.Size = new System.Drawing.Size(142, 15);
			this.labelHello.TabIndex = 1;
			this.labelHello.Text = "Bem vindo, Funcionário...";
			// 
			// buttonClientes
			// 
			this.buttonClientes.Location = new System.Drawing.Point(41, 57);
			this.buttonClientes.Name = "buttonClientes";
			this.buttonClientes.Size = new System.Drawing.Size(150, 23);
			this.buttonClientes.TabIndex = 2;
			this.buttonClientes.Text = "Gerenciar Clientes";
			this.buttonClientes.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(41, 106);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Gerenciar Eventos";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// FuncionarioMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 164);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonClientes);
			this.Controls.Add(this.labelHello);
			this.Name = "FuncionarioMenuForm";
			this.Text = "Menu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Label labelHello;
		private System.Windows.Forms.Button buttonClientes;
		private System.Windows.Forms.Button button1;
		#endregion
	}
}