using Abstract_Factory.IProducts;
using System;

namespace Abstract_Factory.Products.Windows
{
    public class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Reinderiza um botão segundo o padrão Windows");
        }
    }
}
