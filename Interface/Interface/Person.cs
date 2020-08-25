using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface {
    class Person : IAge {
        private string firstName;
        private string lastName;
        private int yearBorn;

        //construtor
        public Person(string firstNameValue, string lastNameValue, int yearBornValue) {
            firstName = firstNameValue;
            lastName = lastNameValue;

            if (yearBornValue > 0 && yearBornValue <= DateTime.Now.Year) {
                yearBorn = yearBornValue;
            } else {
                yearBorn = DateTime.Now.Year;
            }
        }
        //implementação da propriedade Age da interface IAge
        public int Age {
            get { return DateTime.Now.Year - yearBorn; }
        }
        //propriedade Name da interface IAge
        public string Name {
            get { return firstName + " " + lastName; }
        }
    }
}
