namespace ElemGraphAlgo
{
    public class UndirectedEdge<T> : Edge<T>
    {
        public UndirectedEdge(VertexInfo<T> firstNode, VertexInfo<T> secondNode, double weight) : base(firstNode, secondNode, weight)
        {
        }
        public UndirectedEdge(VertexInfo<T> firstNode, VertexInfo<T> secondNode) : base(firstNode, secondNode)
        {
        }
    }
}