using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank3 {
    public class SaldoInsuficienteException : OperacaoFinanceiraException {
        //Propriedades
        public double Saldo { get; set; }
        public double ValorSaque { get; set; }

        //Construtor - Motivo definir uma nova mensagem
        public SaldoInsuficienteException() { }

        public SaldoInsuficienteException(double saldo, double valorSaque) : this("Tentativa de saque do valor de " + valorSaque + 
            " em uma conta de "+ saldo) {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        
        public SaldoInsuficienteException(string messagem)
            : base(messagem) {
        }

        public SaldoInsuficienteException(string messagem, Exception excecaoInterna) : base(messagem, excecaoInterna) { }
    }
}
