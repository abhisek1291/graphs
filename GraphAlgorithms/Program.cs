using System;
using System.Collections.Generic;

namespace GraphAlgorithms
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Dictionary<int, string> map = new Dictionary<int, string>();
			map.Add(0, "S");
			map.Add(1, "T");
			map.Add(2, "X");
			map.Add(3, "Y");
			map.Add(4, "Z");
			//map.Add(5, "F");
			//map.Add(6, "G");
			//map.Add(7, "H");

			//GraphAdjList mainGraph = new GraphAdjList(7);
			//mainGraph.addEdge(0, 6);
			//mainGraph.addEdge(0, 1);
			//mainGraph.addEdge(0, 2);
			//mainGraph.addEdge(0, 3);

			//mainGraph.addEdge(1, 6);
			//mainGraph.addEdge(1, 0);
			//mainGraph.addEdge(1, 2);
			//mainGraph.addEdge(1, 5);

			//mainGraph.addEdge(2, 6);
			//mainGraph.addEdge(2, 0);
			//mainGraph.addEdge(2, 1);
			//mainGraph.addEdge(2, 4);

			//mainGraph.addEdge(3, 0);

			//mainGraph.addEdge(4, 2);
			//mainGraph.addEdge(5, 1);

			//mainGraph.addEdge(6, 1);
			//mainGraph.addEdge(6, 2);
			//mainGraph.addEdge(6, 5);
			//mainGraph.addEdge(6, 0);

			int numberOfVertices = 5;
			GraphAdjList mainGraph = new GraphAdjList(numberOfVertices);
			//mainGraph.addEdge(0, 1, 0, false);

			//mainGraph.addEdge(1, 4, 0, false);
			//mainGraph.addEdge(1, 5, 0, false);

			//mainGraph.addEdge(2, 6, 0, false);
			//mainGraph.addEdge(2, 3, 0, false);

			//mainGraph.addEdge(3, 2, 0, false);
			//mainGraph.addEdge(3, 7, 0, false);

			//mainGraph.addEdge(4, 0, 0, false);
			//mainGraph.addEdge(4, 5, 0, false);

			//mainGraph.addEdge(5, 6, 0, false);

			//mainGraph.addEdge(6, 7, 0, false);
			//mainGraph.addEdge(6, 5, 0, false);

			//mainGraph.addEdge(7, 7, 0, false);

			//GraphAdjList transposeGraph = new GraphAdjList(numberOfVertices);
			//for (int i = 0; i < numberOfVertices; i++)
			//{
			//	foreach (var j in mainGraph.getAdj(i))
			//	{
			//		transposeGraph.addEdge(j.Item1, i, j.Item2, false);
			//	}
			//}

			//int queryIndex = 1;
			//Console.WriteLine(map[queryIndex] + "'s Friends : ");
			//List<int> friends = mainGraph.getAdj(queryIndex);

			//foreach (var v in friends)
			//	Console.WriteLine("\n" + map[v]);

			//BFS oBFS = new BFS();
			//Console.WriteLine("\n\nstart vertex : AB, BFS is : ");
			//oBFS.computeBFS(mainGraph, numberOfVertices, 0, map);

			//Console.WriteLine("\n\nstart vertex : SRP, BFS is : ");
			//oBFS.computeBFS(mainGraph, numberOfVertices, 5, map);

			//mainGraph.addEdge(0, 1, 4, false);
			//mainGraph.addEdge(0, 7, 8, false);

			//mainGraph.addEdge(1, 7, 11, false);
			//mainGraph.addEdge(1, 2, 8, false);

			//mainGraph.addEdge(2, 1, 8, false);
			//mainGraph.addEdge(2, 3, 7, false);
			//mainGraph.addEdge(2, 5, 4, false);
			//mainGraph.addEdge(2, 8, 2, false);

			//mainGraph.addEdge(3, 2, 7, false);
			//mainGraph.addEdge(3, 4, 9, false);
			//mainGraph.addEdge(3, 5, 14, false);

			//mainGraph.addEdge(4, 3, 9, false);
			//mainGraph.addEdge(4, 5, 10, false);

			//mainGraph.addEdge(5, 2, 4, false);
			//mainGraph.addEdge(5, 3, 14, false);
			//mainGraph.addEdge(5, 4, 10, false);
			//mainGraph.addEdge(5, 6, 2, false);

			//mainGraph.addEdge(6, 5, 2, false);
			//mainGraph.addEdge(6, 7, 1, false);
			//mainGraph.addEdge(6, 8, 6, false);

			//mainGraph.addEdge(7, 0, 8, false);
			//mainGraph.addEdge(7, 1, 11, false);
			//mainGraph.addEdge(7, 6, 1, false);
			//mainGraph.addEdge(7, 8, 7, false);

			//mainGraph.addEdge(8, 2, 2, false);
			//mainGraph.addEdge(8, 6, 6, false);
			//mainGraph.addEdge(8, 7, 7, false);

			//Kruskal oKruskal = new Kruskal();
			//oKruskal.computeMST(mainGraph, numberOfVertices);

			//Prim oPrim = new Prim(numberOfVertices);
			//oPrim.computeMST(mainGraph, 0);

			//DFS oDFS = new DFS();
			//oDFS.initializeArrays(numberOfVertices);
			//oDFS.computeDFS(mainGraph, numberOfVertices, map, false);
			//oDFS.printDFS(numberOfVertices);
			//oDFS.printTopologicallySorted();
			//oDFS.computeDFS(transposeGraph, numberOfVertices, map, true);

			// shortest paths graph

			//mainGraph.addEdge(0, 1, 10, true);
			//mainGraph.addEdge(0, 3, 5, true);

			//mainGraph.addEdge(1, 2, 1, true);
			//mainGraph.addEdge(1, 3, 2, true);

			//mainGraph.addEdge(2, 4, 4, true);

			//mainGraph.addEdge(3, 1, 3, true);
			//mainGraph.addEdge(3, 2, 9, true);
			//mainGraph.addEdge(3, 4, 2, true);

			//mainGraph.addEdge(4, 0, 7, true);
			//mainGraph.addEdge(4, 2, 6, true);

			//snake and ladder

			mainGraph.addEdge(0, 1, 1, true);
			mainGraph.addEdge(1, 2, 1, true);
			mainGraph.addEdge(2, 3, 1, true);
			mainGraph.addEdge(3, 4, 1, true);
			mainGraph.addEdge(4, 5, 1, true);
			mainGraph.addEdge(5, 6, 1, true);
			mainGraph.addEdge(6, 7, 1, true);
			mainGraph.addEdge(7, 8, 1, true);
			mainGraph.addEdge(8, 9, 1, true);
			mainGraph.addEdge(9, 10, 1, true);
			mainGraph.addEdge(10,11, 1, true);
			mainGraph.addEdge(11,12, 1, true);
			mainGraph.addEdge(12,13, 1, true);
			mainGraph.addEdge(13,14, 1, true);
			mainGraph.addEdge(14,15, 1, true);
			mainGraph.addEdge(15,16, 1, true);
			mainGraph.addEdge(16,17, 1, true);
			mainGraph.addEdge(17,18, 1, true);
			mainGraph.addEdge(18,19, 1, true);
			mainGraph.addEdge(19,20, 1, true);
			mainGraph.addEdge(20,21, 1, true);
			mainGraph.addEdge(21,22, 1, true);
			mainGraph.addEdge(22,23, 1, true);
			mainGraph.addEdge(23,24, 1, true);
			mainGraph.addEdge(24,25, 1, true);
			mainGraph.addEdge(25,26, 1, true);
			mainGraph.addEdge(26,27, 1, true);
			mainGraph.addEdge(27,28, 1, true);
			mainGraph.addEdge(28,29, 1, true);

			mainGraph.addEdge(3, 22, 1, true);
			mainGraph.addEdge(5, 8, 1, true);
			mainGraph.addEdge(11, 26, 1, true);
			mainGraph.addEdge(20, 29, 1, true);
			mainGraph.addEdge(17, 4, 1, true);
			mainGraph.addEdge(19, 7, 1, true);
			mainGraph.addEdge(21, 9, 1, true);
			mainGraph.addEdge(27, 1, 1, true);


			Console.WriteLine("bellman ford : ");
			BellmanFord obf = new BellmanFord(numberOfVertices);
			obf.computeShortestPaths(mainGraph, 0);

			Console.WriteLine("dijkstra : ");
			Dijkstra oDij = new Dijkstra(numberOfVertices);
			oDij.computeShortestPaths(mainGraph, 0);
		}
	}
}
