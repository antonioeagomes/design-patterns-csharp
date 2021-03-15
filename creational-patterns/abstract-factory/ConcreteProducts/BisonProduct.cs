using System;

namespace abstract_factory.ConcreteProducts
{
    public class BisonProduct : AbstractProducts.HerbivoreAbstractProduct
    {
        public override void Runaway(AbstractProducts.CarnivoreAbstractProduct carnivore)
        {
            Console.WriteLine(this.GetType().Name + " tries to escape from " + carnivore.GetType().Name);
        }
    }
}