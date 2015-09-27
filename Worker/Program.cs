using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = ActorSystem.Create("ClusterSystem");
            Console.ReadLine();
        }
    }
}
