namespace chapter_5;

public class Path
{
    public static bool IsPathExist(Graph g, int source, int destination)
    {
        var visited = new bool[g.getVertices()];

        return CheckPath(g, source, destination, visited);
    }

    private static bool CheckPath(Graph g, int current, int destination, bool[] visited)
    {
        if (current == destination)
            return true;

        visited[current] = true;

        LinkedList.Node node = g.getArray()[current].GetHead();
        while (node!= null)
        {
            if (!visited[node.data])
            {
                bool result = CheckPath(g, node.data, destination, visited);

                if (result) return true;
            }
            
            node = node.nextElement;
        }

        return false;
    }
}