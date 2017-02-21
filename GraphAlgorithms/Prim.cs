using System;
using System.Collections.Generic;

namespace GraphAlgorithms
{
	public class Prim
	{
		private readonly int V;
		private int[] parents;
		PriorityQueue Q;
		List<Tuple<int, int, int>> edges;

		public Prim(int vertices)
		{
			V = vertices;
			parents = new int[V];
			Q = new PriorityQueue(vertices);
			edges = new List<Tuple<int, int, int>>();
		}

		public void computeMST(GraphAdjList adjList, 
		                       int start)
		{
			initialize(adjList);

			Q.updatePriority(new HeapClass() { 
				data = start, 
				priority = 0 
			});

			while (Q.count() != 0)
			{
				HeapClass priorityElement = Q.getMax();
				foreach (var v in adjList.getAdj(priorityElement.data))
				{
					if (Q.contains(v.Item1) && -1 * v.Item2 > Q.getPriority(v.Item1))
					{
						Q.updatePriority(new HeapClass()
						{
							data = v.Item1,
							priority = -1 * v.Item2
						});

						parents[v.Item1] = priorityElement.data;
					}
				}
			}

			Console.WriteLine("\nvertex\tparent");
			for (int i = 0; i < V; i++)
				Console.WriteLine("\n" + i + "\t\t" + parents[i]);
		}

		private void initialize(GraphAdjList adjList)
		{
			for (int i = 0; i < V; i++)
			{
				foreach (var v in adjList.getAdj(i))
				{
					if (!(edges.Contains(new Tuple<int, int, int>(i, v.Item1, v.Item2)) ||
						  edges.Contains(new Tuple<int, int, int>(v.Item1, i, v.Item2))))
					{
						edges.Add(new Tuple<int, int, int>(i, v.Item1, v.Item2));
					}
				}
			}

			for (int i = 0; i < V; i++)
			{
				Q.insertHeap(new HeapClass() { data = i, priority = -1000 });
				parents[i] = -1;
			}
		}
	}
}

