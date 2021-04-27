using Abstract_Factory.IFactorys;
using Abstract_Factory.IProducts;
using Abstract_Factory.Products.Mac;

namespace Abstract_Factory.Factorys
{
    public class MacFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
