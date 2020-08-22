using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios {
    class GerenteDeConta : FuncionarioAutenticavel {
        
        //Construtor
        public GerenteDeConta(string cpf): base(4000, cpf) {
            //
        }

        //AumentarSalario
        public override void AumentarSalario() {
            Salario *= 1.05;
        }

        //Getbonificacao
        public override double GetBonificacao() {
            return Salario * 0.25;
        }

    }
}
