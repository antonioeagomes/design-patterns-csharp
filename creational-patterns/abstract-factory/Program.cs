using System;
using abstract_factory.AbstractProducts;
using abstract_factory.ConcreteProducts;

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

            Clients.RealWorld.CriarAutoSocorro(new VeiculoCreator()
                .Criar("Etios", Porte.Pequeno))
                .SocorrerVeiculos();
            Clients.RealWorld.CriarAutoSocorro(new VeiculoCreator()
                .Criar("Corolla", Porte.Medio))
                .SocorrerVeiculos();
            Clients.RealWorld.CriarAutoSocorro(new VeiculoCreator()
                .Criar("Hilux", Porte.Grande))
                .SocorrerVeiculos();
        }
    }

    public enum Porte {
        Pequeno,
        Medio,
        Grande
    }
}
