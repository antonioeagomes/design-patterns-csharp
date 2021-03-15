using abstract_factory.AbstractProducts;

namespace abstract_factory.AbstractFactories
{
    /* AbstractFactory 
    * Cria mais de um tipo de família de produto
    * Produto neste caso, é algo produzido no final.
    * Podem derivar do mesmo tipo, ser da mesma família ou ter alguma relação.
    * Um interage com o outro.
    */
    public abstract class ContinentAbstractFactory
    {
        /* Na fábrica Continente existem herbívors e carnívoros */
        public abstract AbstractProducts.HerbivoreAbstractProduct CreateHerbivore();

        public abstract AbstractProducts.CarnivoreAbstractProduct CreateCarnivore();
    }
}