using abstract_factory.AbstractFactories;
using abstract_factory.AbstractProducts;

namespace abstract_factory.ConcreteFactories
{
    public class SocorroVeiculoGrandeFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            throw new System.NotImplementedException();
        }

        public override Veiculo CriarVeiculo(string nome, Porte porte)
        {
            throw new System.NotImplementedException();
        }
    }
}