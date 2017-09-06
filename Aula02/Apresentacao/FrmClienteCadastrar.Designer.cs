namespace Apresentacao
{
    partial class FrmClienteCadastrar
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblLimiteCompra = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.rdbSexoMasculino = new System.Windows.Forms.RadioButton();
            this.rdbSexoFeminino = new System.Windows.Forms.RadioButton();
            this.txtLimiteCompra = new System.Windows.Forms.TextBox();
            this.btoSalvar = new System.Windows.Forms.Button();
            this.btoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 72);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(23, 117);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblDataNascimento.TabIndex = 4;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(23, 162);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo";
            // 
            // lblLimiteCompra
            // 
            this.lblLimiteCompra.AutoSize = true;
            this.lblLimiteCompra.Location = new System.Drawing.Point(23, 204);
            this.lblLimiteCompra.Name = "lblLimiteCompra";
            this.lblLimiteCompra.Size = new System.Drawing.Size(73, 13);
            this.lblLimiteCompra.TabIndex = 9;
            this.lblLimiteCompra.Text = "Limite Compra";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(23, 43);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(69, 20);
            this.txtIdCliente.TabIndex = 1;
            this.txtIdCliente.TabStop = false;
            this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(23, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataNascimento.Location = new System.Drawing.Point(23, 131);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(89, 20);
            this.txtDataNascimento.TabIndex = 5;
            // 
            // rdbSexoMasculino
            // 
            this.rdbSexoMasculino.AutoSize = true;
            this.rdbSexoMasculino.Checked = true;
            this.rdbSexoMasculino.Location = new System.Drawing.Point(23, 175);
            this.rdbSexoMasculino.Name = "rdbSexoMasculino";
            this.rdbSexoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbSexoMasculino.TabIndex = 7;
            this.rdbSexoMasculino.TabStop = true;
            this.rdbSexoMasculino.Text = "Masculino";
            this.rdbSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbSexoFeminino
            // 
            this.rdbSexoFeminino.AutoSize = true;
            this.rdbSexoFeminino.Location = new System.Drawing.Point(99, 175);
            this.rdbSexoFeminino.Name = "rdbSexoFeminino";
            this.rdbSexoFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbSexoFeminino.TabIndex = 8;
            this.rdbSexoFeminino.Text = "Feminino";
            this.rdbSexoFeminino.UseVisualStyleBackColor = true;
            // 
            // txtLimiteCompra
            // 
            this.txtLimiteCompra.Location = new System.Drawing.Point(23, 220);
            this.txtLimiteCompra.Name = "txtLimiteCompra";
            this.txtLimiteCompra.Size = new System.Drawing.Size(73, 20);
            this.txtLimiteCompra.TabIndex = 10;
            this.txtLimiteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btoSalvar
            // 
            this.btoSalvar.Location = new System.Drawing.Point(146, 276);
            this.btoSalvar.Name = "btoSalvar";
            this.btoSalvar.Size = new System.Drawing.Size(75, 23);
            this.btoSalvar.TabIndex = 11;
            this.btoSalvar.Text = "Salvar";
            this.btoSalvar.UseVisualStyleBackColor = true;
            this.btoSalvar.Click += new System.EventHandler(this.btoSalvar_Click);
            // 
            // btoCancelar
            // 
            this.btoCancelar.Location = new System.Drawing.Point(229, 276);
            this.btoCancelar.Name = "btoCancelar";
            this.btoCancelar.Size = new System.Drawing.Size(75, 23);
            this.btoCancelar.TabIndex = 12;
            this.btoCancelar.Text = "Cancelar";
            this.btoCancelar.UseVisualStyleBackColor = true;
            this.btoCancelar.Click += new System.EventHandler(this.btoCancelar_Click);
            // 
            // FrmClienteCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 311);
            this.Controls.Add(this.btoCancelar);
            this.Controls.Add(this.btoSalvar);
            this.Controls.Add(this.txtLimiteCompra);
            this.Controls.Add(this.rdbSexoFeminino);
            this.Controls.Add(this.rdbSexoMasculino);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblLimiteCompra);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblLimiteCompra;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        private System.Windows.Forms.RadioButton rdbSexoMasculino;
        private System.Windows.Forms.RadioButton rdbSexoFeminino;
        private System.Windows.Forms.TextBox txtLimiteCompra;
        private System.Windows.Forms.Button btoSalvar;
        private System.Windows.Forms.Button btoCancelar;
    }
}