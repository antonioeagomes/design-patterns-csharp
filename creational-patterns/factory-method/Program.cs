using System;
using factory_method.FactoryMethods;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mssql = DbFactory.Database(DataBase.SqlServer)
                .CreateConnector("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;")
                .Connect();

            mssql.ExecuteCommand("Select * from myMSSqlServerTable");
            mssql.Close();

            Console.WriteLine("--------------------------------------------");

            var oracle = DbFactory.Database(DataBase.Oracle)
                .CreateConnector("Data Source=MyOracleDB;Integrated Security=yes;")
                .Connect();

            oracle.ExecuteCommand("Select * from myOracleTable");
            oracle.Close();
        }
    }

    public enum DataBase
    {
        Oracle,
        SqlServer
    }
}
