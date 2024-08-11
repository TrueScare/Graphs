using Graphs.Entities.Directed;
using Graphs.Entities.Weighted;

namespace Graphs.Entities;

public class WeightedDirectedEdge(Vertice pVertice1, Vertice pVertice2, float pWeight) : DirectedEdge(pVertice1, pVertice2), IWeighted
{
    protected float Weight = pWeight;

    public float GetWeight()
    {
        return Weight;
    }
}