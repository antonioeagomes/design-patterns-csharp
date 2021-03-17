using System;
using factory_method.AbstractProduct;

namespace factory_method.ConcreteProduct
{
    public class OracleDbConnector : DbConnector
    {
        public OracleDbConnector(string connectionString) : base(connectionString)
        {
        }

        public override Connection Connect()
        {
            Console.WriteLine("Connecting to Oracle... ");
            Connection con = new Connection(ConnectionString);
            con.Open();
            return con;
        }
    }
}