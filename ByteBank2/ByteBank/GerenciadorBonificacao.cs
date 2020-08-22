using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ByteBank.Funcionarios;

namespace ByteBank {
    public class GerenciadorBonificacao {

        private double _totalBonificacao;

        //Registrar Funcionário
        public void Registrar(Funcionario funcionario) {
            _totalBonificacao += funcionario.GetBonificacao();
        }
    
        public double GetTotalBonificacao() {
            return _totalBonificacao;
        }
    }
}
