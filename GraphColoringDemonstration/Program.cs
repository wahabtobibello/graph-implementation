using System;
using System.Collections.Generic;
using System.Linq;
using ElemGraphAlgo;
namespace GraphColoringDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed = 1;
            List<VertexInfo<int>> vertexs = new List<VertexInfo<int>>(11);
            for (int i = 0; i < vertexs.Capacity; i++)
            {
                var vertex = new VertexInfo<int>
                {
                    Data = new Random(seed++).Next(10, 20),
                };
                vertexs.Add(vertex);
            }
            vertexs.ElementAt(0).Id = "A";
            vertexs.ElementAt(1).Id = "B";
            vertexs.ElementAt(2).Id = "C";
            vertexs.ElementAt(3).Id = "D";
            vertexs.ElementAt(4).Id = "E";
            vertexs.ElementAt(5).Id = "F";
            vertexs.ElementAt(6).Id = "G";
            vertexs.ElementAt(7).Id = "H";
            vertexs.ElementAt(8).Id = "I";
            vertexs.ElementAt(9).Id = "J";
            vertexs.ElementAt(10).Id = "K";

            UndirectedGraph<int> myGraph = new UndirectedGraph<int>(vertexs);
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(0), vertexs.ElementAt(1)));//A-B
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(0), vertexs.ElementAt(7)));//A-H
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(1), vertexs.ElementAt(3)));//B-D
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(2), vertexs.ElementAt(3)));//C-D
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(3), vertexs.ElementAt(8)));//D-I
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(3), vertexs.ElementAt(10)));//D-K
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(4), vertexs.ElementAt(5)));//E-F
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(4), vertexs.ElementAt(10)));//E-K
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(5), vertexs.ElementAt(6)));//F-G
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(6), vertexs.ElementAt(7)));//G-H
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(6), vertexs.ElementAt(10)));//G-K
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(7), vertexs.ElementAt(8)));//H-I
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(7), vertexs.ElementAt(9)));//H-J
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(7), vertexs.ElementAt(10)));//H-K
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(8), vertexs.ElementAt(9)));//I-J
            myGraph.AddEdge(new UndirectedEdge<int>(vertexs.ElementAt(9), vertexs.ElementAt(10)));//J-K

            Graphs<int>.GraphColoring(myGraph);
            Console.WriteLine("After Graph Coloring, We have: ");
            foreach (var key in myGraph.GetAdjacencyList().Keys)
            {
                Console.WriteLine(key + "\n");
            }
            Console.WriteLine($"The mininum number of colors needed is {myGraph.NumberOfColorsUsed}\n");
            Console.ReadLine();
        }
    }
}
