using System;
using System.Net.Http.Headers;
public class Solution 
{
    public class ListNode 
    {
        public int Data;
        public ListNode next;
        public ListNode(int x)
        {
            Data = x;
            next = null;
        }
    }
    public static void Main(string[] args)
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);    
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);
        System.Console.WriteLine(ReverseList(head));
        Console.ReadKey();
        
    }
    public static ListNode ReverseList(ListNode head) 
    {
        ListNode prev = null;
        ListNode current = head;
        while (current.next != null)
        {
            prev = current;
            current = current.next;
            ListNode node = current;
            node.next = prev;

        }
        return prev;
    }
}
