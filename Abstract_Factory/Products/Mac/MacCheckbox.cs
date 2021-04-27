using Abstract_Factory.IProducts;
using System;

namespace Abstract_Factory.Products.Mac
{
    public class MacCheckbox : ICheckbox
    {
        public void paint()
        {
            Console.WriteLine("Reinderiza um checkbox segundo o padrão MacOs");
        }
    }
}
