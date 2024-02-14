// arrays 

using System;
using System.Linq;

class Arrays
{
    public void Creating(string[] arr)
    {
        for(int i=0; i<arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.WriteLine("Array length is: " + arr.Length);
    }

    public void Looping(string[] arr)
    {
        foreach(string j in arr)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }

    public void Sorting(string[] arr)
    {
        Array.Sort(arr);
        Console.WriteLine("Array Sorting --------------------");
        foreach(string i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public void SoringNum(int[] arr)
    {
        Array.Sort(arr);
        Console.WriteLine("Array Soring Num --------------------");
        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }

    public void Application(int[] arr)
    {
        Console.WriteLine($"Maximum element in the array: {arr.Max()}");
        Console.WriteLine($"Minimum element in the array: {arr.Min()}");
        Console.WriteLine($"Sum of elements: {arr.Sum()}");
    }

    public void Mutlidim(int[,] arr) 
    {
        foreach(int i in arr)
        {
            Console.WriteLine(i);
        }
    }

    public void MultiLoop(int[,] arr)
    {
        Console.WriteLine("----------------------------------------------------------------");
        for(int i=0; i<arr.GetLength(0); i++)
        {
            for(int j=0; j<arr.GetLength(1); j++)
            {
                Console.WriteLine(arr[i,j]);
            }
        }
    }
}