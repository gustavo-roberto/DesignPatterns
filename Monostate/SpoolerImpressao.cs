using System;
using System.Collections.Generic;
using System.Linq;

namespace Monostate
{
    public class SpoolerImpressao
    {   //Segundo o padrão Monostate, todos os atributos devem ser privados e estáticos
        private static List<Arquivo> _spooler = new List<Arquivo>();
        //Já os seus setters e getters, devem ser públicos. Assim se garante um comportamento análogo ao Singleton
        public void AdicionaArquivo(Arquivo arquivo)
        {
            _spooler.Add(arquivo);
        }

        public List<Arquivo> RetornarSpooler()
        {
            return _spooler;
        }
    }
}
