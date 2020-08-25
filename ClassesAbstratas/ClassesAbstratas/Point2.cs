using System;

namespace ClassesAbstratas {
    //herda da classe abstrata Shape
    public class Point2 : Shape {
        private int x, y; //coordenadas de Point2

        //construtor padrão
        public Point2() {
            //code here:)
        }

        //Segundo construtor
        public Point2(int xValue, int yValue) {
            X = xValue;
            Y = yValue;
        }

        //Propriedade X
        public int X {
            get { return x; }
            set { x = value; }
        }
        public int Y {
            get { return y; }
            set { y = value; }
        }
        //retorna a representção de string do objeto Point2
        public override string ToString() {
            return "["+ X + ", "+ Y + "]";
        }

        //implementa a propriedade abstrata Name da classe Shape
        public override string Name {
            get { return "Point2"; }
        }
    }   
}