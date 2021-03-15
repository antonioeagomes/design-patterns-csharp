using abstract_factory.ConcreteProducts;

namespace abstract_factory.AbstractProducts
{
    public abstract class Guincho
    {
        public Porte Porte { get; set; }
        public Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
    }

    public class GuinchoCreator
    {
        public Guincho Criar(Porte porte)
        {

            switch (porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno(porte);
                case Porte.Medio:
                    return new GuinchoMedio(porte);
                case Porte.Grande:
                    return new GuinchoGrande(porte);

                default:
                    return null;
            }
        }

    }
}