using Graphs.src.Interfaces;

namespace Graphs.src.Entities
{
    public class Graph : GraphBase
    {
        public override void AddEdge(Edge pEdge)
        {
            if (!Vertices.Contains(pEdge.Vertice1) || !Vertices.Contains(pEdge.Vertice2))
            {
                return;
            }

            Edges.Add(pEdge);
        }

        public override void RemoveEdge(Edge pEdge)
        {
            pEdge.RemoveFromVertices();
            Edges.Remove(pEdge);
        }

        public override void AddEdge(Vertice pVertice1, Vertice pVertice2)
        {
            if (!Vertices.Contains(pVertice1) || !Vertices.Contains(pVertice2))
            {
                return;
            }
            var lEdge = new Edge(pVertice1, pVertice2);
            pVertice1.AddEdge(lEdge);
            pVertice2.AddEdge(lEdge);
            Edges.Add(lEdge);
        }

        public override void RemoveEdge(Vertice pVertice1, Vertice pVertice2)
        {
            foreach (var lEdge in Edges)
            {
                if (pVertice1 == lEdge.Vertice1 && pVertice2 == lEdge.Vertice2
                    || pVertice2 == lEdge.Vertice1 && pVertice1 == lEdge.Vertice2)
                {
                    RemoveEdge(lEdge);
                }
            }
        }

        public override void AddVertice(Vertice pVertice)
        {
            if (!Vertices.Contains(pVertice))
            {
                Vertices.Add(pVertice);
            }
        }

        public override void RemoveVertice(Vertice pVertice)
        {
            Vertices.Remove(pVertice);
            foreach (var lEdge in Edges)
            {
                if (pVertice == lEdge.Vertice1 || pVertice == lEdge.Vertice2)
                {
                    RemoveEdge(lEdge);
                }
            }
        }
    }
}