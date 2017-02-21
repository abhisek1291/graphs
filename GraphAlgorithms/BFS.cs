using System;
using System.Collections.Generic;

namespace GraphAlgorithms
{
	public class BFS
	{
		public BFS()
		{
		}

		private int[] colors;
		private int[] parents;

		public void computeBFS(GraphAdjList adjLst, 
		                       int V, 
		                       int startVertex,
		                       Dictionary<int, string> map)
		{
			colors = new int[V];
			parents = new int[V];
			initializeArrays(V);

			Queue<int> q = new Queue<int>();
			q.Enqueue(startVertex);
			while (q.Count != 0)
			{
				int element = q.Dequeue();
				colors[element] = 1;

				if (adjLst.getAdj(element).Count != 0)
					foreach (var vertex in adjLst.getAdj(element))
						if (colors[vertex.Item1] == -1)
						{
						colors[vertex.Item1] = 1;
						q.Enqueue(vertex.Item1);
						}

				Console.Write(map[element] + "\t");
			}
		}

		void initializeArrays(int V)
		{
			for (int i = 0; i < V; i++)
			{
				colors[i] = -1;
				parents[i] = -1;
			}
		}
}
}

