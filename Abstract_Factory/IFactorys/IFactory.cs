using Abstract_Factory.IProducts;

namespace Abstract_Factory.IFactorys
{
    public interface IFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
