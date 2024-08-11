using System.Collections.Generic;

namespace Graphs.Entities
{
    public abstract class GraphBase
    {
        protected List<Edge> Edges { get; } = [];
        protected List<Vertice> Vertices{ get; } = [];
        public abstract void AddEdge(Edge pEdge);
        public abstract void RemoveEdge(Edge pEdge);
        public abstract void AddEdge(Vertice pVertice1, Vertice pVertice2);
        public abstract void RemoveEdge(Vertice pVertice1, Vertice pVertice2);
        public abstract void AddVertice(Vertice pVertice);
        public abstract void RemoveVertice(Vertice pVertice);
    }
}