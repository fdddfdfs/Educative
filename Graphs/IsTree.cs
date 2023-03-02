namespace chapter_5;

public class IsTree
{
    public static bool CheckIsTree(Graph g)
    {
        bool[] visited = new bool[g.getVertices()];

        bool result = CheckLoop(g, 0, visited, 0);

        if (result)
            return false;

        for (int i = 0; i < visited.Length; i++)
        {
            if (!visited[i])
                return false;
        }
        
        return true;
    }

    private static bool CheckLoop(Graph g, int vertex, bool[] visited, int previous)
    {
        LinkedList.Node current = g.getArray()[vertex].GetHead();

        visited[vertex] = true;
        while (current != null)
        {
            int next = current.data;
            if (visited[next] && previous != next)
            {
                return true;
            }
            
            if (!visited[next])
            {
                CheckLoop(g, next, visited, vertex);
            }

            current = current.nextElement;
        }

        return false;
    }
}