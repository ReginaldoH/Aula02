namespace Apresentacao
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.chkSexo = new System.Windows.Forms.CheckBox();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtLimiteCompra = new System.Windows.Forms.NumericUpDown();
            this.bntInseir = new System.Windows.Forms.Button();
            this.bntFechar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Limite Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Nascimento";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(76, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(279, 20);
            this.txtNome.TabIndex = 0;
            // 
            // chkSexo
            // 
            this.chkSexo.AutoSize = true;
            this.chkSexo.Location = new System.Drawing.Point(37, 96);
            this.chkSexo.Name = "chkSexo";
            this.chkSexo.Size = new System.Drawing.Size(50, 17);
            this.chkSexo.TabIndex = 2;
            this.chkSexo.Text = "Sexo";
            this.chkSexo.UseVisualStyleBackColor = true;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.CustomFormat = "dd/MM/yyyy ";
            this.txtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataNascimento.Location = new System.Drawing.Point(130, 69);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(200, 20);
            this.txtDataNascimento.TabIndex = 1;
            // 
            // txtLimiteCompra
            // 
            this.txtLimiteCompra.DecimalPlaces = 2;
            this.txtLimiteCompra.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtLimiteCompra.Location = new System.Drawing.Point(114, 125);
            this.txtLimiteCompra.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtLimiteCompra.Name = "txtLimiteCompra";
            this.txtLimiteCompra.Size = new System.Drawing.Size(120, 20);
            this.txtLimiteCompra.TabIndex = 3;
            this.txtLimiteCompra.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // bntInseir
            // 
            this.bntInseir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntInseir.Location = new System.Drawing.Point(12, 207);
            this.bntInseir.Name = "bntInseir";
            this.bntInseir.Size = new System.Drawing.Size(75, 23);
            this.bntInseir.TabIndex = 4;
            this.bntInseir.Text = "Inserir";
            this.bntInseir.UseVisualStyleBackColor = true;
            this.bntInseir.Click += new System.EventHandler(this.bntInseir_Click);
            // 
            // bntFechar
            // 
            this.bntFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntFechar.Location = new System.Drawing.Point(312, 207);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(75, 23);
            this.bntFechar.TabIndex = 5;
            this.bntFechar.Text = "Fechar";
            this.bntFechar.UseVisualStyleBackColor = true;
            this.bntFechar.Click += new System.EventHandler(this.bntFechar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 257);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bntFechar);
            this.Controls.Add(this.bntInseir);
            this.Controls.Add(this.txtLimiteCompra);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.chkSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox chkSexo;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        private System.Windows.Forms.NumericUpDown txtLimiteCompra;
        private System.Windows.Forms.Button bntInseir;
        private System.Windows.Forms.Button bntFechar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

