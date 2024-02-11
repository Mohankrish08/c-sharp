// if else statements

using System;

class Statements 
{
    public void Voting()
    {
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age>=18)
        {
            Console.WriteLine("You are eligble for voting");
        }
        else
        {
            Console.WriteLine("You are not eligble");
        }
    }

    public void grade()
    {
        Console.WriteLine("Enter your grade: ");
        char gd = Convert.ToChar(Console.ReadLine());
        if (gd=='O' || gd=='o')
        {
            Console.WriteLine("Passed with Distinction");
        }
        else if (gd=='A' || gd=='a')
        {
            Console.WriteLine("Passed with First Class");
        }
        else if (gd=='B' || gd=='b')
        {
            Console.WriteLine("You are passed");
        }
        else
        {
            Console.WriteLine("Sorry, you are failed");
        }
    }

    public void PosNeg()
    {
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int output = (num>=0) ? 1 : -1;
        Console.WriteLine(output==1 ? "Positive" : "Negative");
    }
}

// switch case

class Switch 
{
    public void days()
    {
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;

            case 2:
                Console.WriteLine("Monday");
                break;

            case 3:
                Console.WriteLine("Tuesday");
                break;

            case 4:
                Console.WriteLine("Wednesday");
                break;

            case 5:
                Console.WriteLine("Thursday");
                break;

            case 6:
                Console.WriteLine("Friday");
                break;

            case 7:
                Console.WriteLine("Saturday");
                break;

            default:
                Console.WriteLine("Please enter a number");
                break;
        }

    }
}