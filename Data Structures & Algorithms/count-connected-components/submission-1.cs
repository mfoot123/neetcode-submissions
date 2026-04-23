public class Solution {
    public int CountComponents(int n, int[][] edges) {
        int result = 0;
        Dictionary<int, List<int>> adjDict = new Dictionary<int, List<int>>();

        // build adjacency list
        for (int i = 0; i < n; i++)
        {
            adjDict[i] = new List<int>();
        }

        foreach (int[] edge in edges)
        {
            int a = edge[0];
            int b = edge[1];

            adjDict[a].Add(b);
            adjDict[b].Add(a);
        }

        // DFS
        HashSet<int> seen = new HashSet<int>();

        for (int j = 0; j < n; j++)
        {
            if (!seen.Contains(j))
            {
                DFS(j, adjDict, seen);
                result++;
            }
        }

        return result;
    }

    void DFS(int node, Dictionary<int, List<int>> dict, HashSet<int> seen)
    {
        if (seen.Contains(node)) return;

        seen.Add(node);

        foreach (int neighbor in dict[node])
        {
            DFS(neighbor, dict, seen);
        }
    }
}