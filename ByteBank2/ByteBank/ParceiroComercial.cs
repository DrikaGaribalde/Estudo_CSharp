using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ByteBank.Sistemas;

namespace ByteBank {
    public class ParceiroComercial : IAutenticavel{
        public string Senha { get; set; }
        
        public bool Autenticar(string senha) {
            return Senha == senha;
        }

    }
}
