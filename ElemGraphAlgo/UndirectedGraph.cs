using System.Collections.Generic;

namespace ElemGraphAlgo
{
    public class UndirectedGraph<T> : Graph<T>
    {
        public long NumberOfColorsUsed { get; internal set; }

        public UndirectedGraph(int capacity):base(capacity)
        {    
        }
        public UndirectedGraph(List<VertexInfo<T>> vertexList) : base(vertexList)
        {
        }
        public void AddEdge(UndirectedEdge<T> edge)
        {
            AdjacencyList[edge.FirstNode].AddLast(edge.SecondNode);
            edge.FirstNode.Degree += 1;
            if (edge.FirstNode == edge.SecondNode) return;
            edge.SecondNode.Degree += 1;
            AdjacencyList[edge.SecondNode].AddLast(edge.FirstNode);
        }
        public bool RemoveEdge(UndirectedEdge<T> edge)
        {
            var removed = AdjacencyList[edge.FirstNode].Remove(edge.SecondNode);
            if(removed) edge.FirstNode.Degree -= 1;
            if (edge.FirstNode == edge.SecondNode) return removed;
            removed = removed && AdjacencyList[edge.SecondNode].Remove(edge.FirstNode);
            if (removed) edge.SecondNode.Degree -= 1;
            return removed;
        }

        public bool HasEdge(UndirectedEdge<T> edge)
        {
            if (AdjacencyList.ContainsKey(edge.FirstNode) && AdjacencyList.ContainsKey(edge.SecondNode))
                return AdjacencyList[edge.FirstNode].Contains(edge.SecondNode) && AdjacencyList[edge.SecondNode].Contains(edge.FirstNode);
            return false;
        }
    }
}