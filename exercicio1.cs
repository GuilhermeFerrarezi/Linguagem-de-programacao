using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Program
    {
        public static void Main(string[] args) {

            //Calcular a base de um quadrado

            /*
            double lado, area;
            lado = double.Parse(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine(area);
            */

            //Calcular a base de um trapesio

            /*
            double base1, base2, altura, area;
            base1 = double.Parse(Console.ReadLine());
            base2 = double.Parse(Console.ReadLine());
            altura = double.Parse(Console.ReadLine());

            area = ((base1 + base2) * altura) / 2;

            Console.WriteLine(area);
            */

            // calcular salario final de acordo com o percentual de aumento

            /*
            double salario, percentual, salario_final;

            salario = double.Parse(Console.ReadLine());
            percentual = double.Parse(Console.ReadLine());

            percentual /= 100;

            salario_final = salario + (salario * percentual);

            Console.WriteLine(salario_final);
            */

            // ver qual o maior número entre 3 entrados

            /*
            double n1, n2, n3;

            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3) {
                Console.WriteLine(n1 + " é maior que " + n2 + " e " + n3);
            } else if (n2>n1 && n2>n3){
                Console.WriteLine(n2 + " é maior que " + n1 + " e " + n3);
            } else if (n3>n1 && n3>n2){
                Console.WriteLine(n3 + " é maior que " + n2 + " e " + n1);
            } else {
                Console.WriteLine("Os números entrados são iguais);
            }
             */

            //Mostrar se o número é múltiplo de 7

            /*
            double n1;

            n1 = double.Parse(Console.ReadLine());

            if (n1%7 == 0) {
                Console.WriteLine(n1 + " é divisível por 7");
            }else{
                Console.WriteLine(n1 + " não é divisível por 7");
            }
            */

        }
    }
}
