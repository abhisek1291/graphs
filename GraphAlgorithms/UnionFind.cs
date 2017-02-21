using System;
using System.Collections.Generic;

namespace GraphAlgorithms
{
	public class UnionFind
	{
		public class Node
		{
			public int data;
			public Node parent;
			public int rank;
		}

		public UnionFind()
		{
		}

		private static Dictionary<int, Node> dict = new Dictionary<int, Node>();

		public void makeSet(int vertex)
		{
			Node node = new Node();
			node.data = vertex;
			node.parent = node;
			node.rank = 0;

			dict.Add(vertex, node);
		}

		public void union(int v1, int v2)
		{
			Node n1 = dict[v1];
			Node n2 = dict[v2];

			Node parent1 = findSet(n1);
			Node parent2 = findSet(n2);

			if (parent1.data == parent2.data)
				return;

			if (parent1.rank >= parent2.rank)
			{
				parent2.parent = parent1;
				parent1.rank = (parent1.rank == parent2.rank) ? parent1.rank + 1 : parent1.rank;
			}
			else {
				parent1.parent = parent2;
				//parent2.rank = parent2.rank + 1; // Need not increase the rank here
			}
		}

		public int findSet(int data)
		{
			return findSet(dict[data]).data;
		}

		public Node findSet(Node node)
		{
			Node parent = node.parent;
			if (parent == node)
				return node;
			
			node.parent = findSet(node.parent);
			return node.parent;
		}

		public void printMap()
		{
			foreach (var k in dict)
				Console.WriteLine(k.Key + "\t" + k.Value);
		}
	}
}

