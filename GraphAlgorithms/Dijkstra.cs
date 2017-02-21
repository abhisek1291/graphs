using System;
using System.Collections.Generic;

namespace GraphAlgorithms
{
	public class Dijkstra
	{
		readonly int V;
		int[] parents;
		int[] distances;
		List<Tuple<int, int, int>> edges;
		PriorityQueue Q;

		public Dijkstra(int vertices)
		{
			V = vertices;
			parents = new int[V];
			distances = new int[V];
			edges = new List<Tuple<int, int, int>>();
			Q = new PriorityQueue(V);
		}

		public void computeShortestPaths(GraphAdjList adjList,
						 int source)
		{
			initializeSingleSource(source);
			extractEdges(adjList);

			for (int i = 0; i < V; i++)
				Q.insertHeap(new HeapClass() { data = i, priority = distances[i] });

			while (Q.count() != 0)
			{
				HeapClass elem = Q.getMax();
				foreach (var v in adjList.getAdj(elem.data))
					relax(elem.data, v.Item1, v.Item2);
			}

			Console.WriteLine("\nvertex\tparent\tdistance");
			for (int i = 0; i < V; i++)
			{
				Console.WriteLine(i + "\t" + parents[i] + "\t" + (-1 * distances[i]).ToString());
			}
		}

		void relax(int u, int v, int weight)
		{
			//change the - and > sign to the opposite if using a min priority queue
			if (distances[u] - weight > distances[v]) 
			{
				distances[v] = distances[u] - weight;
				//need to update priority queue
				Q.updatePriority(new HeapClass() { data = v, priority = distances[v] });
				parents[v] = u;
			}
		}

		void extractEdges(GraphAdjList adjList)
		{
			for (int i = 0; i < V; i++)
			{
				foreach (var v in adjList.getAdj(i))
				{
					edges.Add(new Tuple<int, int, int>(i, v.Item1, v.Item2));
				}
			}
		}

		void initializeSingleSource(int source)
		{
			for (int i = 0; i < V; i++)
			{
				parents[i] = -1;
				distances[i] = int.MinValue;
			}
			distances[source] = 0;
		}
	}
}

