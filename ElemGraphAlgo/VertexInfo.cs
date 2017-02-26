namespace ElemGraphAlgo
{
    public class VertexInfo<T> : Vertex<T>
    {
        public Color Color { get; internal set; }
        public decimal Distance { get; internal set; }
        public VertexInfo<T> Parent { get; internal set; }
        public long Degree { get; internal set; }
        public string Id { get; set; }

        public VertexInfo() : base(default(T))
        {
        }
        public VertexInfo(T data) : base(data)
        {
        }
        public override string ToString()
        {
            string parentid = Parent?.Id ?? "null";
            return $"Vertex \"{Id}\":\n\tData: {Data}\n\tColor: {Color}\n\tDistance: {Distance}\n\tParent ID: {parentid}";
        }
        //
    }


}