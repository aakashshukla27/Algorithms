using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.Helper
{
    class AdjacencyList
    {
        private int size;
        LinkedList<int>[] adjList;
       

        public AdjacencyList(int n)
        {
            adjList = new LinkedList<int>[n];
            size = n;
            for (int i = 0; i < n; i++)
            {
                adjList[i] = new LinkedList<int>();               
            }
        }
        public void addEdge(int u, int v)
        {
            adjList[u].AddLast(v);
            //adjList[v].AddLast(u);
        }

        public void printGraph()
        {
            for(int i=0; i<adjList.Length; i++)
            {
                Console.WriteLine("Adjacency List of vertex " + i);
                Console.Write("head");
                foreach(var item in adjList[i])
                {
                    Console.Write(" -> " + item);
                }
                Console.WriteLine();
            }
        }

        public void BreadthFirstSearch(int s)
        {
            bool[] visited = new bool[size];
            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
            }

            Console.WriteLine("BFS of graph is:\n");
            Queue<int> queue = new Queue<int>();
            visited[s] = true;
            queue.Enqueue(s);
            
            while(queue.Any())
            {
                s = queue.Dequeue();
                Console.Write(s + " ");
                LinkedList<int> list = adjList[s];
                foreach (var item in list)
                {
                    if (!visited[item])
                    {
                        visited[item] = true;
                        queue.Enqueue(item);
                    }
                }

            }
        }

        public void DepthFirstSearch(int s)
        {

        }

    }
}
