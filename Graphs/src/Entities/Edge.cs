namespace Graphs.Entities
{
    public class Edge(Vertice pVertice1, Vertice pVertice2)
    {
        public Vertice Vertice1 { get; } = pVertice1;
        public Vertice Vertice2 { get; } = pVertice2;

        public void RemoveFromVertices()
        {
            Vertice1.RemoveEdge(this);
            Vertice2.RemoveEdge(this);
        }
    }
}