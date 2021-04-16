using System;
using System.Runtime.InteropServices;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gerenciador1 = GerenciadorDb.GetInstance();

            Console.WriteLine("gerenciador1: " + gerenciador1.Propriedade);

            Console.WriteLine("------------------------------------------------------");

            GerenciadorDb gerenciador2 = GerenciadorDb.GetInstance();
            Console.WriteLine("Modificação da propriedade pelo gerenciador2");

            gerenciador2.Propriedade = "Nova string - modificação pelo gerenciador2";
            
            Console.WriteLine("gerenciador1: " + gerenciador1.Propriedade);

            Console.WriteLine("\n\nConclusão: Sempre está sendo fornecida a mesma instância de memória da classe GerenciadorDb");
        }
    }
}
