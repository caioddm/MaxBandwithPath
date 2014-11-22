using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vertex
    {
        public int Key { get; private set; }
        public List<Edge> Edges { get; private set; }

        public void AddEdge(Edge edge)
        {
            if (this.Edges.IsNullOrEmpty())
                this.Edges = new List<Edge>();

            if(!Edges.Exists(e => e.IsSameUndirectedEdge(edge)))
                this.Edges.Add(edge);
        }

        public void RemoveEdge(Vertex v1, Vertex v2)
        {
            if (!this.Edges.IsNullOrEmpty() && this.Edges.Exists(e => e.IsSameUndirectedEdge(v1, v2)))
                this.Edges.RemoveAll(e => e.IsSameUndirectedEdge(v1, v2));
        }
    }
}
