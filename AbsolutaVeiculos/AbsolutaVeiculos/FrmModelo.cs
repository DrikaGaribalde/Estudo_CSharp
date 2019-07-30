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
    public partial class FrmModelo : Form
    {
        private DataTable dataTable;
        //
        public FrmModelo()
        {
            InitializeComponent();
        }
        //
        private void MontarTabelaModelo()
        {
            Modelo p = new Modelo();

            p.PreencherTabela(dataTable);
        }

        private void FrmModelo_Load(object sender, System.EventArgs e)
        {
            dataTable = new DataTable();

            grdModelo.DataSource = dataTable;

            MontarTabelaModelo();

        }
        //
        private void LimparCampos()
        {
            txtcodModelo.Clear();
            txtnomeModelo.Clear();


            txtnomeModelo.Focus();
        }       

        // Botão inserir da tabela Modelo
        private void CadastrarModelo()
        {
            Modelo p = new Modelo(txtnomeModelo.Text);

            p.Inserir();
        }

        private void btnInserir_Click(object sender, System.EventArgs e)
        {
            if ((txtnomeModelo.Text.Trim().Length > 0))
            {
                CadastrarModelo();

                MontarTabelaModelo();

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Há um ou mais campos sem conteúdo. Verifique!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
        // Botão fechar
        private void btnFechar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FrmModelo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }            
        }
        //
        // Boatão excluir da tabela Modelo
        private void ExcluirModelo()
        {
            Modelo p = new Modelo();
            p.Excluir(Convert.ToInt32(grdModelo.CurrentRow.Cells[0].Value));
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            if ((grdModelo.CurrentRow != null) && (txtcodModelo.Text.Trim().Length > 0))
            {
                ExcluirModelo();

                MontarTabelaModelo();

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Será necessário selecionar um registro. Verifique!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //
        // Botão Alterar da tabela Modelo
        private void AlterarModelo()
        {
            Modelo p = new Modelo();
            p.Atualizar(Convert.ToInt32(grdModelo.CurrentRow.Cells[0].Value), txtnomeModelo.Text);
        }

        private void btnAlterar_Click(object sender, System.EventArgs e)
        {
            if ((grdModelo.CurrentRow != null) && (txtcodModelo.Text.Trim().Length > 0))
            {
                AlterarModelo();

                MontarTabelaModelo();

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Será necessário selecionar um registro. Verifique!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //
        // Método PreencherDadosModelo
        private void PreencherDadosModelo()
        {
            if (grdModelo.CurrentRow != null)
            {
                txtcodModelo.Text = Convert.ToString(grdModelo.CurrentRow.Cells[grdModelo.Columns["Código do Modelo"].Index].Value);
                txtnomeModelo.Text = Convert.ToString(grdModelo.CurrentRow.Cells[grdModelo.Columns["Nome do Modelo"].Index].Value);
            }
        }

        private void grdModelo_Click(object sender, System.EventArgs e)
        {
            PreencherDadosModelo();
        }





        
    }
}
