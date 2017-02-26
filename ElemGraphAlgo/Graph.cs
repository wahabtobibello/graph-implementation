using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ElemGraphAlgo
{
    public abstract class Graph<T>
    {
        protected readonly Dictionary<VertexInfo<T>, LinkedList<VertexInfo<T>>> AdjacencyList;

        protected Graph(int capacity)
        {
            AdjacencyList = new Dictionary<VertexInfo<T>, LinkedList<VertexInfo<T>>>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                AdjacencyList.Add(new VertexInfo<T>(), new LinkedList<VertexInfo<T>>());
            }
        }

        protected Graph(List<VertexInfo<T>> vertexList)
        {
            AdjacencyList = new Dictionary<VertexInfo<T>, LinkedList<VertexInfo<T>>>(vertexList.Count);
            for (int i = 0; i < vertexList.Count; i++)
            {
                AdjacencyList.Add(vertexList.ElementAt(i), new LinkedList<VertexInfo<T>>());
            }
        }

        public int Size => AdjacencyList.Count;

        public ReadOnlyDictionary<VertexInfo<T>, LinkedList<VertexInfo<T>>> GetAdjacencyList()
        {
            return new ReadOnlyDictionary<VertexInfo<T>, LinkedList<VertexInfo<T>>>(AdjacencyList);
        }
    }
}