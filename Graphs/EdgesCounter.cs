namespace chapter_5;

public class EdgesCounter
{
    public static int CountEdges(Graph g)
    {
        int count = 0;
        
        for (int i = 0; i < g.getVertices(); i++)
        {
            LinkedList.Node currentNode = g.getArray()[i].GetHead();
            
            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.nextElement;
            }
        }
        
        return count / 2;
    }
}