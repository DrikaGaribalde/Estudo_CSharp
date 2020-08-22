using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Funcionarios {
    class Auxiliar : Funcionario {
        
        //Construtor
        public Auxiliar(string cpf) : base(2000,cpf) {
        //
        }

        //AumentarSalario
        public override void AumentarSalario() {
            Salario *= 1.1;
        }

        //GetBonificacao
        public override double GetBonificacao() {
            return Salario * 0.2;
        }
    }
}
