using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas {
    
    public interface IAutenticavel{

        bool Autenticar(string senha);
    }
}
