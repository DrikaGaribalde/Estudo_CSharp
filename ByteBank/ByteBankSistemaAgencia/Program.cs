using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;


namespace ByteBankSistemaAgencia {
    class Program {
        static void Main(string[] args) {
            DateTime dataFimPagamento = new DateTime(2020, 7, 23);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(40);

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);
          
            Console.ReadLine();
        }
    }
}
