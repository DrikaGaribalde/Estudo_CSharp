using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AbsolutaVeiculos
{
    class Marca
    {

        private Int32 cod_marca;
        private String nome_marca;
 
     public Int32 Cod_marca
        {
            get{return this.cod_marca;}
            set{this.cod_marca = value;}
        }      
        //
        public String Nome_marca
        {
            get{ return this.nome_marca;}
            set { this.nome_marca = value; }
        } 
        //
        public Marca()
        {

            this.nome_marca = "";
        }
        //
        public Marca(String nome_marca)
        {
            this.nome_marca = nome_marca;

        }
        // Método Inserir da tabela Marca
        public void Inserir()
        {
            String comandoSQL =
                "INSERT INTO Marca" + Environment.NewLine +
                "(" + Environment.NewLine +
                "    nome_marca" + Environment.NewLine +
                ")" + Environment.NewLine +
                "VALUES" + Environment.NewLine +
                "(" + Environment.NewLine +
                "    @nome_marca" + Environment.NewLine +
                ")";

            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@nome_marca", this.nome_marca);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro na inserção: " + ex.Message,
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                con.Fechar();
            }
        }
        // método PreencherTabela com a consulta na tabela Marca
        public void PreencherTabela(DataTable dataTable)
        {
            String comandoSQL =
                "SELECT" + Environment.NewLine +
                "    cod_marca As [Código da Marca]," + Environment.NewLine +
                "    nome_marca As [Nome da Marca]" + Environment.NewLine +
               
                "FROM" + Environment.NewLine +
                "    Marca ORDER BY Marca.nome_marca ";

            Conexao con = new Conexao();
            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);

                dataTable.Clear();

                dataAdapter.Fill(dataTable);
            }
            finally
            {
                con.Fechar();
            }
        }
        //
        // Método atualizar da tabela Marca
        public void Atualizar(Int32 cod_marca, String nome_marca)
        {
            String comandoSQL =
                "UPDATE" + Environment.NewLine +
                "    Marca" + Environment.NewLine +
                "SET" + Environment.NewLine +
                "    nome_marca = @nome_marca" + Environment.NewLine +
               
                "WHERE" + Environment.NewLine +
                "    (cod_marca = @cod_marca)";

            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@nome_marca", nome_marca);
                command.Parameters.AddWithValue("@cod_marca", cod_marca);
              
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro na alteração: " + ex.Message,
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                con.Fechar();
            }
        }
        //
        //Método excluir da tabela marca
        public void Excluir(Int32 cod_marca)
        {
            String comandoSQL =
                "DELETE FROM" + Environment.NewLine +
                "    Marca" + Environment.NewLine +
                "WHERE" + Environment.NewLine +
                "    (cod_marca = @cod_marca)";
            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@cod_marca", cod_marca);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro na exclusão: " + ex.Message,
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                con.Fechar();
            }
        }



    }

}