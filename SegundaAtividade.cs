using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace segunda_atividade
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

            for(int i=0; i<4; i++)
            {
                if (f1[i].getSalario() > media)
                {
                    Console.WriteLine(f1[i].getNome() + " " + f1[i].getMatricula() + " " + f1[i].getSalario());
                }
            }

            Console.ReadKey();
        }
    }

///////////////////////////////////////////////////////

class Funcionario
    {

        private string Nome;
        private int Matricula;
        private double Salario;

        //Construtor

        public Funcionario(string Nome, int Mat, double Sal)
        {
            this.Nome = Nome;
            this.Matricula = Mat;
            this.Salario = Sal;
        }

        //Get e Set

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }
        public void setMatricula(int Mat)
        {
            this.Matricula = Mat;
        }
        public void setSalario(float Sal)
        {
            this.Salario = Sal;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public int getMatricula()
        {
            return this.Matricula;
        }

        public double getSalario()
        {
            return this.Salario;
        }

        public double calcSal(Funcionario f1, Funcionario f2, Funcionario f3)
        {
            return (this.Salario + f1.Salario + f2.Salario + f3.Salario)/4;
        }
    }
}


