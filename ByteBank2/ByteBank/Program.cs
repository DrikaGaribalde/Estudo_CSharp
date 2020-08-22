using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;


namespace ByteBank {
    class Program {
        static void Main(string[] args) {

            //CalcularBonificacao();
            UsarSistema();
            
            Console.ReadLine();
        }

        public static void CalcularBonificacao() {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            
            //Designer pedro = new Designer("111.111.111-11");
            //pedro.Nome = "Pedro";

            //Diretor roberta = new Diretor("222.222.222-22");
            //roberta.Nome = "Roberta";

            //Auxiliar igor= new Auxiliar("333.333.333.-33");
            //igor.Nome = "Igor";

            //GerenteDeConta camila= new GerenteDeConta("444.444.444-44");
            //camila.Nome = "Camila";

            //gerenciadorBonificacao.Registrar(pedro);
            //gerenciadorBonificacao.Registrar(roberta);
            //gerenciadorBonificacao.Registrar(igor);
            //gerenciadorBonificacao.Registrar(camila);

            //Console.WriteLine("Total de bonificações do mês : " + 
            //gerenciadorBonificacao.GetTotalBonificacao());
        }
        public static void UsarSistema() {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("222.222.222-22");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("444.444.444-44");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            Designer pedro = new Designer("111.111.111-11");
            pedro.Nome = "Pedro";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "oi";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
            //sistemaInterno.Logar(pedro, "oi"); //
            sistemaInterno.Logar(parceiro, "oi");

            Console.WriteLine();

           
            

        }

    }
}
