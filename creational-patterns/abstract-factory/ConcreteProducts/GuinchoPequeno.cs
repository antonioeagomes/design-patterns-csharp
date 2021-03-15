using System;

namespace abstract_factory.ConcreteProducts
{
    public class GuinchoPequeno : AbstractProducts.Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte)
        {
        }

        public override void Socorrer(AbstractProducts.Veiculo veiculo)
        {
            Console.WriteLine("Guincho socorrendo carro Pequeno " + veiculo.Nome);
        }
    }

    public class VeiculoPequeno : AbstractProducts.Veiculo
    {
        public VeiculoPequeno(string nome, Porte porte) : base(nome, porte)
        {
        }
    }

}