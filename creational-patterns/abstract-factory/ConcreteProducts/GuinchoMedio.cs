namespace abstract_factory.ConcreteProducts
{
    public class GuinchoMedio : AbstractProducts.Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte)
        {
        }

        public override void Socorrer(AbstractProducts.Veiculo veiculo)
        {
            throw new System.NotImplementedException();
        }
    }

    public class VeiculoMedio : AbstractProducts.Veiculo
    {
        public VeiculoMedio(string nome, Porte porte) : base(nome, porte)
        {
        }
    }
}