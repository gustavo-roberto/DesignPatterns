using Abstract_Factory.IFactorys;
using Abstract_Factory.IProducts;

namespace Abstract_Factory
{
    public class Client
    {
        private IFactory _factory;
        private IButton _button;
        private ICheckbox _checkbox;
        public Client(IFactory factory)
        {
            _factory = factory;
            _button = _factory.CreateButton();
            _checkbox = _factory.CreateCheckbox();
        }

        public void RenderButton()
        {
            _button.Paint();
        }

        public void RenderCheckbox()
        {
            _checkbox.Paint();
        }
    }
}
