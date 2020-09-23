using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBank3 {
    class Program {
        static void Main(string[] args) {
            try {
                //Metodo();
                //CarregarContas();   
                TestaInnerException();
            }
            catch (Exception) {
                Console.WriteLine("Exceçao no catch main");
            }
            Console.WriteLine();
            Console.WriteLine("Execução finalizada. Tecle enter para sair.");
            Console.ReadLine();
        }

        private static void CarregarContas() {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))  {
                leitor.LerProximaLinha();
            }
            //LeitorDeArquivo leitor = null;

            //try {
            //    leitor = new LeitorDeArquivo("contas.txt");
            //    leitor.LerProximaLinha();
            //}finally {
            //    if (leitor != null) {
            //        leitor.Dispose();    
            //    }
            //}
        }

        private static void TestaInnerException() {
            try {
                ContaCorrente conta1 = new ContaCorrente(123, 1212121);
                ContaCorrente conta2 = new ContaCorrente(123, 2323232);

                conta1.Transferir(10000, conta2);
                //conta1.Sacar(10000);

            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Não é possível divisão por zero.");
            }
            catch (ArgumentException e) {
                if (e.ParamName == "agencia") {
                    //code here!
                }
                Console.WriteLine(e.ParamName);
                Console.WriteLine(e.Message);
            }
            catch (OperacaoFinanceiraException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                //Console.WriteLine("Informações da Inner Exception - exceção interna!");
                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);
            }
        }
        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo() {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor) {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor) {
            try {
                return numero / divisor;
            }
            catch (DivideByZeroException) {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
                Console.WriteLine("Código depois do throw");
            }
        }
    }
}
