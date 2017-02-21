using System;
using System.Collections.Generic;

namespace GraphAlgorithms
{
	public class BellmanFord
	{
		readonly int V;
		int[] parents;
		int[] distances;
		List<Tuple<int, int, int>> edges;

		public BellmanFord(int vertices)
		{
			V = vertices;
			parents = new int[V];
			distances = new int[V];
			edges = new List<Tuple<int, int, int>>();
		}

		public void computeShortestPaths(GraphAdjList adjList,
		                         int source)
		{
			initializeSingleSource(source);
			extractEdges(adjList);

			for (int i = 1; i < V; i++)
			{
				foreach (var edge in edges)
				{
					relax(edge.Item1, edge.Item2, edge.Item3);
				}
			}

			foreach (var edge in edges)
			{
				if (distances[edge.Item1] + edge.Item3 < distances[edge.Item2])
				{
					Console.WriteLine("has cycle, cant compute. breaking.");
					break;
				}
			}

			//print distances
			Console.WriteLine("\nvertex\tparent\tdistance");
			for (int i = 0; i < V; i++)
			{
				Console.WriteLine(i + "\t" + parents[i] + "\t" + distances[i]);
			}
		}

		void relax(int u, int v, int weight) 
		{
			//int test = distances[u] + weight;
			//Console.WriteLine("rhs : " + distances[v] + "\tlhs : " + test);
			if (distances[u] + weight < distances[v])
			{
				//Console.WriteLine("rhs : " + distances[v] + "\tlhs : " + distances[u] + weight);
				distances[v] = distances[u] + weight;
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
				distances[i] = int.MaxValue;
			}
			distances[source] = 0;
		}
	}
}

