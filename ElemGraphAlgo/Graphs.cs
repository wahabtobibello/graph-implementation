using System;
using System.Collections.Generic;
using System.Linq;

namespace ElemGraphAlgo
{
    public static class Graphs<T>
    {
        public static Dictionary<int, Color> Colors = new Dictionary<int, Color>()
        {
            {1, Color.Black},
            {2, Color.Blue},
            {3, Color.Gray},
            {4, Color.Green},
            {5, Color.Orange},
            {6, Color.Purple},
            {7, Color.Red},
            {8, Color.White},
            {9, Color.Yellow}
        };
        public static void BreadthFirstSearch(Graph<T> graph, VertexInfo<T> source)
        {
            foreach (var u in graph.GetAdjacencyList().Keys)
            {
                u.Color = Color.White;
                u.Distance = decimal.MaxValue;
                u.Parent = null;
            }
            source.Color = Color.Gray;
            source.Distance = 0;
            source.Parent = null;
            Queue<VertexInfo<T>> queue = new Queue<VertexInfo<T>>();
            queue.Enqueue(source);
            while (queue.Count > 0)
            {
                VertexInfo<T> u = queue.Dequeue();
                foreach (var v in graph.GetAdjacencyList()[u])
                {
                    if (v.Color != Color.White) continue;
                    v.Color = Color.Gray;
                    v.Distance = u.Distance + 1;
                    v.Parent = u;
                    queue.Enqueue(v);
                }
                u.Color = Color.Black;
            }
        }

        public static void GraphColoring(UndirectedGraph<T> graph)
        {
            var sortedVertexs = new SortedSet<VertexInfo<T>>(graph.GetAdjacencyList().Keys,
                new SortInDescDegree());
            var colorNumber = 1;
            var rejects = new HashSet<VertexInfo<T>>();
            while (sortedVertexs.Count > 0)
            {
                for (var i = 0; i < sortedVertexs.Count; i++)
                {
                    if (rejects.Contains(sortedVertexs.ElementAt(i))) continue;
                    sortedVertexs.ElementAt(i).Color = Colors[colorNumber];
                    rejects.UnionWith(graph.GetAdjacencyList()[sortedVertexs.ElementAt(i)]);
                    sortedVertexs.Remove(sortedVertexs.ElementAt(i));
                    i--;
                }
                graph.NumberOfColorsUsed++;
                rejects.Clear();
                colorNumber++;
            }
        }

        private class SortInDescDegree : IComparer<VertexInfo<T>>
        {
            int IComparer<VertexInfo<T>>.Compare(VertexInfo<T> x, VertexInfo<T> y)
            {
                if (x.Degree == y.Degree) return String.Compare(x.Id, y.Id, StringComparison.Ordinal);
                return (int) (y.Degree - x.Degree);
            }
        }
    }
}
