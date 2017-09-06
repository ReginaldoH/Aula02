using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmClienteSelecionar : Form
    {
        public FrmClienteSelecionar()
        {
            InitializeComponent();
            //Nao gerar dataGridViewPrincipal
            dataGridViewPrincipal.AutoGenerateColumns = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGride();
        }

        private void AtualizarGride()
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();

            ClienteColecao clienteColecao = new ClienteColecao();
            clienteColecao = clienteNegocios.consultarPorNome(txtPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = clienteColecao;

            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificar se tem algum registro selecionado
            if (dataGridViewPrincipal.SelectedRows.Count ==0)
            {
                MessageBox.Show("Nenhum Cliente selecionado!!!");
                return;
            }
            //Perguntar se Realmemte quer excluir
            DialogResult resutado = MessageBox.Show("Deseja Realmente Excluir o Cliente", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resutado == DialogResult.No)
            {
                return;
            }
            //Pegar Cliente Selecionado
            Cliente clienteSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);
            //Instanciar regra negocios
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            string retorno = clienteNegocios.excluir(clienteSelecionado);

            //Verificar se excluiu com sucesso
            // Se o retorno for numero eh porque deu certo senao ocorreu um erro
            try
            {
                int idcliente = Convert.ToInt32(retorno);
                MessageBox.Show("Cliente Excluido com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGride();
            }
            catch
            {
                MessageBox.Show("Nao foi possivel excluir. Detalhes: " + retorno, "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Instanciar formulario Cadastro
            FrmClienteCadastrar frmClienteCadastro = new FrmClienteCadastrar(AcaoNaTela.Inserir, null);

            DialogResult dialogResult = frmClienteCadastro.ShowDialog();
            if(dialogResult == DialogResult.Yes)
            {
                AtualizarGride();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Verificar se tem algum registro selecionado
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado!!!");
                return;
            }

            //Pegar Cliente Selecionado
            Cliente clienteSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            FrmClienteCadastrar frmClienteCadastro = new FrmClienteCadastrar(AcaoNaTela.Alterar, clienteSelecionado);

            DialogResult dialogResult = frmClienteCadastro.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGride();
            }
        }

        private void btnConsutar_Click(object sender, EventArgs e)
        {
            //Verificar se tem algum registro selecionado
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado!!!");
                return;
            }

            //Pegar Cliente Selecionado
            Cliente clienteSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            FrmClienteCadastrar frmClienteCadastro = new FrmClienteCadastrar(AcaoNaTela.Consultar, clienteSelecionado);
            frmClienteCadastro.ShowDialog();
        }
    }
}
