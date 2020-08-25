using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesAbstratas {
    class Program {
        static void Main(string[] args) {
        //instancia objetos Point2, Circle2 e Cylinder2
            Point2 point = new Point2(7,11);
            Circle2 circle = new Circle2(22,8,3.5);
            Cylinder2 cylinder = new Cylinder2(10,10,3.3,10);

            //cria array vazio de referências à classe base Shape
            Shape[] arrayOfShapes = new Shape[3];
           
            //arrayOfShapes[0] se refere ao objeto Point2
            arrayOfShapes[0] = point;
            arrayOfShapes[1] = circle;
            arrayOfShapes[2] = cylinder;

            string output = point.Name + ": " + point + "\n" +
                            circle.Name + ": " + circle + "\n" +
                            cylinder.Name + ": " + cylinder;
            //
            foreach (Shape shape in arrayOfShapes) {
                output += "\n\n" + shape.Name + ": " + shape +
                    "\nArea = " + shape.Area().ToString("F") +
                    "\nVolume = " + shape.Volume().ToString("F");

            }
            //
            
            Console.WriteLine(output);

            Console.ReadLine();


        }
    }
}
