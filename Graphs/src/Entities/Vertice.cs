namespace Graphs.src.Entities
{
    public class Vertice
    {
        public List<Edge> Edges { get; } = [];
        public void AddEdge(Edge pEdge)
        {
            Edges.Add(pEdge);
        }
        public void RemoveEdge(Edge pEdge)
        {
            Edges.Remove(pEdge);
        }
    }
}