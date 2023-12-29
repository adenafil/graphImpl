/*
 * Created by SharpDevelop.
 * User: UMUM
 * Date: 26/12/2023
 * Time: 15:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace GraphImpl
{
	/// <summary>
	/// Description of GraphList.
	/// </summary>
	public class GraphList
	{
		List<int>[] AdjacentList;
		int NumberOfVertices;
		
		public GraphList(int numOfVertices)
		{
			this.NumberOfVertices = numOfVertices;
			AdjacentList = new List<int>[this.NumberOfVertices];
			
			// Inisialisasi objek list per index array
			for (int i = 0; i < numOfVertices; i++)
			{
				AdjacentList[i] = new List<int>();
			}
		}
		
		public void AddEdge(int v1, int v2)
		{
			AdjacentList[v1].Add(v2);
			AdjacentList[v2].Add(v1);
		}
		
		public void printGraph()
		{
			for (int i = 0; i < NumberOfVertices; i++)
			{
				Console.Write(i + " : ");
				
				for (int j = 0; j < AdjacentList[i].Count; j++)
				{
					Console.Write(AdjacentList[i][j] + " - ");
				}
				Console.WriteLine();
			}
		}
		
		
	}
}
