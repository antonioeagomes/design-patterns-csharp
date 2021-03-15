using System;

namespace abstract_factory.ConcreteProducts
{
    public class LionProduct : AbstractProducts.CarnivoreAbstractProduct
    {
        public override void Eat(AbstractProducts.HerbivoreAbstractProduct herbivore)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}