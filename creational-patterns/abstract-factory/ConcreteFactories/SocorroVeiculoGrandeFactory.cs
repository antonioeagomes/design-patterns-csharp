using abstract_factory.AbstractFactories;
using abstract_factory.AbstractProducts;

namespace abstract_factory.ConcreteFactories
{
    public class SocorroVeiculoGrandeFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return new GuinchoCreator().Criar(Porte.Grande);
        }

        public override Veiculo CriarVeiculo(string nome, Porte porte)
        {
            return new VeiculoCreator().Criar(nome, porte);
        }
    }
}