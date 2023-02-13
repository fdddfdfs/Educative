using chapter_5;

internal static class DetectCycle
{
    public static bool IsCycle(Graph graph)
    {
        LinkedList[] graphArray = graph.getArray();
        int graphLength = graphArray.Length;
        var checkedVertices = new bool[graphLength];
        var checkQueue = new Queue<LinkedList>();
        
        for (int i = 0; i < graphLength; i++)
        {
            if (checkedVertices[i])
            {
                continue;
            }
            
            checkQueue.Enqueue(graphArray[i]);
            HashSet<int> visited = new (){i};
            
            while (checkQueue.Count != 0)
            {
                LinkedList.Node current = checkQueue.Dequeue().GetHead();
                while (current != null)
                {
                    if (checkedVertices[current.data])
                    {
                        break;
                    }
                    
                    if (visited.Contains(current.data))
                    {
                        return true;
                    }
                    
                    visited.Add(current.data);
                    checkQueue.Enqueue(graphArray[current.data]);

                    current = current.nextElement;
                }
            }
            
            foreach (int visit in visited)
            {
                checkedVertices[visit] = true;
            }
        }
        
        return false;
    }
}