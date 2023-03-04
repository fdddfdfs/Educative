namespace chapter_5;

public class FindMotherVertex
{
    public static int GetMotherVertex(Graph g)
    {
        var visited = new bool[g.getVertices()];
        int lastVisited = -1;
        
        for (var i = 0; i < g.getVertices(); i++)
        {
            if (!visited[i])
            {
                DeepFirstSearch(g, i, visited);
                lastVisited = i;
            }
        }

        for (var i = 0; i < visited.Length; i++)
        {
            visited[i] = false;
        }
        
        DeepFirstSearch(g, lastVisited, visited);
        
        for (var i = 0; i < visited.Length; i++)
        {
            if (!visited[i]) return -1;
        }
        
        return lastVisited;
    }

    private static void DeepFirstSearch(Graph g, int node, bool[] visited)
    {
        LinkedList linkedNodes = g.getArray()[node];

        LinkedList.Node? currentNode = linkedNodes.GetHead();

        while (currentNode != null)
        {
            if (!visited[currentNode.data])
            {
                visited[currentNode.data] = true;
                DeepFirstSearch(g, currentNode.data, visited);
            }

            currentNode = currentNode.nextElement;
        }
    }
}