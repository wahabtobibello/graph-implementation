namespace ElemGraphAlgo
{
    public class DirectedEdge<T> : Edge<T>
    {
        public DirectedEdge(VertexInfo<T> fromNode, VertexInfo<T> toNode, double weight) : base(fromNode, toNode, weight)
        {
        }
        public DirectedEdge(VertexInfo<T> fromNode, VertexInfo<T> toNode) : base(fromNode, toNode)
        {
        }
    }
}