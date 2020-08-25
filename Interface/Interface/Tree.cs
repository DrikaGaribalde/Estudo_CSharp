using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface {
    class Tree : IAge{
        private int rings; //número de anéis no tronco da árvore

        //construtor
        public Tree(int yearPlanted) {
        //conta o número de anéis na árvore
            rings = DateTime.Now.Year - yearPlanted;
        }
        //incrementa rings
        public void AddRings() {
            rings++;
        }
        //implementação da propriedade Age da interface
        public int Age {
            get { return rings; }
        }
        //propriedade Name da interface
        public string Name {
            get { return "Tree"; }
        }
    }
}
