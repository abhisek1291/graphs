using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
	public class GraphAdjList
	{
		private readonly int V; // # of vertices
		private readonly List<Tuple<int,int>>[] adjList;

		public GraphAdjList(int v)
		{
			V = v;
			adjList = new List<Tuple<int, int>>[V];

			for (int i = 0; i < adjList.Length; i++)
				adjList[i] = new List<Tuple<int, int>>();
		}

		public void addEdge(int u, int v, int weight, bool isDirectedEdge)
		{
			if (isDirectedEdge)
			{
				if (!adjList.ElementAt(u).Contains(new Tuple<int, int>(v, weight)))
					adjList.ElementAt(u).Add(new Tuple<int, int>(v, weight));
			}
			else {
				if (!adjList.ElementAt(u).Contains(new Tuple<int, int>(v, weight)))
					adjList.ElementAt(u).Add(new Tuple<int, int>(v, weight));

				if (!adjList.ElementAt(v).Contains(new Tuple<int, int>(u, weight)))
					adjList.ElementAt(v).Add(new Tuple<int, int>(u, weight));
			}
		}

		//public void hasEdge()
		//{
		//}

		public List<Tuple<int,int>> getAdj(int v)
		{
			return adjList.ElementAt(v);
		}

		public int numberOfVertices() {
			return V;
		}
	}
}

