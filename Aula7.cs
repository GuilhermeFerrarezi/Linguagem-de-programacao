using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    class Program
    {
        static void Main(string[] args)
        {
            Departamento d = new Departamento();

            d.nome = "vendas";
            d.adicionaFunc("Maria", "6765657", 123);
            d.adicionaFunc("Pedro", "2213438", 789);

            d.imprimeDepartamento();

            Console.ReadKey();
        }
    }

    /////////////////////////////////////////////////////////

    class Funcionario
    {
        public Funcionario(string nome, string cpf, int mat)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.matricula = mat;
        }
        private string nome;
        private string cpf;
        private int matricula;

        public void imprimeFuncionario()
        {
            Console.WriteLine(this.nome + " " + this.cpf + " " + this.matricula);
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public void setNome(int mat)
        {
            this.matricula = mat;
        }

        public string getNome()
        {
            return this.nome;
        }
        public string getCpf()
        {
            return this.nome;
        }
        public int getMat()
        {
            return this.matricula;
        }
    }

    /////////////////////////////////////////////////////////////////

    class Departamento
    {
        public string nome;
        ArrayList funcionarios = new ArrayList();

        public void adicionaFunc(string nome, string cpf, int mat)
        {
            Funcionario f = new Funcionario(nome, cpf, mat);

            this.funcionarios.Add(f);
        }


        public void imprimeDepartamento()
        {
            foreach (Funcionario f in funcionarios)
            {
                f.imprimeFuncionario();
            }
        }
    }
}
