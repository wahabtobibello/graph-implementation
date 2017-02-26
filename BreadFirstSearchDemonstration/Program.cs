using System;
using System.Collections.Generic;
using System.Linq;
using ElemGraphAlgo;

namespace BreadFirstSearchDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed = 1;
            List<VertexInfo<int>> vertexs =new List<VertexInfo<int>>(8);
            VertexInfo<int> vertex1 = new VertexInfo<int>
            {
                Id = "s",
                Data = new Random(seed++).Next(10, 20)
            };
            vertexs.Add(vertex1);
            for (int i = 0; i < vertexs.Capacity - 1; i++)
            {
                var vertex = new VertexInfo<int>
                {
                    Data = new Random(seed++).Next(10, 20),
                };
                vertexs.Add(vertex);
            }
            vertexs.ElementAt(1).Id = "r";
            vertexs.ElementAt(2).Id = "w";
            vertexs.ElementAt(3).Id = "v";
            vertexs.ElementAt(4).Id = "t";
            vertexs.ElementAt(5).Id = "x";
            vertexs.ElementAt(6).Id = "u";
            vertexs.ElementAt(7).Id = "y";

            UndirectedGraph<int> myGraph = new UndirectedGraph<int>(vertexs);
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(0), vertexs.ElementAt(1)));
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(0), vertexs.ElementAt(2)));
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(1), vertexs.ElementAt(3)));
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(2), vertexs.ElementAt(4)));
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(2), vertexs.ElementAt(5)));
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(4), vertexs.ElementAt(5)));
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(4), vertexs.ElementAt(6)));
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(5), vertexs.ElementAt(7)));
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(5), vertexs.ElementAt(6)));

            Graphs<int>.BreadthFirstSearch(myGraph, myGraph.GetAdjacencyList().Keys.ElementAt(0));
            Console.WriteLine("After Breadth-First Search, We have: ");
            foreach (var key in myGraph.GetAdjacencyList().Keys)
            {
                Console.WriteLine(key + "\n");
            }
            Console.ReadLine();
        }
    }
}
