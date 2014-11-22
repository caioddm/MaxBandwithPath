using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    enum EGraphType
    {
        DegreeSix,
        TwentyPercent
    }
    public class Graph
    {
        public List<Vertex> Vertices { get; private set; }

        public static Graph GenerateGraph(EGraphType graphType)
        {
            Graph g = null;
            switch (graphType)
            {
                case EGraphType.DegreeSix:
                    g = GraphGenerator.GenerateDegreeSixGraph();
                    break;
                case EGraphType.TwentyPercent:
                    g = GraphGenerator.GenerateTwentyPercentGraph();
                    break;
            }

            return g;
        }
    }
}
