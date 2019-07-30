using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AbsolutaVeiculos
{
    class Cliente   
    {
        private Int32 cod_cliente;
        private String nome;
        private String email;
        private String endereco;
        private String telefone;
       

        public Int32 Cod_cliente
        {
            get{return this.cod_cliente;}
            set{this.cod_cliente = value;}
        }
        
        public String Nome
        {
            get{return this.nome;}
            set {this.nome = value;}
        }

        public String Email
        {
            get {return this.email;}
            set{ this.email = value;}
        }
        public String Endereco
        {
            get{return this.endereco;}
            set{this.endereco = value;}
        }
       
        public String Telefone
        {
            get{return this.telefone;}
            set{this.telefone = value;}
        }


        public Cliente()
        {            
            this.nome = "";
            this.email = "";
            this.endereco = "";
            this.telefone = "";            
        }
        
        public Cliente(String nome, String email, String endereco, String telefone)
        {            
            this.nome = nome;
            this.email = email;
            this.endereco = endereco;
            this.telefone = telefone;
            
        }
      
        public void Inserir()
        {            
            String comandoSQL = 
                "INSERT INTO Cliente" + Environment.NewLine +
                "(" + Environment.NewLine +
                "    nome," + Environment.NewLine +
                "    email," + Environment.NewLine +
                "    endereco," + Environment.NewLine +
                "    telefone" + Environment.NewLine +
                ")" + Environment.NewLine +
                "VALUES" + Environment.NewLine +
                "(" + Environment.NewLine +
                "    @nome," + Environment.NewLine +
                "    @email," + Environment.NewLine +
                "    @endereco," + Environment.NewLine +
                "    @telefone" + Environment.NewLine +
                ")";
                        
            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;
                                
                command.Parameters.AddWithValue("@nome", this.nome);
                command.Parameters.AddWithValue("@email", this.email);
                command.Parameters.AddWithValue("@endereco", this.endereco);
                command.Parameters.AddWithValue("@telefone", this.email);
                
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
        
        public void PreencherTabela(DataTable dataTable)
        {                        
            String comandoSQL =
                "SELECT" + Environment.NewLine +
                "    cod_cliente As [Código]," + Environment.NewLine +
                "    nome As [Nome completo]," + Environment.NewLine +
                "    email As [E-mail]," + Environment.NewLine +
                "    endereco As [Endereço]," + Environment.NewLine +
                "    telefone As [Telefone]" + Environment.NewLine+
                "FROM" + Environment.NewLine +
                "  Cliente";
            
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

        public void Atualizar(Int32 cod_cliente, String nome, String email, String endereco, String telefone)
        {
            String comandoSQL =
                "UPDATE" + Environment.NewLine +
                "Cliente" + Environment.NewLine +
                "SET" + Environment.NewLine +
                "    nome = @nome," + Environment.NewLine +
                "    email = @email," + Environment.NewLine +
                "    endereco = @endereco," + Environment.NewLine +
                "    telefone = @telefone" + Environment.NewLine +
                "WHERE" + Environment.NewLine +
                "    (cod_cliente = @cod_cliente)";

            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@endereco", endereco); 
                command.Parameters.AddWithValue("@telefone", telefone);
                command.Parameters.AddWithValue("@cod_cliente",cod_cliente);

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

        public void Excluir(Int32 cod_cliente)
        {
            String comandoSQL =
                "DELETE FROM" + Environment.NewLine +
                "    Cliente" + Environment.NewLine +                
                "WHERE" + Environment.NewLine +
                "    (cod_cliente = @cod_cliente)";

            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@cod_cliente", cod_cliente);

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

        // Método Retornar Nome pelo Id        
        public static String RetornarNomePeloId(Int32 cod_cliente)
        {
            String nomeCliente = "";
            String comandoSQL =
               "SELECT" + Environment.NewLine +
               "    nome" + Environment.NewLine +
               "FROM" + Environment.NewLine +
               "    Cliente" + Environment.NewLine +
               "Where" + Environment.NewLine +
               "    (cod_cliente = @cod_cliente)";

            Conexao con = new Conexao();
            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@cod_cliente", cod_cliente);

                OleDbDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    nomeCliente = dataReader.GetString(0);
                }
            }
            finally
            {
                con.Fechar();
            }

            return nomeCliente;
        }

        // Método Retornas Id pelo Nome
        public static Int32 RetornarIdPeloNome(String nome)
        {
            Int32 codCliente = 0;
            String comandoSQL =
               "SELECT" + Environment.NewLine +
               "    cod_cliente" + Environment.NewLine +
               "FROM" + Environment.NewLine +
               "    Cliente" + Environment.NewLine +
               "Where" + Environment.NewLine +
               "    (nome = @nome)";

            Conexao con = new Conexao();
            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@nome", nome);

                OleDbDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    codCliente = dataReader.GetInt32(0);
                }
            }
            finally
            {
                con.Fechar();
            }

            return codCliente;
        }
    }
}
