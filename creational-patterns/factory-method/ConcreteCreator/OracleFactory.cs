using factory_method.AbstractProduct;
using factory_method.ConcreteProduct;
using factory_method.FactoryMethods;

namespace factory_method.ConcreteCreator
{
    public class OracleFactory : DbFactory
    {
        public OracleFactory()
        {
        }

        public override DbConnector CreateConnector(string connectionString)
        {
            return new OracleDbConnector(connectionString);
        }
    }
}