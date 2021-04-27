using Abstract_Factory.IFactorys;
using Abstract_Factory.IProducts;
using Abstract_Factory.Products.Windows;

namespace Abstract_Factory.Factorys
{
    public class WinFactory : IFactory
    {
        public IButton crateButton()
        {
            return new WinButton();
        }

        public ICheckbox createCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
