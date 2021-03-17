using abstract_factory.AbstractFactories;
using abstract_factory.AbstractProducts;

namespace abstract_factory.ConcreteFactories
{
    public class SocorroVeiculoPequenoFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        { 
            return new GuinchoCreator().Criar(Porte.Pequeno);
        }

        public override Veiculo CriarVeiculo(string nome, Porte porte)
        {
            return new VeiculoCreator().Criar(nome, porte);
        }
    }
}