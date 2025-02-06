using System;
public class Solution {
    public static void Main(string[] args)
    {
        int result = CountStudents(new int[] {1,1,0,0}, new int[] {0,1,0,1});
        System.Console.WriteLine(result);
        Console.ReadKey();
    }
    public static int CountStudents(int[] students, int[] sandwiches) 
    {
        Stack<int> sandwichStack = new Stack<int>();
        int capacity = students.Length;
        int size = capacity;
        for (int i = sandwiches.Length - 1; i >= 0; i--)
        {
            sandwichStack.Push(sandwiches[i]);
        }
        while (CheckRemain(students, sandwichStack))
        {
            if (students[0] == sandwichStack.Peek())
            {
                Dequeue(students, size);
                sandwichStack.Pop();
                size --;
            }
            else 
            {
                int temp = students[0];
                Dequeue(students, size);
                students[size - 1] = temp;
            }
        }
        return size;

    }
    public static void Dequeue(int[] stud, int size)
    {
        for (int i = 1; i < size; i++)
        {
            stud[i - 1] = stud[i];
        }
    }
    public static bool CheckRemain(int[] students, Stack<int> sandwichStack) 
    {
        foreach (var item in students)
        {
            if (sandwichStack.Count > 0 && item == sandwichStack.Peek())
            {
                return true;
            }
        }
        return false;
    }

}
