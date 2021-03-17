using factory_method.AbstractProduct;
using factory_method.ConcreteProduct;
using factory_method.FactoryMethods;

namespace factory_method.ConcreteCreator
{
    public class SqlFactory : DbFactory
    {
        public SqlFactory()
        {
        }

        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}