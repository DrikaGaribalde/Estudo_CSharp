using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AbsolutaVeiculos
{
    public partial class FrmAutomovel : Form
    {
        private DataTable dataTable;
       

        public FrmAutomovel()
        {
            InitializeComponent();
        }

        private void MontarTabelaAutomovel()
        {
            Automovel a = new Automovel();
            a.PreencherTabela(dataTable);
        }
        
        //Teste preencher combobox Marca<<<<<<<<<<<<--------------------
        private void MontarComboAutomovel()
        {
            Automovel b = new Automovel();
            b.PreencherCombo(cmbMarca);            
        }
        //<<<<<<<<<<<<<<<----------------------------

        //Teste preencher combobox Cliente<<<<<<<<<<<<--------------------
        private void MontarComboCliente()
        {
            Automovel c = new Automovel();
            c.PreencherComboCliente(cmbCliente);
        }
        //<<<<<<<<<<<<<<<----------------------------

        //Teste preencher combobox Modelo<<<<<<<<<<<<--------------------
        private void PreencherComboModelo()
        {
            Automovel d = new Automovel();
            d.PreencherComboModelo(cmbModelo);
        }
        //<<<<<<<<<<<<<<<----------------------------
        private void FrmAutomovel_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();

            grdAutomovel.DataSource = dataTable;

            MontarTabelaAutomovel();

            //<------------------------------------------

            MontarComboAutomovel();

            //<------------------------------------------
            MontarComboCliente();

            //<------------------------------------------
            PreencherComboModelo();

            //<------------------------------------------
        }
        //

        private void CadastrarAutomovel()
        {
            Automovel a = new Automovel(Cliente.RetornarIdPeloNome(cmbCliente.Text), cmbMarca.Text, cmbModelo.Text, txtPlaca.Text, txtCombustivel.Text, cmbAno.Text, txtCor.Text, txtRenavam.Text);
            a.Inserir();
        }
        private void LimparCampos()
        {
            txtcodAutomovel.Clear();
            //cmbCliente.Items.Clear();
            //cmbAno.Items.Clear();
            //cmbMarca.Items.Clear();
            //cmbModelo.Items.Clear();
            
            txtCor.Clear();
            txtPlaca.Clear();
            txtRenavam.Clear();
            txtCombustivel.Clear();

           // cmbCliente.Select();
            
        }
        // TOPO *= Apartir daqui .!

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if ((txtCor.Text.Trim().Length > 0) &&
                 (txtPlaca.Text.Trim().Length > 0) &&
                 (txtRenavam.Text.Trim().Length > 0) &&
                 (txtCombustivel.Text.Trim().Length > 0) &&
                 (cmbAno.Text.Trim().Length > 0) &&
                 (cmbCliente.Text.Trim().Length > 0) &&
                 (cmbModelo.Text.Trim().Length > 0) &&
                 (cmbMarca.Text.Trim().Length > 0))
            {
                CadastrarAutomovel();

                MontarTabelaAutomovel();

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Há um ou mais campos sem conteúdo. Verifique!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
        //-----------------------------
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAutomovel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
        //--------------------------------

        private void ExcluirAutomovel()
        {
            Automovel a = new Automovel();
            a.Excluir(Convert.ToInt32(grdAutomovel.CurrentRow.Cells[0].Value));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((grdAutomovel.CurrentRow != null) && (txtcodAutomovel.Text.Trim().Length > 0))
            {
                ExcluirAutomovel();

                MontarTabelaAutomovel();

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Será necessário selecionar um registro. Verifique!",
                     "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //-------------------------------------------------
        private void AlterarAutomovel()
        {
            Automovel a = new Automovel();
            a.Atualizar(Int32.Parse(txtcodAutomovel.Text), Cliente.RetornarIdPeloNome(cmbCliente.Text), cmbMarca.Text, cmbModelo.Text, txtPlaca.Text, txtCombustivel.Text, cmbAno.Text, txtCor.Text, txtRenavam.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
              if ((grdAutomovel.CurrentRow != null) && (txtcodAutomovel.Text.Trim().Length > 0))
            {
                AlterarAutomovel();

                MontarTabelaAutomovel();

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Será necessário selecionar um registro. Verifique!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       //-------------------------------------------------------

        private void PreencherDadosAutomovel()
        {
            if (grdAutomovel.CurrentRow != null)
            {
                txtcodAutomovel.Text      = Convert.ToString(grdAutomovel.CurrentRow.Cells[grdAutomovel.Columns["Código"].Index].Value); 
                cmbCliente.SelectedIndex  = cmbCliente.Items.IndexOf(Cliente.RetornarNomePeloId(Convert.ToInt32(grdAutomovel.CurrentRow.Cells[grdAutomovel.Columns["Código do cliente"].Index].Value)));
                cmbMarca.SelectedIndex    = cmbMarca.Items.IndexOf(grdAutomovel.CurrentRow.Cells[grdAutomovel.Columns["Marca"].Index].Value);
                cmbModelo.SelectedIndex   = cmbModelo.Items.IndexOf(grdAutomovel.CurrentRow.Cells[grdAutomovel.Columns["Modelo"].Index].Value);
                txtCor.Text               = Convert.ToString(grdAutomovel.CurrentRow.Cells[grdAutomovel.Columns["Cor"].Index].Value);
                txtPlaca.Text             = Convert.ToString(grdAutomovel.CurrentRow.Cells[grdAutomovel.Columns["Placa"].Index].Value);
                txtRenavam.Text           = Convert.ToString(grdAutomovel.CurrentRow.Cells[grdAutomovel.Columns["Renavam"].Index].Value);
                cmbAno.Text               = Convert.ToString(grdAutomovel.CurrentRow.Cells[grdAutomovel.Columns["Ano"].Index].Value);
                txtCombustivel.Text       = Convert.ToString(grdAutomovel.CurrentRow.Cells[grdAutomovel.Columns["Combustível"].Index].Value);                
            }
        }        

        private void grdAutomovel_Click(object sender, EventArgs e)
        {
            PreencherDadosAutomovel();
        }        
    }
}