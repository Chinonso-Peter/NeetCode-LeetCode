using System;
public class Solution
{
    public static void Main(string[] args)
    {
        MyStack stack = new MyStack();
        stack.Push(1);
        stack.Push(2);
        Console.WriteLine(stack.Empty());
        Console.ReadKey();
        
    }
}
public class MyStack {
    int size;
    int[] stack;
    int front;

    public MyStack()
    {
        stack = new int[2];
        front = 0;
        size = 0;
    }
    
    public void Push(int x) 
    {
        if (size != stack.Length)
        {
            stack[size] = x;
            size++;
        }
    }
    
    public int Pop() 
    {
        int res = stack[size - 1];
        size --;
        return res;
    }
    
    public int Top() {
        int res = stack[size -1];
        return res;
    }
    
    public bool Empty() {
        if (size == 0) {
            return true;
        }
        return false;
    }
}
