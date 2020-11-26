﻿namespace SCI_Views.Views
{
	partial class LoginForm
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
			this.labelSubTitle = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelSenha = new System.Windows.Forms.Label();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.buttonCadastro = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelTitle.Location = new System.Drawing.Point(280, 51);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(220, 46);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Ingresso Fácil";
			// 
			// labelSubTitle
			// 
			this.labelSubTitle.AutoSize = true;
			this.labelSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelSubTitle.Location = new System.Drawing.Point(268, 97);
			this.labelSubTitle.Name = "labelSubTitle";
			this.labelSubTitle.Size = new System.Drawing.Size(243, 19);
			this.labelSubTitle.TabIndex = 1;
			this.labelSubTitle.Text = "SCI - Sistema de Compra de Ingressos";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(232, 224);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(352, 23);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(232, 273);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(352, 23);
			this.textBox2.TabIndex = 3;
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(168, 227);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(41, 15);
			this.labelEmail.TabIndex = 5;
			this.labelEmail.Text = "E-mail";
			// 
			// labelSenha
			// 
			this.labelSenha.AutoSize = true;
			this.labelSenha.Location = new System.Drawing.Point(168, 276);
			this.labelSenha.Name = "labelSenha";
			this.labelSenha.Size = new System.Drawing.Size(39, 15);
			this.labelSenha.TabIndex = 6;
			this.labelSenha.Text = "Senha";
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(350, 323);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(75, 23);
			this.buttonLogin.TabIndex = 7;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			// 
			// buttonCadastro
			// 
			this.buttonCadastro.Location = new System.Drawing.Point(620, 403);
			this.buttonCadastro.Name = "buttonCadastro";
			this.buttonCadastro.Size = new System.Drawing.Size(150, 23);
			this.buttonCadastro.TabIndex = 8;
			this.buttonCadastro.Text = "Fazer Cadastro Cliente";
			this.buttonCadastro.UseVisualStyleBackColor = true;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonCadastro);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.labelSenha);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.labelSubTitle);
			this.Controls.Add(this.labelTitle);
			this.Name = "LoginForm";
			this.Text = "Ingresso Fácil";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelSubTitle;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelSenha;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonCadastro;
	}
}