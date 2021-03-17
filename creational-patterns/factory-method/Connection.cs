using System;

namespace factory_method
{
    public class Connection
    {
        public string ConnectionString {get;set;}
        public bool Opened {get;set;}

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void ExecuteCommand(string command) {
            Console.WriteLine("Command to execute: " + command);
        }

        public void Open() {
            Opened = true;
            Console.WriteLine("Connection is open");
        }

        public void Close() {
            Opened = false;
            Console.WriteLine("Connection is closed");
        }
    }
}