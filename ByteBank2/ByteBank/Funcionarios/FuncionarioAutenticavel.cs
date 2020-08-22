using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios {
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel{

        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf) { 
            //
        }
     
        //implementar a interface 
        public bool Autenticar(string senha) {
            return Senha == senha;
        }
    }
}
