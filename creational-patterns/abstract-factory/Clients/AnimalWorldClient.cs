namespace abstract_factory.Clients
{
    public class AnimalWorldClient
    {
        private AbstractProducts.HerbivoreAbstractProduct _herbivore;
        private AbstractProducts.CarnivoreAbstractProduct _carnivore;

        public AnimalWorldClient(AbstractFactories.ContinentAbstractFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain() {
            _herbivore.Runaway(_carnivore);
            _carnivore.Eat(_herbivore);
        }
    }
}