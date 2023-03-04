namespace chapter_5;

public class MinPath
{
    public static int FindMinPath(Graph g, int source, int destination)
    {
        if (source == destination) return 0;

        bool[] visited = new bool[g.getVertices()];

        return FindPath(g, source, destination, 0, visited);
    }

    private static int FindPath(Graph g, int source, int destination, int depth, bool[] visited)
    {
        visited[source] = true;
        depth++;
        LinkedList.Node current = g.getArray()[source].GetHead();

        while (current != null)
        {
            if (current.data == destination)
            {
                return depth;
            }

            if (!visited[current.data])
            {
                int result = FindPath(g, current.data, destination, depth, visited);

                if (result != -1)
                    return result;
            }

            current = current.nextElement;
        }

        return -1;
    }
}