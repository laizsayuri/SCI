
namespace SCI_Views.Views
{
    partial class CadastroLocal
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
			this.textBoxCidade = new System.Windows.Forms.TextBox();
			this.textBoxEndereco = new System.Windows.Forms.TextBox();
			this.comboBoxEstado = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastrar Local";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cidade";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Estado";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Endereço";
			// 
			// textBoxCidade
			// 
			this.textBoxCidade.Location = new System.Drawing.Point(113, 64);
			this.textBoxCidade.Name = "textBoxCidade";
			this.textBoxCidade.Size = new System.Drawing.Size(281, 23);
			this.textBoxCidade.TabIndex = 4;
			// 
			// textBoxEndereco
			// 
			this.textBoxEndereco.Location = new System.Drawing.Point(113, 149);
			this.textBoxEndereco.Name = "textBoxEndereco";
			this.textBoxEndereco.Size = new System.Drawing.Size(281, 23);
			this.textBoxEndereco.TabIndex = 5;
			// 
			// comboBoxEstado
			// 
			this.comboBoxEstado.FormattingEnabled = true;
			this.comboBoxEstado.Location = new System.Drawing.Point(113, 107);
			this.comboBoxEstado.Name = "comboBoxEstado";
			this.comboBoxEstado.Size = new System.Drawing.Size(281, 23);
			this.comboBoxEstado.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(338, 210);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Salvar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(257, 210);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// CadastroLocal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 245);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBoxEstado);
			this.Controls.Add(this.textBoxEndereco);
			this.Controls.Add(this.textBoxCidade);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CadastroLocal";
			this.Text = "Cadastrar Local";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCidade;
		private System.Windows.Forms.TextBox textBoxEndereco;
		private System.Windows.Forms.ComboBox comboBoxEstado;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}