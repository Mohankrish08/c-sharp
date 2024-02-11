// all the code are written with classes.

using System;

class Variables
{
    public void display()
    {
        int num = 5;
        double numF = 5.5;
        string str = "Hello";
        char chr = 'O';
        bool boolean = true;
        Console.WriteLine("{0} {1} {2} {3} {4}", num, numF, str, chr, boolean);

    }
    public void displayName(string name)
    {

        Console.WriteLine("Welcome "+ name);
    }
}

// type casting

class Typecasting
{
    public void Implicit()
    {
        int num = 9;
        double dnum = num;

        Type type = num.GetType();

        Console.WriteLine(type);
        Console.WriteLine(dnum);
    }

    public void Explict()
    {
        int num = 10;
        double dnum = (int) num;

        Console.WriteLine(num);
        Console.WriteLine(dnum);
    }

    public void methods()
    {
        int myInt = 10;
        double myDouble = 5.25;
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myInt));
        Console.WriteLine(Convert.ToDouble(myDouble));
        Console.WriteLine(Convert.ToString(myBool));
    }
}

// Math operations

class Mathfun
{
    public void sqrt(int num)
    {
        Console.WriteLine(Math.Sqrt(num));
    }
}