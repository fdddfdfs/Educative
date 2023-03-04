namespace chapter_5;

class GraphRemoveEdge
{
    public static void RemoveEdge(Graph g, int source, int destination)
    {
        g.getArray()[source].Delete(destination);
    }
}