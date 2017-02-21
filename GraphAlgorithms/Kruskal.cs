using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
	public class Kruskal
	{
		public Kruskal()
		{
		}

		int V;
		UnionFind uf = new UnionFind();
		List<Tuple<int, int, int>> finalEdges = new List<Tuple<int, int, int>>();

		public void computeMST(GraphAdjList adjList,
		                      int vertices)
		{
			V = vertices;
			initializeArrays();
			List<Tuple<int, int, int>> edges = new List<Tuple<int, int, int>>();
			for (int i = 0; i < vertices; i++)
			{
				foreach (var v in adjList.getAdj(i))
				{
					if (!(edges.Contains(new Tuple<int, int, int>(i, v.Item1, v.Item2)) || 
					      edges.Contains(new Tuple<int, int, int>(v.Item1, i, v.Item2))))
						edges.Add(new Tuple<int, int, int>(i, v.Item1, v.Item2));
				}
			}

			List<Tuple<int, int, int>> sortedEdges = new List<Tuple<int, int, int>>(edges.OrderBy(k => k.Item3));

			foreach (var edge in sortedEdges)
			{
				if (!findCycle(edge))
					finalEdges.Add(edge);
			}

			foreach(var v in finalEdges.OrderBy(k => k.Item1.ToString() + k.Item2.ToString()))
				Console.WriteLine(v.Item1 + "\t" + v.Item2 + "\t" + v.Item3 + "\n");
		}

		private bool findCycle(Tuple<int, int, int> edge)
		{
			int parent1 = uf.findSet(edge.Item1);
			int parent2 = uf.findSet(edge.Item2);

			bool hasCycle = (parent1 == parent2) ? true : false;
			uf.union(edge.Item1, edge.Item2);
			return hasCycle;
		}

		private void initializeArrays()
		{
			for (int i = 0; i < V; i++)
				uf.makeSet(i);

			//uf.printMap();
		}
	}
}

