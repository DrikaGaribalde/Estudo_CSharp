using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesAbstratas {
    // Circle2 herda de Point2
    public class Circle2 : Point2 {
        private double radius; //raio de Circle2

        //construtor padrão
        public Circle2() { 
            //code here:)
        }
        //segundo construtor
        public Circle2(int xValue, int yValue, double radiusValue):base(xValue,yValue) {
            Radius = radiusValue;
        }
        //Propriedade Radius
        public double Radius {
            get { return radius; }
            set {
                if (value >= 0)
                    radius = value;
                //garante valor de raio não negativo
            }
        }
        //calcula o diâmetro de Circle2
        public double Diameter() {
            return Radius * 2;
        }

        //calcula a circunferência de Circle2
        public double Circumference() {
            return Math.PI * Diameter();
        }

        //calcula a área de Circle2
        public override double Area() {
            return Math.PI * Math.Pow(Radius, 2);
        }

        //retorna a representação de string do objeto Circle2
        public override string ToString() {
            return "Center = " + base.ToString() + 
                "; Radius = " + Radius;
        }

        //sobrepõe a propriedade Name da classe Point2
        public override string Name {
            get {
                return "Circle2";
            }
        }
    }
}
