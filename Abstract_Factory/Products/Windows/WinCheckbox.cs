using Abstract_Factory.IProducts;
using System;

namespace Abstract_Factory.Products.Windows
{
    public class WinCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Reinderiza um checkbox segundo o padrão Windows");
        }
    }
}
