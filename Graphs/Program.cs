using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphs.Helper;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjacencyList adj = new AdjacencyList(5);
            adj.addEdge(0, 1);
            adj.addEdge(0, 4);
            adj.addEdge(1, 2);
            adj.addEdge(1, 3);
            adj.addEdge(1, 4);
            adj.addEdge(2, 3);
            adj.addEdge(3, 4);

            adj.printGraph();
            adj.BreadthFirstSearch(2);
            Console.ReadKey();
        }
    }
}
