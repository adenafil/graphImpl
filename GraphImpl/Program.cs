/*
 * Created by SharpDevelop.
 * User: UMUM
 * Date: 26/12/2023
 * Time: 14:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace GraphImpl
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Graph graph = new Graph(8);
//			GraphList graph = new GraphList(5);
			
			// Menambahkan Edge
//			graph.AddEdge(0, 1);
//			graph.AddEdge(0, 2);
//			graph.AddEdge(1, 2);
//			graph.AddEdge(1, 3);
//			graph.AddEdge(2, 4);
//			graph.AddEdge(3, 4);
			
			graph.AddEdge(0, 1);
			graph.AddEdge(0, 2);
			graph.AddEdge(0, 3);
			graph.AddEdge(1, 4);
			graph.AddEdge(2, 5);
			graph.AddEdge(3, 6);
			graph.AddEdge(4, 7);
			graph.AddEdge(5, 7);
			graph.AddEdge(6, 7);
			
			// print
//			graph.printGraph();
//			graph.PrintGraphMendatar();
			graph.DFS(0);
			
			//Dictionary<String, List<String>> adjList;
			
			
		
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}