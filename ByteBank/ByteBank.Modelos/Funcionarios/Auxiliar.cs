using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Modelos.Funcionarios {
    public class Auxiliar : Funcionario {
        
        //Construtor
        public Auxiliar(string cpf) : base(2000,cpf) {
        //
        }

        //AumentarSalario
        public override void AumentarSalario() {
            Salario *= 1.1;
        }

        //GetBonificacao
        internal protected override double GetBonificacao() {
            return Salario * 0.2;
        }
    }
}
