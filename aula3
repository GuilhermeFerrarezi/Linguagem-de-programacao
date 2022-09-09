using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();

            /*
            p1.nome = "Ana";
            p2.nome = "Paulo";
            p3.nome = "Lia";

            p1.idade = 23;
            p2.idade = 35;
            p3.idade = 12;

            p1.sexo = 'F';
            p2.sexo = 'M';
            p3.sexo = 'F';

            Console.WriteLine(p1.nome + " " + p1.idade + " " + p1.sexo);
            Console.WriteLine(p2.nome + " " + p2.idade + " " + p2.sexo);
            Console.WriteLine(p3.nome + " " + p3.idade + " " + p3.sexo);
            */

            p1.setNome("Ana");
            p2.setNome("Paulo");
            p3.setNome("Lia");

            p1.setIdade(23);
            p2.setIdade(35);
            p3.setIdade(12);

            p1.setSexo('F');
            p2.setSexo('M');
            p3.setSexo('F');

            Console.WriteLine(p1.getNome() + " " + p1.getIdade() + " " + p1.getSexo());
            Console.WriteLine(p2.getNome() + " " + p2.getIdade() + " " + p2.getSexo());
            Console.WriteLine(p3.getNome() + " " + p3.getIdade() + " " + p3.getSexo());

        }
    }
}

////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Pessoa
    {

        private string nome;
        private int idade;
        private char sexo;

        public void setNome (string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public int getIdade()
        {
            return this. idade;
        }

        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }

        public char getSexo()
        {
            return this. sexo;
        }
    }
}
