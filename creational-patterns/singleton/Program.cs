using System;
using System.Collections.Generic;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Mesma instância");
            }

            var balancer = LoadBalancer.GetLoadBalancer();

            for (int i = 0; i < 15; i++)
            {
                var server = balancer.NextServer;
                Console.WriteLine("Disparando request para " + server.Name + " " + server.Id);
            }
        }
    }

    internal sealed class LoadBalancer
    {
        public static readonly LoadBalancer Instance = new LoadBalancer();

        private readonly List<Server> _servers;
        private readonly Random _rnd = new Random();

        private LoadBalancer(){
            _servers = new List<Server> {
                new Server { Id = Guid.NewGuid(), Name = "Server 1", IP = "192.168.0.15" },
                new Server { Id = Guid.NewGuid(), Name = "Server 4", IP = "192.168.0.34" },
                new Server { Id = Guid.NewGuid(), Name = "Server 2", IP = "192.168.0.255" },
                new Server { Id = Guid.NewGuid(), Name = "Server 3", IP = "192.168.0.90" },
            };
        }
        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer {
            get {
                var r = _rnd.Next(_servers.Count);
                return _servers[r];
            }
        }
    }

    public class Server
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string IP { get; set; }
    }
}
