using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AbsolutaVeiculos
{
    class Automovel
    {        
        private Int32 cod_automovel;
        private Int32 cod_cliente;
        private String marca;
        private String modelo;
        private String placa;
        private String combustivel;
        private String ano;
        private String cor;
        private String renavam;

        public Int32 Cod_automovel
        {
            get{return this.cod_automovel;}
            set{this.cod_automovel = value;}
        }      
        //
        public Int32 Cod_cliente
        {
            get{ return this.cod_cliente;}
            set{this.cod_cliente = value;}
        } 
        //
        //
        public String Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }
        //
        public String Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }
        
        //
        public String Placa
        {
            get { return this.placa; }
            set { this.placa = value; }
        }
        //
        //
        public String Combustivel
        {
            get { return this.combustivel; }
            set { this.placa = value; }
        }
        //
        //
        public String Ano
        {
            get { return this.ano; }
            set { this.ano = value; }
        }
        //
        //
        public String Cor
        {
            get { return this.cor; }
            set { this.cor = value; }
        }
        // //
        public String Renavam
        {
            get { return this.renavam; }
            set { this.renavam = value; }
        }
        //

        public Automovel()
        {
            this.cod_cliente = 0;
            this.marca = "";
            this.modelo = "";
            this.placa = "";
            this.combustivel = "";
            this.ano = "";
            this.cor = "";
            this.renavam = "";
       
        }

        public Automovel(Int32 cod_cliente, String marca, String modelo, String placa, String combustivel, String ano, String cor, String renavam)
        {
            this.cod_cliente = cod_cliente;
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.combustivel = combustivel;
            this.ano = ano;
            this.cor = cor;
            this.renavam = renavam;
        }

        public void Inserir()
        {
            String comandoSQL =
                "INSERT INTO Automovel" + Environment.NewLine +
                "(" + Environment.NewLine +
                "    cod_cliente," + Environment.NewLine +
                "    marca," + Environment.NewLine +
                "    modelo," + Environment.NewLine +
                "    placa," + Environment.NewLine +
                "    combustivel," + Environment.NewLine +
                "    ano," + Environment.NewLine +
                "    cor," + Environment.NewLine +
                "    renavam " + Environment.NewLine +                
                ")" + Environment.NewLine +
                "VALUES" + Environment.NewLine +
                "(" + Environment.NewLine +
                "    @cod_cliente," + Environment.NewLine +
                "    @marca," + Environment.NewLine +
                "    @modelo," + Environment.NewLine +
                "    @placa, " + Environment.NewLine +
                "    @combustivel, " + Environment.NewLine +
                "    @ano, " + Environment.NewLine +
                "    @cor, " + Environment.NewLine +
                "    @renavam " + Environment.NewLine +
                ")";
            
            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@cod_cliente", this.cod_cliente);
                command.Parameters.AddWithValue("@marca", this.marca);
                command.Parameters.AddWithValue("@modelo", this.modelo);
                command.Parameters.AddWithValue("@placa", this.placa);
                command.Parameters.AddWithValue("@combustivel", this.combustivel);
                command.Parameters.AddWithValue("@ano", this.ano);
                command.Parameters.AddWithValue("@cor", this.cor);
                command.Parameters.AddWithValue("@renavam", this.renavam);
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
                "    cod_automovel As [Código]," + Environment.NewLine +
                "    cod_cliente As [Código do cliente]," + Environment.NewLine +
                "    marca As [Marca]," + Environment.NewLine +
                "    modelo As [Modelo]," + Environment.NewLine +
                "    placa As [Placa]," + Environment.NewLine +
                "    combustivel As [Combustível]," + Environment.NewLine +
                "    ano As [Ano]," + Environment.NewLine +
                "    cor As [Cor]," + Environment.NewLine +
                "    Renavam As [Renavam]" + Environment.NewLine +
                "FROM" + Environment.NewLine +
                "    Automovel";
            //
            
            //
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
        public void Atualizar(Int32 cod_automovel, Int32 cod_cliente, String marca, String modelo, String placa, String combustivel, String ano, String cor, String renavam)
        {
            String comandoSQL =
                "UPDATE" + Environment.NewLine +
                "    Automovel" + Environment.NewLine +
                "SET" + Environment.NewLine +
                
                "    cod_cliente = @cod_cliente," + Environment.NewLine +
                "    marca = @marca," + Environment.NewLine +
                "    modelo = @modelo," + Environment.NewLine +
                "    placa = @placa," + Environment.NewLine +
                "    combustivel = @combustivel," + Environment.NewLine +
                "    ano = @ano," + Environment.NewLine +
                "    cor = @cor," + Environment.NewLine +
                "    renavam = @renavam" + Environment.NewLine +

                "WHERE" + Environment.NewLine +
                "    (cod_automovel = @cod_automovel)";

            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@cod_cliente", cod_cliente);
                command.Parameters.AddWithValue("@marca", marca);
                command.Parameters.AddWithValue("@modelo", modelo);
                command.Parameters.AddWithValue("@placa", placa);
                command.Parameters.AddWithValue("@combustivel", combustivel);
                command.Parameters.AddWithValue("@ano", ano);
                command.Parameters.AddWithValue("@cor", cor);
                command.Parameters.AddWithValue("@renavam", renavam);
                command.Parameters.AddWithValue("@cod_automovel", cod_automovel);

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

        public void Excluir(Int32 cod_automovel)
        {
            String comandoSQL =
                "DELETE FROM" + Environment.NewLine +
                "    Automovel" + Environment.NewLine +
                "WHERE" + Environment.NewLine +
                "    (cod_automovel= @cod_automovel)";

            Conexao con = new Conexao();

            try
            {
                con.Abrir();

                OleDbCommand command = new OleDbCommand(comandoSQL, con.Connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@cod_automovel", cod_automovel);

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