namespace Graphs.Entities.Directed;

public interface IDirected
{
    public Vertice GetStart();
    public void SetStart(Vertice pVertice);
    public Vertice GetEnd();
    public void SetEnd(Vertice pVertice);
}