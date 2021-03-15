namespace abstract_factory.AbstractProducts
{
    public abstract class Veiculo
    {
        protected Veiculo(string nome, Porte porte) {
            Nome = nome;
            Porte = porte;
        }

        public string Nome { get; private set; }
        public Porte Porte { get; private set; }
    }

    public class VeiculoCreator{
        public Veiculo Criar(string nome, Porte porte) {
            
            switch (porte)
            {
                case Porte.Pequeno:
                    return new ConcreteProducts.VeiculoPequeno(nome, porte);

                case Porte.Medio:
                    return new ConcreteProducts.VeiculoMedio(nome, porte);

                case Porte.Grande:
                    return new ConcreteProducts.VeiculoGrande(nome, porte);
                
                default:
                    return null;
            }
        }
        
    }
}