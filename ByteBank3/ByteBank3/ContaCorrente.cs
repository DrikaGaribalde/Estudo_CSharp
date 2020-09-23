using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank3 {
    public class ContaCorrente {
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int Numero { get; set; } //public int Numero{get;}

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        private int _agencia;
        public int Agencia //public int Agencia{get;} 
        {
            get {
                return _agencia;
            }
            set {
                if (value <= 0) {
                    return;
                }

                _agencia = value;
            }
        }

        private double _saldo = 100;
        public double Saldo {
            get { return _saldo; }
            set {
                if (value < 0) {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero) {
            if (agencia <= 0) {
                throw new ArgumentException("O argumento Agência deve ser maior do que zero.", "agencia"); //"agencia"->nameof(agencia) - recurso mais novo
            }
            if (numero <= 0) {
                throw new ArgumentException("O argumento Número deve ser maior do que zero.", "numero");
            }
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor) {
            if (valor < 0) {
                throw new ArgumentException("Valor inválido para o saque. ", "valor"); //string literal - usar nameof(valor) versões mais novas
            }
            if (_saldo < valor) {

                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            _saldo -= valor;
        }

        public void Depositar(double valor) {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino) {
            if (valor < 0 ) {
                throw new ArgumentException("Valor inválido para a transferência. " + "valor");
            }
           
            try {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException e) {
                ContadorTransferenciasNaoPermitidas++;
                //throw ; //mostra todas as informações na pilha de erros
                throw new OperacaoFinanceiraException("Operação não realizada",e); // Opção nº 3 do construtor, mensagem e encaspular dados.
            }
            contaDestino.Depositar(valor);
           
        }
    }
}
