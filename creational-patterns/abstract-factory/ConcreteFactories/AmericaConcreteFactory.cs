namespace abstract_factory.ConcreteFactories
{
    public class AmericaConcreteFactory: AbstractFactories.ContinentAbstractFactory
    {
        public override AbstractProducts.HerbivoreAbstractProduct CreateHerbivore()
        {
            return new ConcreteProducts.BisonProduct();
        }

         public override AbstractProducts.CarnivoreAbstractProduct CreateCarnivore()
        {
            return new ConcreteProducts.WolfProduct();
        }
    }
}