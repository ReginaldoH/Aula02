using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmClienteCadastrar : Form
    {
        AcaoNaTela acaoTelaSelecionada;

        //Construtor
        public FrmClienteCadastrar(AcaoNaTela acaoNaTela, Cliente cliente)
        {
            InitializeComponent();

            this.acaoTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Cliente";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Cliente";

                this.txtIdCliente.Text = cliente.IdCliente.ToString();
                this.txtNome.Text = cliente.Nome;
                this.txtDataNascimento.Value = cliente.DataNascimento;
                if (cliente.Sexo == true)//Masculino
                    this.rdbSexoMasculino.Checked = true;
                else
                    this.rdbSexoFeminino.Checked = true;
               this.txtLimiteCompra.Text = cliente.LimiteCompra.ToString();

            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Cliente";

                this.txtIdCliente.Text = cliente.IdCliente.ToString();
                this.txtNome.Text = cliente.Nome;
                this.txtDataNascimento.Value = cliente.DataNascimento;
                if (cliente.Sexo == true)//Masculino
                    this.rdbSexoMasculino.Checked = true;
                else
                    this.rdbSexoFeminino.Checked = true;
                this.txtLimiteCompra.Text = cliente.LimiteCompra.ToString();

                //Travar os Campos para Consulta
                this.txtNome.ReadOnly = true;
                this.txtNome.TabStop = false;

                this.txtDataNascimento.Enabled = false;
                this.txtDataNascimento.TabStop = false;

                this.rdbSexoMasculino.Enabled = false;
                this.rdbSexoFeminino.Enabled = false;

                this.txtLimiteCompra.ReadOnly = true;
                this.txtLimiteCompra.TabStop = false;

                this.btoSalvar.Visible = false;
                this.btoCancelar.Text = "Fechar";
                this.btoCancelar.Focus();
            }

        }

        private void btoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btoSalvar_Click(object sender, EventArgs e)
        {
            //Verificar se eh Insercao ou Alteracao
            if (acaoTelaSelecionada == AcaoNaTela.Inserir)
            {
                Cliente cliente = new Cliente();
                cliente.Nome = txtNome.Text;
                cliente.DataNascimento = txtDataNascimento.Value;
                if (this.rdbSexoMasculino.Checked == true)//Masculino
                    cliente.Sexo = true;
                else
                    cliente.Sexo = false;

                cliente.LimiteCompra = Convert.ToDecimal(txtLimiteCompra.Text);

                ClienteNegocios clienteNegocios = new ClienteNegocios();

                string retorno = clienteNegocios.inserir(cliente);

                try
                {
                    int idcliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente inserido com Sucesso. Codigo: " + idcliente.ToString());
                    //FEcha a Tela e Retorna Resultado Yes
                    this.DialogResult = DialogResult.Yes;
                }
                catch (Exception)
                {
                    MessageBox.Show("Nao foi possivel Inseir. Detalhes: " + retorno, "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //FEcha a Tela e Retorna Resultado no
                    this.DialogResult = DialogResult.No;
                }
            }

            if (acaoTelaSelecionada == AcaoNaTela.Alterar)
            {
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                    cliente.Nome = txtNome.Text;
                    cliente.DataNascimento = txtDataNascimento.Value;
                    if (this.rdbSexoMasculino.Checked == true)//Masculino
                        cliente.Sexo = true;
                    else
                        cliente.Sexo = false;

                    cliente.LimiteCompra = Convert.ToDecimal(txtLimiteCompra.Text);

                    ClienteNegocios clienteNegocios = new ClienteNegocios();

                    string retorno = clienteNegocios.alterar(cliente);

                    try
                    {
                        int idcliente = Convert.ToInt32(retorno);
                        MessageBox.Show("Cliente alterado com Sucesso. Codigo: " + idcliente.ToString());
                        //FEcha a Tela e Retorna Resultado Yes
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nao foi possivel alterar. Detalhes: " + retorno, "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //FEcha a Tela e Retorna Resultado no
                        this.DialogResult = DialogResult.No;
                    }
                }
        }
    }
}
