using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Properties {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Digite a Hora: ");
            int hourValue = int.Parse(Console.ReadLine());
            Console.Write("Digite os Minutos: ");
            int minuteValue = int.Parse(Console.ReadLine());
            Console.Write("Digite os Segundos: ");
            int secondValue = int.Parse(Console.ReadLine());

            Time time = new Time(hourValue,minuteValue,secondValue);
            Console.WriteLine(time.ToString());
            Console.WriteLine();

            Console.Write("Você quer adicionar um segundo (s/n)? ");
            char flag = char.Parse(Console.ReadLine());
            if (flag == 's' || flag == 'S') {
                time.AddSecond();
                Console.WriteLine(time.ToString());
            }
            Console.ReadLine();
        }        
    }
}