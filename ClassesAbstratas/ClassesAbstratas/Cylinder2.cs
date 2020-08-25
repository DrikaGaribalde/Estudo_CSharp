using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesAbstratas {
    // Cylinder herda da classe Circle2
    public class Cylinder2 : Circle2{
        private double height; //altura do Cylinder2
        
        //Contrutor padrão e o segundo construtor
        public Cylinder2() { 
            //code here:)
        }
        public Cylinder2(int xValue, int yValue, double radiusValue, double heightValue) : base(xValue, yValue, radiusValue) {
            Height = heightValue;
        }
        //
        //propriedade Height
        public double Height {
            get { return height; }
            set {
                if (value >= 0)
                    height = value;
                //garante valor da altura não negativo
            }
        }
        //calcula a área do Cylinder2
        public override double Area() {
            return 2 * base.Area() + base.Circumference() * Height;
        }
        //calcula o volume do Cylinder2
        public override double Volume() {
            return base.Area() * Height;
        }
        //retorna a representação de string do objeto Cylinder2
        public override string ToString() {
            return base.ToString() + " Height = " + Height;
        }
        //sobrepõe a propriedade Name da classe Point2
        public override string Name {
            get {
                return "Cylinder2";
            }
        }
    }
}
