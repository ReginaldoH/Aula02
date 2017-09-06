using Negocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bntInseir_Click(object sender, EventArgs e)
        {

            try
            {
                ClienteNegocio clienetNegocio = new ClienteNegocio();

                Cliente cliente = new Cliente();
                cliente.Nome = txtNome.Text;
                cliente.LimiteCompra = txtLimiteCompra.Value;
                cliente.DataNascimento = txtDataNascimento.Value;
                cliente.Sexo = chkSexo.Checked;
                
                decimal retorno = clienetNegocio.inserir(cliente);

                cliente.IdCliente = (int)retorno;
                MessageBox.Show("Cadastro efetuado com Sucesso!!!");
            }


            catch (Exception ex)
            {
                //salva log
                MessageBox.Show("Falha ao inserir contacte o admin do sistema: " + ex.Message);
            }

        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
