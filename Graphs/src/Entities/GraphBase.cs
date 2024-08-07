using Graphs.src.Entities;

namespace Graphs.src.Interfaces
{
    public abstract class GraphBase
    {
        public List<Edge> Edges { get; } = [];
        public List<Vertice> Vertices{ get; } = [];
        public abstract void AddEdge(Edge pEdge);
        public abstract void RemoveEdge(Edge pEdge);
        public abstract void AddEdge(Vertice pVertice1, Vertice pVertice2);
        public abstract void RemoveEdge(Vertice pVertice1, Vertice pVertice2);
        public abstract void AddVertice(Vertice pVertice);
        public abstract void RemoveVertice(Vertice pVertice);
    }
}