using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbsolutaVeiculos
{
    public partial class FrmCliente : Form
    {
        private DataTable dataTable;

        public FrmCliente()
        {
            InitializeComponent();
        }
        private void MontarTabelaPessoa()
        {
            Cliente p = new Cliente();

            p.PreencherTabela(dataTable);
        }

        // Método para redimensionar as colunas do grid de clientes
        private void RedimensionarGridCliente()
        {
            grdCliente.Columns["Código"].Width = 64;
            grdCliente.Columns["Nome completo"].Width = 196;
            grdCliente.Columns["E-mail"].Width = 196;
            grdCliente.Columns["Endereço"].Width = 128;
            grdCliente.Columns["Telefone"].Width = 128;
        }
        
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();

            grdCliente.DataSource = dataTable;

            MontarTabelaPessoa();
         //redimencionar grid
            RedimensionarGridCliente();
        }

        private void CadastrarPessoa()
        {
            Cliente p = new Cliente(txtNome.Text, txtEmail.Text,txtEndereco.Text, txtTelefone.Text);
            
            p.Inserir();
        }

        private void LimparCampos()
        {
            txtcodCliente.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();

            txtNome.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text.Trim().Length > 0) &&
                 (txtEndereco.Text.Trim().Length > 0) &&
                 (txtEmail.Text.Trim().Length > 0) &&
                 (txtTelefone.Text.Trim().Length > 0))
                
            {
                CadastrarPessoa();

                MontarTabelaPessoa();

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Há um ou mais campos sem conteúdo. Verifique!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }            

        }
        // Método Exclui
        private void ExcluirPessoa()
        {
            Cliente p = new Cliente();
            p.Excluir(Convert.ToInt32(grdCliente.CurrentRow.Cells[0].Value));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((grdCliente.CurrentRow != null) && (txtcodCliente.Text.Trim().Length > 0))
            {
                ExcluirPessoa();

                MontarTabelaPessoa();

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Será necessário selecionar um registro. Verifique!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Método alterar

        private void AlterarPessoa()
        {
            Cliente p = new Cliente();
            p.Atualizar(Convert.ToInt32(grdCliente.CurrentRow.Cells[0].Value), txtNome.Text, txtEmail.Text,txtEndereco.Text, txtTelefone.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if ((grdCliente.CurrentRow != null) && (txtcodCliente.Text.Trim().Length > 0))
            {
                AlterarPessoa();

                MontarTabelaPessoa();

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Será necessário selecionar um registro. Verifique!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Método para preencher dados 
        private void PreencherDadosPessoa()
        {
            if (grdCliente.CurrentRow != null)
            {
                txtcodCliente.Text = Convert.ToString(grdCliente.CurrentRow.Cells[grdCliente.Columns["Código"].Index].Value);
                txtNome.Text = Convert.ToString(grdCliente.CurrentRow.Cells[grdCliente.Columns["Nome completo"].Index].Value);
                txtEndereco.Text = Convert.ToString(grdCliente.CurrentRow.Cells[grdCliente.Columns["Endereço"].Index].Value);
                txtEmail.Text = Convert.ToString(grdCliente.CurrentRow.Cells[grdCliente.Columns["E-mail"].Index].Value);
                txtTelefone.Text = Convert.ToString(grdCliente.CurrentRow.Cells[grdCliente.Columns["Telefone"].Index].Value);
               
            }
        }

        private void grdCliente_Click(object sender, EventArgs e)
        {
            PreencherDadosPessoa();
        }

       
    }
}

       
      

    
