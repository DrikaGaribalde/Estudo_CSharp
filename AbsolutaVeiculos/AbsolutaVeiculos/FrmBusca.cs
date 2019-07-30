using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AbsolutaVeiculos
{
    public partial class FrmBusca : Form
    {
        private DataTable dataTable;
        
        // <<--teste para imagens
        private TextBox textBoxAtual;
        private PictureBox pictureBoxAtual;
        // 

        public FrmBusca()
        {
            InitializeComponent();
        }
        //
        private void MontarTabelaFoto()
        {
            Fotos p = new Fotos();

            p.PreencherTabela(dataTable);
        }
        // <---------------- Preenche o combo do cliente com as informações da tabela de clientes
        private void MontarComboCliente()
        {
            Automovel c = new Automovel();
            c.PreencherComboCliente(cmbCliente);
        }
        // <----------------////////////////////////////////////
        //
        //Teste preencher combobox Modelo<<<<<<<<<<<<--------------------
        private void PreencherComboModelo()
        {
            Automovel d = new Automovel();
            d.PreencherComboModelo(cmbModelo);
        }
        //<<<<<<<<<<<<<<<----------------------------

        //Teste preencher combobox Marca<<<<<<<<<<<<--------------------
        private void MontarComboAutomovel()
        {
            Automovel b = new Automovel();
            b.PreencherCombo(cmbMarca);
        }
        //<<<<<<<<<<<<<<<----------------------------

        private void FrmBusca_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();

            grdFoto.DataSource = dataTable;

            MontarTabelaFoto();     //<<---- Grid

            //<------------------------------------------
            MontarComboCliente();   //<<---- Cliente

            //<------------------------------------------
            PreencherComboModelo(); //<<---- Modelo

            //<------------------------------------------
            MontarComboAutomovel(); //<<---- Marca

            //<------------------------------------------
        }
        //
        private void CadastrarFoto()
        {
            Fotos p = new Fotos (cmbCliente.Text, cmbMarca.Text,cmbModelo.Text, txtCaminhoImagem1.Text, txtCaminhoImagem2.Text,txtCaminhoImagem3.Text,txtCaminhoImagem4.Text);

            p.Inserir();
        }
        // Método que limpa campos do formulário e coloca o foco no campo do cliente
        private void LimparCampos()
        {
            txtCaminhoImagem1.Clear();
            txtCaminhoImagem2.Clear();
            txtCaminhoImagem3.Clear();
            txtCaminhoImagem4.Clear();

            //<< --- limpar as imagens
            picImagem1.Image = null;
            picImagem2.Image = null;
            picImagem3.Image = null;
            picImagem4.Image = null;
            //

            cmbCliente.Focus();
        }
        
        // Código botão inserir verifica se os campos estão preenchidos
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if ((cmbCliente.Text.Trim().Length > 0) &&
                (cmbMarca.Text.Trim().Length > 0) &&
                (cmbModelo.Text.Trim().Length > 0) &&
                (txtCaminhoImagem1.Text.Trim().Length > 0) &&
                (txtCaminhoImagem2.Text.Trim().Length > 0) &&
                (txtCaminhoImagem3.Text.Trim().Length > 0) &&
                (txtCaminhoImagem4.Text.Trim().Length > 0))
            {
                CadastrarFoto();

                MontarTabelaFoto();

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
            Close();
        }

        private void FrmBusca_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }            
        }       
        //
        //Botão para excluir o registro da tabela do cadastro de fotos
        private void ExcluirFoto()
        {
            Fotos p = new Fotos();
            p.Excluir(Convert.ToInt32(grdFoto.CurrentRow.Cells[0].Value));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((grdFoto.CurrentRow != null) && (txtCodFoto.Text.Trim().Length > 0))
            {
                ExcluirFoto();

                MontarTabelaFoto();

                LimparCampos(); 
            }
            else
            {
                MessageBox.Show("Será necessário selecionar um registro. Verifique!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //
        //Botão para alterar o registro da tabela do campo de fotos
        private void AlterarFoto()
        {
            Fotos p = new Fotos();
            p.Atualizar(Convert.ToInt32(grdFoto.CurrentRow.Cells[0].Value), cmbCliente.Text, cmbMarca.Text,cmbModelo.Text, txtCaminhoImagem1.Text, txtCaminhoImagem2.Text, txtCaminhoImagem3.Text,txtCaminhoImagem4.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if ((grdFoto.CurrentRow != null) && (txtCodFoto.Text.Trim().Length > 0))
            {
                AlterarFoto();

                MontarTabelaFoto();

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
        private void PreencherDadosFoto()
        {
            if (grdFoto.CurrentRow != null)
            {
                txtCodFoto.Text = Convert.ToString(grdFoto.CurrentRow.Cells[grdFoto.Columns["Código"].Index].Value);
                cmbCliente.Text = Convert.ToString(grdFoto.CurrentRow.Cells[grdFoto.Columns["Nome cliente"].Index].Value);
                cmbMarca.Text = Convert.ToString(grdFoto.CurrentRow.Cells[grdFoto.Columns["Marca"].Index].Value);
                cmbModelo.Text = Convert.ToString(grdFoto.CurrentRow.Cells[grdFoto.Columns["Modelo"].Index].Value);
                txtCaminhoImagem1.Text = Convert.ToString(grdFoto.CurrentRow.Cells[grdFoto.Columns["Foto 1"].Index].Value);
                txtCaminhoImagem2.Text = Convert.ToString(grdFoto.CurrentRow.Cells[grdFoto.Columns["Foto 2"].Index].Value);
                txtCaminhoImagem3.Text = Convert.ToString(grdFoto.CurrentRow.Cells[grdFoto.Columns["Foto 3"].Index].Value);
                txtCaminhoImagem4.Text = Convert.ToString(grdFoto.CurrentRow.Cells[grdFoto.Columns["Foto 4"].Index].Value);
         
            }
            // mostrar as imagens quando carregar o grid com os dados do cliente;
            picImagem1.ImageLocation = txtCaminhoImagem1.Text;
            picImagem2.ImageLocation = txtCaminhoImagem2.Text;
            picImagem3.ImageLocation = txtCaminhoImagem3.Text;
            picImagem4.ImageLocation = txtCaminhoImagem4.Text;
        }

        private void grdFoto_Click(object sender, EventArgs e)
        {
            PreencherDadosFoto();
        }
        // <<---testando para colocar as imagens

        private void LimparImagem(TextBox textBox, PictureBox pictureBox)
        {
            if (!File.Exists(textBox.Text))
            {
                pictureBox.Image = null;
            }
        }
        //

        private void VerificarExistenciaCaminhoImagem(TextBox textBox)
        {
            if ((textBox.Text.Trim().Length != 0) & (!File.Exists(textBox.Text)))
            {
                if (MessageBox.Show("O caminho da imagem informada não existe. Deseja corrigí-lo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    textBox.Focus();
                }
                else
                {
                    textBox.Clear();
                }
            }
        }

        private void dlgCaminhoImagem_FileOk(object sender, CancelEventArgs e)
        {
            textBoxAtual.Text = dlgCaminhoImagem.FileName;
            pictureBoxAtual.ImageLocation = textBoxAtual.Text;
        }
        //---------------------------- verifica o caminho para as imagens
        private void txtCaminhoImagem1_Leave(object sender, EventArgs e)
        {
            VerificarExistenciaCaminhoImagem(txtCaminhoImagem1);
            LimparImagem(txtCaminhoImagem1, picImagem1);
        }

        private void txtCaminhoImagem2_Leave(object sender, EventArgs e)
        {
            VerificarExistenciaCaminhoImagem(txtCaminhoImagem2);
            LimparImagem(txtCaminhoImagem2, picImagem2);

        }
        private void txtCaminhoImagem3_Leave(object sender, EventArgs e)
        {
            VerificarExistenciaCaminhoImagem(txtCaminhoImagem3);
            LimparImagem(txtCaminhoImagem3, picImagem3);

        }

        private void txtCaminhoImagem4_Leave(object sender, EventArgs e)
        {
            VerificarExistenciaCaminhoImagem(txtCaminhoImagem4);
            LimparImagem(txtCaminhoImagem4, picImagem4);
        }
        //----------------------------- fim de verificação
        //
        //----------------------------<< botão de pesquisa
        private void btnPesquisa1_Click(object sender, EventArgs e)
        {
            textBoxAtual = txtCaminhoImagem1;
            pictureBoxAtual = picImagem1;
            dlgCaminhoImagem.ShowDialog();
        }

        private void btnPesquisa2_Click(object sender, EventArgs e)
        {
            textBoxAtual = txtCaminhoImagem2;
            pictureBoxAtual = picImagem2;
            dlgCaminhoImagem.ShowDialog();
        }

        private void btnPesquisa3_Click(object sender, EventArgs e)
        {
            textBoxAtual = txtCaminhoImagem3;
            pictureBoxAtual = picImagem3;
            dlgCaminhoImagem.ShowDialog();
        }

        private void btnPesquisa4_Click(object sender, EventArgs e)
        {
            textBoxAtual = txtCaminhoImagem4;
            pictureBoxAtual = picImagem4;
            dlgCaminhoImagem.ShowDialog();
        }
        //----------------------------<< fim de pesquisa
       

        

       
    }
}
