using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.nome = "Joaquim Jose";
            cliente1.cpf = "9888888";
            cliente1.rg = "12345";
            cliente1.endereco = "Rua ZZZZ, 23";
                   
            Conta c1 = new Conta();
            c1.numero = 1;
            c1.titular = cliente1;
            c1.saldo = 1500;

            Console.WriteLine(c1.MostraNumero());
            Console.WriteLine(c1.MostraTitular());
            Console.WriteLine(c1.MostraSaldo());
            c1.Sacar(350);
            Console.WriteLine(c1.MostraSaldo());

            c1.Depositar(500);
            Console.WriteLine(c1.MostraSaldo());

            Cliente cliente2 = new Cliente();
            cliente2.nome = "Jose Joaquim";
            cliente2.cpf = "8999999";
            cliente2.rg = "54321";
            cliente2.endereco = "Rua XXXX, 32";

            Conta c2 = new Conta();
            c2.numero = 2;
            c2.titular = cliente2;
            c2.saldo = 3000;

            Console.WriteLine(c2.MostraSaldo());

            c1.Transferir(250, c2);

            Console.WriteLine(c1.MostraSaldo());
            Console.WriteLine(c2.MostraNumero());
            Console.WriteLine(c2.MostraTitular());
            Console.WriteLine(c2.MostraSaldo());


            Console.ReadKey();
        }
    }
}


///////////////////////////////////////////////////////

namespace Aula2
{
    class Cliente
    {
        public string nome;
        public string cpf;
        public string rg;
        public string endereco;
    }
}

///////////////////////////////////////////////////////

namespace Aula2
{                              
    class Conta                
    {                          
        public int numero;
        public Cliente titular;
        public double saldo;

        public double MostraSaldo()
        {
            return this.saldo;
        }

        public bool Sacar(double valor)
        {
            if (this.saldo >= valor){
                this.saldo = this.saldo - valor;
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public int MostraNumero()
        {
            return this.numero;
        }

        public string MostraTitular()
        {
            return "nome: " + titular.nome + " Cpf: " + titular.cpf;
        }

        public bool Depositar(double valor)
        {
            this.saldo = this.saldo + valor;
            return (true);  
        }

        public bool Transferir(double valor, Conta conta)
        {
            if(saldo > valor)
            {
                this.saldo = this.saldo - valor;
                conta.saldo = conta.saldo + valor;
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
}
