using System;
using System.Text;
using abstract_factory.AbstractFactories;
using abstract_factory.AbstractProducts;

namespace abstract_factory.Clients
{
    public class RealWorld
    {
        private readonly Veiculo _veiculo;
        private readonly Guincho _guincho;

        public RealWorld(AutoSocorroFactory factory, Veiculo veiculo)
        {
            _veiculo = factory.CriarVeiculo(veiculo.Nome, veiculo.Porte);
            _guincho = factory.CriarGuincho();
        }

        public void SocorrerVeiculos() {
            StringBuilder s = new StringBuilder();
            s.Append(_guincho.GetType().Name)
                .Append(" socorre ")
                .Append(_veiculo.Porte).Append(" ")
                .Append(_veiculo.Nome);

            Console.WriteLine(s);
        }
        
        public static RealWorld CriarAutoSocorro(Veiculo veiculo)
        {
            switch (veiculo.Porte)
            {
                case Porte.Pequeno:
                    return new RealWorld(new ConcreteFactories.SocorroVeiculoPequenoFactory(), veiculo);
                case Porte.Medio:
                    return new RealWorld(new ConcreteFactories.SocorroVeiculoMedioFactory(), veiculo);
                case Porte.Grande:
                    return new RealWorld(new ConcreteFactories.SocorroVeiculoGrandeFactory(), veiculo);
                default:
                    return null;
            }
        }
    }
}