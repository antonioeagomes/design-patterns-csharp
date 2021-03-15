using abstract_factory.AbstractProducts;

namespace abstract_factory.AbstractFactories
{
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string nome, Porte porte);
    }
}