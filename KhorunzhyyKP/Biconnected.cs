using System;
using System.Collections.Generic;

//https://translated.turbopages.org/proxy_u/en-ru.ru.f55a734e-62954bd9-30a0a49d-74722d776562/https/www.geeksforgeeks.org/biconnectivity-in-a-graph/

namespace KhorunzhyyKP
{
    public class Biconnected
    {
        public int Node;
        
        /// <summary>
        /// Array of lists for Adjacency (List Representation)
        /// </summary>
        private List<int>[] Adjadjacency;

        private int time = 0;
        private readonly int NIL = -1;
        
        public Biconnected(bool[,] matrix){
            Node = matrix.GetLength(0);
            Adjadjacency = new List<int>[Node];

            for (int i = 0; i < Node; ++i)
                Adjadjacency[i] = new List<int>();

            int startIndex = 1;
            for(int i = 0; i < (Node - 1); i++)
            {
                for(int j = startIndex; j < Node; j++)
                    if (matrix[i, j])
                        AddEdge(i, j);
                startIndex++;
            }
        }
        
        /// <summary>
        /// Function to add an edge into the graph
        /// </summary>
        /// <param name="v"></param>
        /// <param name="w"></param>
        private void AddEdge(int v, int w){
            // Note that the graph is undirected.
            Adjadjacency[v].Add(w);
            Adjadjacency[w].Add(v);
        }

        // A recursive function that returns true
        // if there is an articulation point in
        // given graph, otherwise returns false.
        // This function is almost same as isAPUtil()
        // @ http://goo.gl/Me9Fw
        // u --> The vertex to be visited next
        // visited[] --> keeps track of visited vertices
        // disc[] --> Stores discovery times of visited vertices
        // parent[] --> Stores parent vertices in DFS tree
        private bool IsBCUtil(int u, bool[] visited,
                      int[] disc, int[] low,
                      int[] parent){
            // Count of children in DFS Tree
            int children = 0;
            // Mark the current node as visited
            visited[u] = true;
            // Initialize discovery time and low value
            disc[u] = low[u] = ++time;
            // Go through all vertices adjacent to this
            foreach (int i in Adjadjacency[u]){
                // v is current adjacent of u
                int v = i;
                // If v is not visited yet, then
                // make it a child of u in DFS
                // tree and recur for it
                if (!visited[v]){
                    children++;
                    parent[v] = u;
                    // Check if subgraph rooted with v
                    // has an articulation point
                    if (IsBCUtil(v, visited, disc, low, parent))
                        return true;

                    // Check if the subtree rooted with
                    // v has a connection to one of
                    // the ancestors of u
                    low[u] = Math.Min(low[u], low[v]);

                    // u is an articulation point in
                    // following cases

                    // (1) u is root of DFS tree and
                    // has two or more children.
                    if (parent[u] == NIL && children > 1)
                        return true;

                    // (2) If u is not root and low
                    // value of one of its child is
                    // more than discovery value of u.
                    if (parent[u] != NIL && low[v] >= disc[u])
                        return true;
                }

                // Update low value of u for
                // parent function calls.
                else if (v != parent[u])
                    low[u] = Math.Min(low[u], disc[v]);
            }
            return false;
        }
        
        /// <summary>
        /// The main function that returns true if graph is Biconnected, otherwise false. 
        /// It uses recursive function IsBCUtil()
        /// </summary>
        /// <returns></returns>
        public bool IsBC(){
            bool[] visited = new bool[Node];
            int[] disc = new int[Node];
            int[] low = new int[Node];
            int[] parent = new int[Node];


            for (int i = 0; i < Node; i++){
                parent[i] = NIL;
                visited[i] = false;
            }

            if (IsBCUtil(0, visited, disc,
                        low, parent) == true)
                return false;
            
            for (int i = 0; i < Node; i++)
                if (visited[i] == false)
                    return false;

            return false
        }
    }
}
