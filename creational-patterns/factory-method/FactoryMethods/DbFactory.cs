using factory_method.AbstractProduct;
using factory_method.ConcreteCreator;

namespace factory_method.FactoryMethods
{
    /*
    * Abstract creator
    */

    public abstract class DbFactory
    {
        //Factory Method
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase dataBase) {
            if (dataBase == DataBase.SqlServer)
            {
                return new SqlFactory();
            }

            if (dataBase == DataBase.Oracle)
            {
                return new OracleFactory();
            }

            throw new System.Exception("Database does no exist");
        }
        
    }
}