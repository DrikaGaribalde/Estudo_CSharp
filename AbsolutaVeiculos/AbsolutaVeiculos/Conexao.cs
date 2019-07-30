using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AbsolutaVeiculos
{
    public class Conexao
    {        
        private OleDbConnection connection;

        private const String CONN_STRING = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AbsolutaVeiculos.accdb;Persist Security Info=False;";

        public OleDbConnection Connection
        {
            get
            {
                return this.connection;
            }
        }
        
        public Conexao()
        {            
            connection = new OleDbConnection(CONN_STRING);
        }
        
        public void Abrir()
        {            
            if (connection != null)
            {
                try
                {                    
                    connection.Open();
                }
                catch (OleDbException ex)
                {                    
                    DialogResult resposta;
                    
                    resposta = MessageBox.Show("Ocorreu um erro ao abrir a conexão com o banco de dados: " + ex.Message,
                        "Atenção", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    
                    if (resposta == DialogResult.Retry)
                    {
                        Abrir();
                    }
                    else
                    {
                        Environment.Exit(ex.ErrorCode);
                    }
                }
            }
        }
        
        public void Fechar()
        {
            connection.Close();
        }               
    }
}
