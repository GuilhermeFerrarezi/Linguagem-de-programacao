using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace terceira_atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funcionario[] f1 = new Funcionario[4];
            f1[0] = new Funcionario("Guilherme", 100, 2500);
            f1[1] = new Funcionario("Lilian", 200, 3000);
            f1[2] = new Funcionario("Fabio", 300, 1500.5);
            f1[3] = new Funcionario("Rafael", 400, 2000.6);



            double media = f1[0].calcSal(f1[1], f1[2], f1[3]);

            Console.WriteLine("Os funcionário que ganham acima da média são:");

            for (int i = 0; i < 4; i++)
            {
                if (f1[i].Salario > media)
                {
                    Console.WriteLine(f1[i].Nome + " " + f1[i].Matricula + " " + f1[i].Salario);
                }
            }

            Console.ReadKey();
        }
    }

    ///////////////////////////////////////////////////////

    class Funcionario
    {

        public string Nome { get; set; }
        public int Matricula { get; set; }
        public double Salario { get; set; }

        //Construtor

        public Funcionario(string Nome, int Mat, double Sal)
        {
            this.Nome = Nome;
            this.Matricula = Mat;
            this.Salario = Sal;
        }

     
        public double calcSal(Funcionario f1, Funcionario f2, Funcionario f3)
        {
            return (this.Salario + f1.Salario + f2.Salario + f3.Salario) / 4;
        }
    }
}
