using System;
using System.Collections.Generic;

namespace Monostate
{
    class Program
    {
        static void Main(string[] args)
        {
            var spooler1 = new SpoolerImpressao();

            spooler1.AdicionaArquivo(new Arquivo("arquivo1", ".txt", 16));
            ListarArquivos(spooler1.RetornarSpooler());

            var spooler2 = new SpoolerImpressao();

            spooler2.AdicionaArquivo(new Arquivo("arquivo2", ".csv", 18));
            ListarArquivos(spooler2.RetornarSpooler());
            //Como pode-se ver no resultado do console, o atributo foi compartilhado entre as instâncias da classe SpoolerImpressao
            //Assim, reproduziu-se o comportamento do Singleton e respeitou-se o princípio de responsabilidade única do SOLID
        }

        static void ListarArquivos(List<Arquivo> spooler)
        {
            foreach(var arquivo in spooler)
            {
                Console.WriteLine("Arquivo: " + arquivo.Nome);
            }

            Console.WriteLine("------------------------------");
        }
    }
}
