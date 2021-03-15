using abstract_factory.AbstractFactories;

namespace abstract_factory.ConcreteFactories
{
    public class AfricaConcreteFactory : AbstractFactories.ContinentAbstractFactory
    {
        public override AbstractProducts.CarnivoreAbstractProduct CreateCarnivore()
        {
            return new ConcreteProducts.LionProduct();
        }

        public override AbstractProducts.HerbivoreAbstractProduct CreateHerbivore()
        {
            return new ConcreteProducts.WildebeestProduct();
        }
    }
}