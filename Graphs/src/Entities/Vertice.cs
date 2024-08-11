using System.Collections.Generic;

namespace Graphs.Entities
{
    public class Vertice
    {
        private List<Edge> Edges { get; } = [];
        public void AddEdge(Edge pEdge)
        {
            Edges.Add(pEdge);
        }
        public void RemoveEdge(Edge pEdge)
        {
            Edges.Remove(pEdge);
        }

        public int getGrade()
        {
            return Edges.Count;
        }
    }
}