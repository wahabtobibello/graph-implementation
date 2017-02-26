using System.Collections.Generic;

namespace ElemGraphAlgo
{
    public class DirectedGraph<T> : Graph<T>
    {
        public DirectedGraph(int capacity) : base(capacity)
        {
        }
        public DirectedGraph(List<VertexInfo<T>> vertexList) : base(vertexList)
        {
        }
        public void AddEdge(DirectedEdge<T> edge)
        {
            AdjacencyList[edge.FirstNode].AddLast(edge.SecondNode);
        }
        public bool RemoveEdge(VertexInfo<T> start, VertexInfo<T> end)
        {
            if (!AdjacencyList[start].Remove(end)) return false;
            return true;
        }
        public bool HasEdge(DirectedEdge<T> edge)
        {
            if (AdjacencyList.ContainsKey(edge.FirstNode))
                return AdjacencyList[edge.FirstNode].Contains(edge.SecondNode);
            return false;
        }
    }
}