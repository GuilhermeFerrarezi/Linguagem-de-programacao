using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula7
{
    class Program
    {
        static void Main(string[] args)
        {
            Departamento d = new Departamento();

            d.Nome = "vendas";
            d.adicionaFunc("Maria", "6765657", 123);
            d.adicionaFunc("Pedro", "2213438", 789);

            d.imprimeFunc();

            Console.ReadKey();
        }
    }
    
    /////////////////////////////////////////////////////////
    
    class Funcionario
    {
        public Funcionario(string nome, string cpf, int mat)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Matricula = mat;
        }
        public string Nome{ get; set;}
        public string Cpf{ get; set;}
        public int Matricula { get; set; }

        public void imprimeFuncionario()
        {
            Console.WriteLine(this.Nome + " " + this.Cpf + " " + this.Matricula);
        }
    }
    
    /////////////////////////////////////////////////////////////////
    
    class Departamento
    {
        public string Nome;
        ArrayList funcionarios = new ArrayList();

        public void adicionaFunc(string nome, string cpf ,int mat)
        {
            Funcionario f = new Funcionario(nome, cpf, mat);

            this.funcionarios.Add(f);
        }


        public void imprimeFunc()
        {
           foreach (Funcionario f in funcionarios)
            {
                f.imprimeFuncionario();
            }
        }
    }
}
