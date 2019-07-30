using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AbsolutaVeiculos
{
    class Fotos
    {

        private Int32 cod_foto;
        private String nome_cliente;
        private String nome_marca;
        private String nome_modelo;
        private String foto1;
        private String foto2;
        private String foto3;
        private String foto4;



        public Int32 Cod_Foto
        {
            get { return this.cod_foto; }
            set { this.cod_foto = value; }
        }
        public String Nome_Cliente
        {
            get { return this.nome_cliente; }
            set { this.nome_cliente = value; }
        }

        public String Nome_Marca
        {
            get { return this.nome_marca; }
            set { this.nome_marca = value; }
        }
        public String Nome_Modelo
        {
            get { return this.nome_modelo; }
            set { this.nome_modelo = value; }
        }
        //........
        public String Foto1
        {
            get { return this.foto1; }
            set { this.foto1 = value; }
        }
        public String Foto2
        {
            get { return this.foto2; }
            set { this.foto2 = value; }
        }
        public String Foto3
        {
            get { return this.foto3; }
            set { this.foto3 = value; }
        }
        public String Foto4
        {
            get { return this.foto4; }
            set { this.foto4 = value; }
        }

        //
        public Fotos()
        {
            this.nome_cliente = "";
            this.nome_marca   = "";
            this.nome_modelo  = "";
            this.foto1        = "";
            this.foto2        = "";
            this.foto3        = "";
            this.foto4        = "";

        }
        //
        public Fotos(String nome_cliente, String nome_marca, String nome_modelo, String foto1, String foto2, String foto3, String foto4)
        {
            this.nome_cliente = nome_cliente;
            this.nome_marca   = nome_marca;
            this.nome_modelo  = nome_modelo;
            this.foto1 = foto1;
            this.foto2 = foto2;
            this.foto3 = foto3;
            this.foto4 = foto4;
        }

        //
        // Método Inserir
        public void Inserir()
        {
            String comandoSQL =
                "INSERT INTO Foto" + Environment.NewLine +
                "(" + Environment.NewLine +
                "    nome_cliente," + Environment.NewLine +
                "    nome_marca,"   + Environment.NewLine +
                "    nome_modelo,"  + Environment.NewLine +
                "    foto1," + Environment.NewLine +
                "    foto2," + Environment.NewLine +
                "    foto3," + Environment.NewLine +
                "    foto4"  + Environment.NewLine +
                ")" + Environment.NewLine +
                "VALUES" + Environment.NewLine +
                "(" + Environment.NewLine +
                "    @nome_cliente," + Environment.NewLine +
                "    @nome_marca,"   + Environment.NewLine +
                "    @nome_modelo,"  + Environment.NewLine +
                "    @foto1," + Environment.NewLine +
                "    @foto2," + Environment.NewLine +
                "    @foto3," + Environment.NewLine +
                "    @foto4"  + Environment.NewLine +
                ")";
            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@nome_cliente", this.nome_cliente);
                command.Parameters.AddWithValue("@nome_marca", this.nome_marca);
                command.Parameters.AddWithValue("@nome_modelo", this.nome_modelo);
                command.Parameters.AddWithValue("@foto1", this.foto1);
                command.Parameters.AddWithValue("@foto2", this.foto2);
                command.Parameters.AddWithValue("@foto3", this.foto3);
                command.Parameters.AddWithValue("@foto4", this.foto4);


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
        // Prencher com dados da tabela Fotos
        public void PreencherTabela(DataTable dataTable)
        {
            String comandoSQL =
                "SELECT" + Environment.NewLine +
                "    cod_foto As [Código]," + Environment.NewLine +
                "    nome_cliente As [Nome cliente]," + Environment.NewLine +
                "    nome_marca As [Marca]," + Environment.NewLine +
                "    nome_modelo As [Modelo]," + Environment.NewLine +
                "    foto1 As [Foto 1]," + Environment.NewLine +
                "    foto2 As [Foto 2]," + Environment.NewLine +
                "    foto3 As [Foto 3]," + Environment.NewLine +
                "    foto4 As [Foto 4]" + Environment.NewLine +
                "FROM" + Environment.NewLine +
                "    Foto";
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
        // Método atualizar da tabela Foto

        public void Atualizar(Int32 cod_foto, String nome_cliente, String nome_marca, String nome_modelo, String foto1, String foto2, String foto3, String foto4)
        {
            String comandoSQL =
                "UPDATE" + Environment.NewLine +
                "    Foto" + Environment.NewLine +
                "SET" + Environment.NewLine +
                "    nome_cliente = @nome_cliente," + Environment.NewLine +
                "    nome_marca   = @nome_marca," + Environment.NewLine +
                "    nome_modelo  = @nome_modelo," + Environment.NewLine +
                "    foto1 = @foto1," + Environment.NewLine +
                "    foto2 = @foto2," + Environment.NewLine +
                "    foto3 = @foto3," + Environment.NewLine +
                "    foto4 = @foto4"  + Environment.NewLine +       
                "WHERE" + Environment.NewLine +
                "    (cod_foto = @cod_foto)";

            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@nome_cliente", nome_cliente);
                command.Parameters.AddWithValue("@nome_marca", nome_marca);
                command.Parameters.AddWithValue("@nome_modelo", nome_modelo);
                command.Parameters.AddWithValue("@foto1", foto1);
                command.Parameters.AddWithValue("@foto2", foto2);
                command.Parameters.AddWithValue("@foto3", foto3);
                command.Parameters.AddWithValue("@foto4", foto4);
                command.Parameters.AddWithValue("@cod_foto", cod_foto);

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
        // Método Excluir da tabela Fotos
        public void Excluir(Int32 cod_foto)
        {
            String comandoSQL =
                "DELETE FROM" + Environment.NewLine +
                "    Foto" + Environment.NewLine +
                "WHERE" + Environment.NewLine +
                "    (cod_foto = @cod_foto)";
            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@cod_foto", cod_foto);
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
        //
        //<<<<<<<<<<<<<<<<<<-------------------------
        // teste para implementar combo cliente
        //<<<<<<<<<<<<<<<<<-----------------------
        public void PreencherComboCliente(ComboBox comboBox1)
        {
            String comandoSQL =
                "SELECT" + Environment.NewLine +
                "cod_cliente," + Environment.NewLine +
                "nome " + Environment.NewLine +
                "FROM" + Environment.NewLine +
                "Cliente";
            //

            //
            Conexao con = new Conexao();
            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;


                OleDbDataReader dataReader = command.ExecuteReader();

                comboBox1.Items.Clear();

                while (dataReader.Read())
                {
                    comboBox1.Items.Add(dataReader["nome"].ToString());
                }

            }
            finally
            {
                con.Fechar();
            }
        }
        //<<<<<<<<<<<<<<<<<<--Fim comboCliente-----------------------
        //
        //<<<<<<<<<<<<<<<<<<-------------------------
        // teste para implementar combo Modelo
        //<<<<<<<<<<<<<<<<<-----------------------        
        public void PreencherComboModelo(ComboBox comboBox3)
        {
            String comandoSQL =
                "SELECT" + Environment.NewLine +
                "cod_modelo," + Environment.NewLine +
                "nome_modelo " + Environment.NewLine +
                "FROM" + Environment.NewLine +
                "Modelo";
            //

            //
            Conexao con = new Conexao();
            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;


                OleDbDataReader dataReader = command.ExecuteReader();

                comboBox3.Items.Clear();

                while (dataReader.Read())
                {
                    //comboBox.Items.Add(dataReader.GetString(0));
                    comboBox3.Items.Add(dataReader["nome_modelo"].ToString());
                }

            }
            finally
            {
                con.Fechar();
            }
        }
        //<<<<<<<<<<<<<<<<<<--Fim comboModelo-----------------------
       //
        //<<<<<<<<<<<<<<<<<<-------------------------
        // teste para implementar combo Marca
        //<<<<<<<<<<<<<<<<<-----------------------     
        public void PreencherCombo(ComboBox comboBox)
        {
            String comandoSQL =
                "SELECT" + Environment.NewLine +
                "cod_marca," + Environment.NewLine +
                "nome_marca " + Environment.NewLine +
                "FROM" + Environment.NewLine +
                "marca";
            //

            //
            Conexao con = new Conexao();
            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;


                OleDbDataReader dataReader = command.ExecuteReader();

                comboBox.Items.Clear();

                while (dataReader.Read())
                {
                    comboBox.Items.Add(dataReader["nome_marca"].ToString());
                }

            }
            finally
            {
                con.Fechar();
            }
        }
        //<<<<<<<<<<<<<<<<<<--Fim comboMarca-----------------------



    }
}
