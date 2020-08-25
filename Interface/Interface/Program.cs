using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface {
    class Program {
        static void Main(string[] args) {

            Tree tree = new Tree(1978);
            Person person = new Person("Drika","Garibalde",1976);

            //cria array de referência a IAge
            IAge[] iAgeArray = new IAge[2];

            //iAgeArray[0] se refere ao objeto Tree e iAgeArray[1] ao objeto person de maneira Polimorfica
            iAgeArray[0] = tree;
            iAgeArray[1] = person;

            //exibe informações da árvore
            string output = tree + ": " + tree.Name + "\nAge is " + tree.Age + "\n\n";

            //exibe informações da pessoa
            output += person + ": " + person.Name + "\nAge is " + person.Age + "\n\n";

            //exibe o nome e a idade de cada objeto IAge em IAgeArray
            foreach (IAge ageReference in iAgeArray) {
                output += ageReference.Name + " Age is " + ageReference.Age + "\n";
            }
            Console.WriteLine(output);
            Console.WriteLine();
            Console.WriteLine("Demostrating Polymorphism");
        }
    }
}
