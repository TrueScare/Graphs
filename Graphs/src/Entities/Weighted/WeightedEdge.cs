namespace Graphs.Entities.Weighted;

public class WeightedEdge(Vertice pVertice1, Vertice pVertice2, int pWeight) : Edge(pVertice1, pVertice2), IWeighted
{
    protected float Weight = pWeight;

    public float GetWeight()
    {
        return Weight;
    }
}