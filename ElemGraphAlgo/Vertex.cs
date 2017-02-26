namespace ElemGraphAlgo
{
    public abstract class Vertex<T>
    {
        public T Data { get; set; }

        protected Vertex(T data)
        {
            Data = data;
        }
    }
}