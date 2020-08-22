using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Funcionarios {
    class Desenvolvedor : Funcionario {
        //Construtor
        public Desenvolvedor(string cpf) : base(3000,"555.555.555-55") {
        //
        }
        public override void AumentarSalario() {
            Salario *= 0.15;
        }
        public override double GetBonificacao() {
            return Salario * 0.1;
        }

       
    }
}
