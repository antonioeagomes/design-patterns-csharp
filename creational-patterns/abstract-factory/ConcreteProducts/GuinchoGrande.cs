namespace abstract_factory.ConcreteProducts
{
    public class GuinchoGrande : AbstractProducts.Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte)
        {
        }

        public override void Socorrer(AbstractProducts.Veiculo veiculo)
        {
            throw new System.NotImplementedException();
        }
    }

    public class VeiculoGrande : AbstractProducts.Veiculo
    {
        public VeiculoGrande(string nome, Porte porte) : base(nome, porte)
        {
        }
    }
}