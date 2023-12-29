/*
 * Created by SharpDevelop.
 * User: UMUM
 * Date: 26/12/2023
 * Time: 14:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace GraphImpl
{
	/// <summary>
	/// Description of Graph.
	/// </summary>
	public class Graph
	{
		int[,] AdjacentMatrix;
		int NumberOfVertices;
		
		public Graph(int numOfVertices)
		{
			this.NumberOfVertices = numOfVertices;
			AdjacentMatrix = new int[this.NumberOfVertices, this.NumberOfVertices];
		}
		
		public void AddEdge(int v1, int v2)
		{
			this.AdjacentMatrix[v1, v2] = 1;
			this.AdjacentMatrix[v2, v1] = 1;
		}
		
		public void PrintGraph()
		{
			for (int i = 0; i < this.NumberOfVertices; i++) 
			{
				
				for (int j = 0; j < this.NumberOfVertices; j++)
				{
					Console.Write(AdjacentMatrix[i, j] + " ");
				}
				Console.WriteLine();
				
			}
		}
		
		public void DFS(int source)
		{
			Console.Write("DFS : ");
			// siapkan stack
			Stack<int> stack = new Stack<int>();
			//Siapkan flag visited
			bool[] visited = new bool[NumberOfVertices];
			
			// Masukan vertex source ke stack
			stack.Push(source);
			
			while(stack.Count > 0) {
				// visit vertex paling atas pada stack
				int current = stack.Peek();
				// tandai vertex sudah dikunjungi
//				visited[current] = true;
				// tampilkan vertex yang dikunjungi
				if (!visited[current]) 
				{
					Console.Write(current + " ");
					visited[current] = true;
				}

				int i;
				// loop ke semua adjacent vertex
				for (i = 0; i < NumberOfVertices; i++)
				{
					// Cek Apakah Adjacent Vertex Belum DiKunjungi
					if (AdjacentMatrix[current, i] == 1 && !visited[i])
					{
						stack.Push(i);
						break;
					}
				}
				// Jika tidak ada vertex adjacent yang belum dikunjungi
				// maka keluarkan vertex dari stack
				if (i == NumberOfVertices)
				{
					// pop stack
					stack.Pop();
				}
				
				
			}
			
		}
		
//			public void PrintGraphMendatar()
//			{
//			// Print Vertex Mendatar
//			Console.Write(" ");
//			
//			for (int i = 0; i < this.NumberOfVertices; i++)
//			{
//				Console.Write(i + " ");
//			}
//			
//			Console.WriteLine();
//			
//			for (int i = 0; i < this.NumberOfVertices; i++) 
//			{
//				
//				for (int j = 0; j < this.NumberOfVertices; j++)
//				{
//					Console.Write(AdjacentMatrix[i, j] + " ");
//				}
//				Console.WriteLine();
//				
//			}
//		}	
		
	}
}
