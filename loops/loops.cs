using System;

class Loops
{
    public void While()
    {
        int num = 0;
        while(num<10)
        {
            Console.WriteLine(num);
            num++;
        }
    }

    public void For()
    {
        for(int i=0; i<=10; i++)
        {
            if (i == 5) {
                continue;
            } else {
            Console.Write(i + " ");
            }
        }
        Console.WriteLine("\n");
    }

    public void ForEach()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach(string i in cars)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");
    }
}

// Factorial 

class PracticeQues
{
    public void Prime(int num)
    {
        if (num<=1)
        {
            Console.WriteLine("This is invalid");
        }
        else
        {
            for(int i=2; i<=Math.Sqrt(num); i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine("Not a Prime");
                    break;
                }
                else
                {
                    Console.WriteLine("Prime");
                }
            }
        }
    }

    public int Factorial(int num)
    {
        if (num <= 1)
    {
        return 1;
    }
    else
    {
        return num * Factorial(num - 1);
    }
    }

    public int SumEven(int start, int end)
    {
        int output = 0;
        for(int i=start; i<=end; i++)
        {
            if (i%2==0)
            {
                output += i;
            }
        }
        return output;
    }

    public void StringRev(string inp)
    {
        for(int i = inp.Length-1; i>=0; i--)
        {
            Console.Write(inp[i]);
        }
        Console.WriteLine();
    }
}