using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Funcionarios {
    class Designer : Funcionario{

        //Construtor
        public Designer(string cpf) : base(3000, cpf) { 
        // 
        }

        //AumentarSalario
        public override void AumentarSalario() {
            Salario *= 1.11;
        }

        //GetBonificacao
        public override double GetBonificacao() {
            return Salario * 0.17;
        }

    }
}
