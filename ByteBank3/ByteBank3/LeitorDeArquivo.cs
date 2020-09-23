using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank3 {
    public class LeitorDeArquivo : IDisposable {
       
        public string Arquivo{get; set;}

        public LeitorDeArquivo(string arquivo) {
            Arquivo = arquivo;

            //throw new FileNotFoundException(); //Exceção para arquivo não encontrado

            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha() {
            Console.WriteLine("Lendo linha. . .");

            throw new IOException();

            return "Linha do arquivo";
        }

        public void Dispose() {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
