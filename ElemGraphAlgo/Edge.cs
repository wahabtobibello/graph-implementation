namespace ElemGraphAlgo
{
    public class Edge<T>
    {
        public VertexInfo<T> FirstNode { get; }
        public VertexInfo<T> SecondNode { get; }
        public double Weight { get; }
        public Edge(VertexInfo<T> firstNode, VertexInfo<T> secondNode, double weight)
        {
            FirstNode = firstNode;
            SecondNode = secondNode;
            Weight = weight;
        }
        public Edge(VertexInfo<T> firstNode, VertexInfo<T> secondNode)
        {
            FirstNode = firstNode;
            SecondNode = secondNode;
            Weight = 0;
        }
    }
}