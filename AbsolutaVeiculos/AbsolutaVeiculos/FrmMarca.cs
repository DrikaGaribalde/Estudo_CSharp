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
    public partial class FrmMarca : Form
    {
        private DataTable dataTable;


        public FrmMarca()
        {
            InitializeComponent();
        }

        private void MontarTabelaMarca()
        {
            Marca p = new Marca();

            p.PreencherTabela(dataTable);
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();

            grdMarca.DataSource = dataTable;

            MontarTabelaMarca();

        }
        //------------> Inserir <----------------
        private void CadastrarMarca()
        {
            Marca p = new Marca(txtnomeMarca.Text);

            p.Inserir();
        }
        private void LimparCampos()
        {
            txtcodMarca.Clear();
            txtnomeMarca.Clear();
            
            txtnomeMarca.Focus();
        }
        //
        // Botão inserir da tabela Marca
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if ((txtnomeMarca.Text.Trim().Length > 0))
            {
                CadastrarMarca();

                MontarTabelaMarca();

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Há um ou mais campos sem conteúdo. Verifique!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
        // ---------- Fechar ----------------
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMarca_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }            
        }

        //------------> Excluir <----------------------
        private void ExcluirMarca()
        {
            Marca p = new Marca();
            p.Excluir(Convert.ToInt32(grdMarca.CurrentRow.Cells[0].Value));
        }
        //
        // Botão Excluir da tabela Marca
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((grdMarca.CurrentRow != null) && (txtcodMarca.Text.Trim().Length > 0))
            {
                ExcluirMarca();

                MontarTabelaMarca();

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Será necessário selecionar um registro. Verifique!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        //
        //--------------> Alterar <-----------------

        private void AlterarMarca()
        {
            Marca p = new Marca();
            p.Atualizar(Convert.ToInt32(grdMarca.CurrentRow.Cells[0].Value), txtnomeMarca.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if ((grdMarca.CurrentRow != null) && (txtcodMarca.Text.Trim().Length > 0))
            {
                AlterarMarca();

                MontarTabelaMarca();

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Será necessário selecionar um registro. Verifique!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //
        //
        private void PreencherDadosMarca()
        {
            if (grdMarca.CurrentRow != null)
            {
                txtcodMarca.Text = Convert.ToString(grdMarca.CurrentRow.Cells[grdMarca.Columns["Código da Marca"].Index].Value);
                txtnomeMarca.Text = Convert.ToString(grdMarca.CurrentRow.Cells[grdMarca.Columns["Nome da Marca"].Index].Value);
            }
        }

        private void grdMarca_Click(object sender, EventArgs e)
        {
            PreencherDadosMarca();
        }




      
       



    }
}
