using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula5
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Email { get; set; }

        public Aluno(string nome)
        {
            this.Nome = nome;
        }

        public Aluno()
        {
        }

        public Aluno(string nome, int matricula, string email)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Email = email;
        }

        

    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.Nome = "Zé";
            a1.Matricula = 234;
            a1.Email = "ze@gmail.com";

            Aluno a2 = new Aluno("Ana");
            a2.Matricula = 789;
            a2.Email = "ana@xy.com";

            Aluno a3 = new Aluno("Paulo", 989, "paulo@ig.com");

            Console.WriteLine(a1.Nome + " " + a1.Matricula + " " + a1.Email);
            Console.WriteLine(a2.Nome + " " + a2.Matricula + " " + a2.Email);
            Console.WriteLine(a3.Nome + " " + a3.Matricula + " " + a3.Email);

            Console.ReadKey();
        }
    }
}
