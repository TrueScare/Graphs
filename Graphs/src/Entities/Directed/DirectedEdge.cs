namespace Graphs.Entities.Directed;

public class DirectedEdge(Vertice pVertice1, Vertice pVertice2) : Edge(pVertice1, pVertice2), IDirected
{
    public Vertice GetStart()
    {
        return Vertice1;
    }

    public void SetStart(Vertice pVertice)
    {
        Vertice1 = pVertice;
    }

    public Vertice GetEnd()
    {
        return Vertice2;
    }

    public void SetEnd(Vertice pVertice)
    {
        Vertice2 = pVertice;
    }
}