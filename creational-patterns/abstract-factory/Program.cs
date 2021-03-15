using System;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteFactories.AfricaConcreteFactory africa = new ConcreteFactories.AfricaConcreteFactory();
            Clients.AnimalWorldClient animalWorld = new Clients.AnimalWorldClient(africa);
            animalWorld.RunFoodChain();

            ConcreteFactories.AmericaConcreteFactory america = new ConcreteFactories.AmericaConcreteFactory();
            animalWorld = new Clients.AnimalWorldClient(america);
            animalWorld.RunFoodChain();
        }
    }

    public enum Porte {
        Pequeno,
        Medio,
        Grande
    }
}
