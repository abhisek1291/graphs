using System;
using System.Collections;
using System.Linq;

namespace GraphAlgorithms
{
	/// <summary>
	/// Max Priority queue.
	/// we'll use this in general heaps 
	/// Dijkstra and Prim (with a negative priority, 
	/// multiply the priority with -1 and initial priority = -inf instead of inf), 
	/// hence we need not write a min priority queue
	/// </summary>
	/// 
	public class PriorityQueue
	{
		private HeapClass[] arr;
		private int heapSize = 0;
		private int heapCurrentFillLevel = 0;

		public PriorityQueue(int size)
		{
			heapSize = size;
			arr = new HeapClass[heapSize];
		}

		int left(int i)
		{
			return 2 * i + 1;
		}

		int right(int i)
		{
			return 2 * i + 2;
		}

		int parent(int i)
		{
			return (i - 1) / 2;
		}

		public void insertHeap(HeapClass data)
		{
			if (heapCurrentFillLevel == heapSize)
				throw new Exception("heap size exceeded");

			heapCurrentFillLevel++;
			int currentIndex = heapCurrentFillLevel - 1;

			arr[currentIndex] = data;

			while (currentIndex != 0 && arr[parent(currentIndex)].priority < arr[currentIndex].priority)
			{
				swap(currentIndex, parent(currentIndex));
				currentIndex = parent(currentIndex);
			}
		}

		void heapify(int index)
		{
			int leftIndex = left(index);
			int rightIndex = right(index);
			int largest = index;

			if (leftIndex < heapSize && arr[leftIndex].priority > arr[largest].priority)
				largest = leftIndex;
			else if (rightIndex < heapSize && arr[rightIndex].priority > arr[largest].priority)
				largest = rightIndex;

			if (largest != index)
			{
				swap(index, largest);
				heapify(largest);
			}
		}

		void swap(int a, int b)
		{
			HeapClass temp = arr[a];
			arr[a] = arr[b];
			arr[b] = temp;
		}

		void buildMaxHeap()
		{
			int upperLimit = Convert.ToInt32((double)heapSize / 2);
			for (int i = upperLimit; i >= 0; i--)
			{
				heapify(i);
			}
		}

		public HeapClass getMax()
		{
			if (heapCurrentFillLevel <= 0)
				throw new Exception("heapsize less than 0");

			if (heapCurrentFillLevel == 1)
			{
				heapCurrentFillLevel -= 1;
				return arr[heapCurrentFillLevel];
			}

			//Console.Write(heapCurrentFillLevel);
			HeapClass element = arr[0];
			arr[0] = arr[heapCurrentFillLevel-1];
			heapCurrentFillLevel -= 1;

			heapify(0);
			return element;
		}

		public void updatePriority(HeapClass elem)
		{
			int elemIndex = Array.IndexOf(arr, arr.Where(k => k.data == elem.data).FirstOrDefault());

			arr[elemIndex].priority = elem.priority;
			while (elemIndex != 0 && arr[parent(elemIndex)].priority < arr[elemIndex].priority)
			{
				swap(elemIndex, parent(elemIndex));
				elemIndex = parent(elemIndex);
			}
		}

		public bool contains(int data)
		{
			int elemIndex = Array.IndexOf(arr, arr.Where(k => k.data == data).FirstOrDefault());
			if (elemIndex == -1)
				return false;
			else
				return true;
		}

		public int getPriority(int data)
		{
			int elemIndex = Array.IndexOf(arr, arr.Where(k => k.data == data).FirstOrDefault());
			return arr[elemIndex].priority;
		}

		public int count() {
			return heapCurrentFillLevel; 
		}
	}

	public class HeapClass
	{
		public int data;
		public int priority;
	}
}

