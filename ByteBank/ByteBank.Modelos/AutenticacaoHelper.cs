using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Modelos {
    class AutenticacaoHelper {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa) {
            
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
