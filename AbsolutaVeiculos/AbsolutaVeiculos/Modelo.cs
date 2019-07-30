using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AbsolutaVeiculos
{
    class Modelo
    {
        private Int32 cod_modelo;
        private String nome_modelo;

 
     public Int32 Cod_modelo
        {
            get{return this.cod_modelo;}
            set{this.cod_modelo = value;}
        }
            
        public String Nome_modelo
        {
            get{ return this.nome_modelo;}
            set { this.nome_modelo = value; }
        } 
        public Modelo()
        {

            this.nome_modelo = "";
        }
        //
        public Modelo(String nome_modelo)
        {
            this.nome_modelo = nome_modelo;

        }
        // Método Inserir da tabela Marca
        public void Inserir()
        {
            String comandoSQL =
                "INSERT INTO Modelo" + Environment.NewLine +
                "(" + Environment.NewLine +
                "    nome_modelo" + Environment.NewLine +
                ")" + Environment.NewLine +
                "VALUES" + Environment.NewLine +
                "(" + Environment.NewLine +
                "    @nome_modelo" + Environment.NewLine +
                ")";

            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@nome_modelo", this.nome_modelo);

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
        // método PreencherTabela com a consulta na tabela Modelo
        public void PreencherTabela(DataTable dataTable)
        {
            String comandoSQL =
                "SELECT" + Environment.NewLine +
                "    cod_modelo As [Código do Modelo]," + Environment.NewLine +
                "    nome_modelo As [Nome do Modelo]" + Environment.NewLine +
               
                "FROM" + Environment.NewLine +
                "    Modelo ORDER BY Modelo.nome_modelo";

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
        // Método atualizar da tabela Modelo
        public void Atualizar(Int32 cod_modelo, String nome_modelo)
        {
            String comandoSQL =
                "UPDATE" + Environment.NewLine +
                "    Modelo" + Environment.NewLine +
                "SET" + Environment.NewLine +
                "    nome_modelo = @nome_modelo" + Environment.NewLine +
               
                "WHERE" + Environment.NewLine +
                "    (cod_modelo = @cod_modelo)";

            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@nome_modelo", nome_modelo);
                command.Parameters.AddWithValue("@cod_modelo", cod_modelo);
              
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
        //Método excluir da tabela Modelo
        public void Excluir(Int32 cod_modelo)
        {
            String comandoSQL =
                "DELETE FROM" + Environment.NewLine +
                "    Modelo" + Environment.NewLine +
                "WHERE" + Environment.NewLine +
                "    (cod_modelo = @cod_modelo)";
            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@cod_modelo", cod_modelo);
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
