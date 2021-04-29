using Abstract_Factory.Factorys;
using Abstract_Factory.IFactorys;
using System;
using System.Runtime.InteropServices;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = GetClientOS();

            client.RenderButton();
            client.RenderCheckbox();
        }

        static Client GetClientOS()
        {
            IFactory concreteFactory;
            string OSName = RuntimeInformation.OSDescription.ToUpper();

            if(OSName.Contains("WINDOWS"))
            {
                concreteFactory = new WinFactory();
            }
            else if(OSName.Contains("MAC"))
            {
                concreteFactory = new MacFactory();
            }
            else
            {
                throw new ArgumentException("Sistema operacional incompatível");
            }

            return new Client(concreteFactory);
        }
    }
}
