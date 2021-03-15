using abstract_factory.AbstractFactories;
using abstract_factory.AbstractProducts;

namespace abstract_factory.ConcreteFactories
{
    public class SocorroVeiculoPequenoFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho() => new GuinchoCreator().Criar(Porte.Pequeno);

        public override Veiculo CriarVeiculo(string nome, Porte porte) => new VeiculoCreator().Criar(nome, porte);
    }
}