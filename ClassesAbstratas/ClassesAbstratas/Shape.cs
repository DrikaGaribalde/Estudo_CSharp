using System;

namespace ClassesAbstratas {
    public abstract class Shape {
        
        //retorna a área da figura
        public virtual double Area() {
            return 0;
        }
        //retorna o volume da figura
        public virtual double Volume() {
            return 0;
        }
        //retorna o nome da figura
        public abstract string Name { get; }
    }
}
