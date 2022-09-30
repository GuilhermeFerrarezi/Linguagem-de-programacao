using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

////////////////////////////////////////////////////


namespace Aula7
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public Pessoa(string nome, string endereco, string cpf, string rg)
        {
            this.Nome= nome;
            this.Endereco = endereco;
            this.Cpf = cpf;
            this.Rg = rg;
        }

        public Pessoa()
        {

        }

        public void imprimePessoa()
        {
            Console.WriteLine(this.Nome + " " + this.Endereco + " " + this.Cpf + " " + this.Rg);
        }
    }
}

//////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    class Aluno : Pessoa
    {
        string resultado;
        decimal media;
        private int faltas;
        public int Matricula { get; set; }
        public decimal P1 { get; set; }
        public decimal P2 { get; set; }
        public int _Faltas { get
            {
                return this.faltas;
            }
            set
            {
                this.faltas = value;
                if (value > 10) {
                    resultado = "Reprovado por faltas";
                }
            }
        }
        public Aluno(string nome, string cpf, string endereco, string rg, int matricula, decimal p1, decimal p2, int faltas) : base(nome, endereco, cpf, rg)
        {
            this.Matricula = matricula;
            this.P1 = p1;
            this.P2 = p2;
            this.faltas = faltas;
        }

        public Aluno()
        {

        }

        public void imprimeFaltas()
        {
            Console.WriteLine(this.faltas);
        }

        public void imprimeResultado()
        {
            Console.WriteLine(this.resultado);
        }

        public void calculaMedia()
        {
            media = (this.P1 + this.P2) / 2;

            if(resultado == string.Empty && media >= 7)
            {
                resultado = "Aprovado";
            }else if (resultado == string.Empty && media < 7 && media > 3)
            {
                resultado = "Reavaliação (exame)";
            }else if (resultado == string.Empty && media <= 3)
            {
                resultado = "Reprovado";
            }
        }

        public void imprimeAluno()
        {
            Console.WriteLine(this.Nome + " " + this.Endereco + " " + this.Cpf + " " + this.Rg + " " + this.Matricula + " " + this.P1 + " " + this.P2);
        }
    }
}
