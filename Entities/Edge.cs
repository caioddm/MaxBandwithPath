using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InvalidEdgeException : Exception { }
    public class Edge
    {
        public int Weight { get; private set; }
        public Vertex Vertex1 { get; private set; }
        public Vertex Vertex2 { get; private set; }

        public Edge(int weight, Vertex v1, Vertex v2)
        {
            if (v1 == null || v2 == null || (v1.Key == v2.Key))
                throw new InvalidEdgeException();

            this.Weight = weight;
            this.Vertex1 = v1;
            this.Vertex2 = v2;
        }

        public bool IsSameUndirectedEdge(Edge edge)
        {
            return IsSameUndirectedEdge(edge.Vertex1, edge.Vertex2);
        }

        public bool IsSameUndirectedEdge(Vertex v1, Vertex v2)
        {
            return (this.Vertex1.Key == v1.Key && this.Vertex2.Key == v2.Key) ||
                (this.Vertex1.Key == v2.Key && this.Vertex2.Key == v1.Key);
        }
    }
}
