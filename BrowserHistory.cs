public class Node 
{
    public string Data;
    public Node Next;  
    public Node Previous;

    public Node(string data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}
public class BrowserHistory {
    public Node head;
    public Node temp;
    public BrowserHistory(string homepage) 
    {
        head = new Node(homepage);
        temp = head;
    }
    
    public void Visit(string url)
    {
        Node node = new Node(url);
        temp.Next = node;
        node.Previous = temp;
        temp = node;
    }
    
    public string Back(int steps) 
    {
        while (steps > 0 && temp.Previous != null)
        {
            temp = temp.Previous;
            steps--;
        }
        return temp.Data;
    }
    
    public string Forward(int steps) 
    {
        while (steps > 0 && temp.Next != null)
        {
            temp = temp.Next;
            steps--;
        }
        return temp.Data;
    }
}
