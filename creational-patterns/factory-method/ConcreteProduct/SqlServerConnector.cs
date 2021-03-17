using System;
using factory_method.AbstractProduct;

namespace factory_method.ConcreteProduct
{
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString)
        {
        }

        public override Connection Connect()
        {
            Console.WriteLine("Connecting to MS Sql Server... ");
            Connection con = new Connection(ConnectionString);
            con.Open();
            return con;
        }
    }
}