using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
	/// <summary>
	/// Depth First Search, Topological Sort and Strongly Connected Components
	/// </summary>
	public class DFS
	{
		public DFS()
		{
		}

		private int[] parent;
		private int[] color;
		private int[] discover;
		private int[] finish;
		private int time = 0;

		private LinkedList<int> topologicalSortedGraph = new LinkedList<int>();

		public void computeDFS(GraphAdjList adjList,
		                      int V,
		                      Dictionary<int,string> map,
		                      bool isStronglyConnectedModule)
		{
			time = 0;
			//color[startIndex] = -1;
			if (!isStronglyConnectedModule)
			{
				for (int v = 0; v < V; v++)
					if (color[v] == -1)
						DFSUtil(adjList, map, v, isStronglyConnectedModule);
			}
			else {
				int count = 1;
				List<int> finish_list = new List<int>(finish);
				var sorted = finish_list
							.Select((x, i) => new KeyValuePair<int, int>(x, i))
							.OrderByDescending(x => x.Key)
							.ToList();

				List<int> idx = sorted.Select(x => x.Value).ToList();
				initializeArrays(V);
				foreach (var v in idx)
				{
					//Console.Write(v.ToString() + " ");
					if (color[v] == -1)
					{
						Console.Write("\ncount = " + count++.ToString() + " th strongly connected component : ");
						DFSUtil(adjList, map, v, isStronglyConnectedModule);
					}
				}
			}

		}

		void DFSUtil(GraphAdjList adjList, 
		             Dictionary<int, string> map, 
		             int vertex,
					 bool isStronglyConnectedModule)
		{
			time += 1;
			discover[vertex] = time;
			color[vertex] = 1;

			if (isStronglyConnectedModule)
				Console.Write(vertex.ToString());

			foreach (var v in adjList.getAdj(vertex))
				if (color[v.Item1] == -1)
				{
				parent[v.Item1] = vertex;
				DFSUtil(adjList, map, v.Item1, isStronglyConnectedModule);
				}

			time += 1;
			finish[vertex] = time;
			topologicalSortedGraph.AddFirst(vertex);
		}

		public void printDFS(int vertices)
		{
			Console.WriteLine("\nvertex\tparent\tdiscover\tfinish");
			for (int i = 0; i < vertices; i++)
				Console.WriteLine("\n"+ i + "\t" + parent[i] + "\t" + discover[i] + "\t" + finish[i]);
		}

		public void printTopologicallySorted()
		{
			//LinkedList<int> temp = topologicalSortedGraph;
			Console.WriteLine("\n");
			foreach (var v in topologicalSortedGraph)
				Console.Write(v + " -> ");
			Console.Write("null");
		}

		public void initializeArrays(int V)
		{
			color = new int[V];
			parent = new int[V];
			discover = new int[V];
			finish = new int[V];

			for (int i = 0; i < V; i++)
			{
				color[i] = -1;
				parent[i] = -1;
				discover[i] = -1;
				finish[i] = -1;
			}
		}
	}
}

