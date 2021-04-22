using System;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDb gerenciador1 = GerenciadorDb.GetInstance();
            GerenciadorDb gerenciador2 = GerenciadorDb.GetInstance();

            if(gerenciador1 == gerenciador2)
            {
                Console.WriteLine("Está sendo retornado sempre a mesma referência do objeto GerenciadorDb - Singleton é real");
            }
            else
            {
                Console.WriteLine("Está sendo retornado referências diferentes do objeto GerenciadorDb - Singleton é Fake News");
            }
        }
    }
}
