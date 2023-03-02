namespace chapter_5;

public class MinPath
{
    public static int FindMinPath(Graph g, int source, int destination)
    {
        if (source == destination) return 0;

        return FindPath(g, source, destination, 0);
    }

    private static int FindPath(Graph g, int source, int destination, int depth)
    {
        depth++;
        LinkedList.Node current = g.getArray()[source].GetHead();

        while (current != null)
        {
            if (current.data == destination)
            {
                return depth;
            }

            int result = FindPath(g, current.data, destination, depth);

            if (result != -1)
                return result;

            current = current.nextElement;
        }

        return -1;
    }
}